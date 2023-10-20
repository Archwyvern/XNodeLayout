using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Godot;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archwyvern.Nxml;

public static class SerializationManager
{
    private static Initializer _initializer;
    private static readonly object _initializerLock = new object();

    public static T GetNodeLayout<T>(Stream stream) where T : NodeLayout => (T)GetNodeLayout(stream);
    public static T GetNodeLayout<T>(string xml) where T : NodeLayout => (T)GetNodeLayout(xml);
    public static T GetNodeLayout<T>(TextReader reader) where T : NodeLayout => (T)GetNodeLayout(reader);

    public static NodeLayout GetNodeLayout(Stream stream) => GetNodeLayout(new StreamReader(stream));
    public static NodeLayout GetNodeLayout(string xml) => GetNodeLayout(new StringReader(xml));
    public static NodeLayout GetNodeLayout(TextReader reader)
    {
        if (_initializer == null) {
            Initialize().Wait();
        }

        return (NodeLayout)_initializer.Serializer.Deserialize(reader);
    }

    public sealed class Initializer
    {
        private static readonly XmlAttributeOverrides _attributeOverrides = Overrides.Create();
        internal XmlSerializer Serializer;

        public bool Finished => Serializer != null;

        private readonly long _id;

        internal Initializer(Action<double> onFinish)
        {
            double time = Time.GetUnixTimeFromSystem();

            _id = WorkerThreadPool.AddTask(
                Callable.From(
                    () => {
                        Serializer = new XmlSerializer(typeof(NodeLayout), _attributeOverrides);

                        if (onFinish != null) {
                            Callable.From(onFinish).CallDeferred(Time.GetUnixTimeFromSystem() - time);
                        }
                    }
                )
            );
        }

        public void Wait()
        {
            if (Serializer != null) {
                return;
            }

            WorkerThreadPool.WaitForTaskCompletion(_id);
        }
    }

    public static Initializer Initialize(Action onFinish = null) => Initialize(time => onFinish());
    public static Initializer Initialize(Action<double> onFinish)
    {
        lock (_initializerLock) {
            if (_initializer == null) {
                return _initializer = new Initializer(onFinish);
            }
        }

        return _initializer;
    }
}

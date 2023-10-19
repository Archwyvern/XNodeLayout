using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Godot;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archwyvern.Nxml;

public static class SerializerManager
{
    private static XmlAttributeOverrides _attributeOverrides = Overrides.Create();
    private static Dictionary<Type, XmlSerializer> _serializers = new();

    public static Tag Deserialize(string xml)
    {
        var reader = XmlReader.Create(new System.IO.StringReader(xml));
        reader.MoveToContent();

        if (!Manifest.Tags.TryGetValue(reader.Name, out Type rootType)) {
            throw new FormatException($"Unknown root element \"{reader.Name}\"");
        }

        XmlSerializer serializer;

        lock (_serializers) {
            if (!_serializers.TryGetValue(rootType, out serializer)) {
                _serializers.Add(rootType, serializer = new XmlSerializer(rootType, _attributeOverrides));
            }
        }

        lock (serializer) {
            return (Tag)serializer.Deserialize(reader);
        }
    }
}

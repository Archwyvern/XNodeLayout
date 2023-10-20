using Godot;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Archwyvern.Nxml;

public abstract partial class BaseTag
{
    internal virtual GodotObject Generate(GodotObject alt = null) => CreateObject(alt);
    internal abstract GodotObject CreateObject(GodotObject alt = null);
}

public abstract partial class BaseNodeTag : BaseTag
{
    public BaseNodeTag this[int index] => Children[index];

    public T Fetch<T>(int index) where T : BaseNodeTag => (T)this[index];

    internal override GodotObject Generate(GodotObject alt = null)
    {
        var obj = CreateObject(alt);

        foreach (var child in Children) {
            var childObj = child.Generate();

            if (childObj is Node childNode && obj is Node node) {
                node.AddChild(childNode);
            }
        }

        return obj;
    }
}

public interface IResourceTag
{
    string ResourcePath { get; set; }
}

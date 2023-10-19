using Godot;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Archwyvern.Nxml;

public abstract partial class Tag
{
    public Tag this[int index] => Children[index];

    public T Fetch<T>(int index) where T : Tag => (T)this[index];

    public Node Generate()
    {
        var node = CreateNode();

        foreach (var child in Children) {
            node.AddChild(child.Generate());
        }

        return node;
    }

    public T Generate<T>() where T : Node => (T)Generate();

    public abstract Node CreateNode();
}

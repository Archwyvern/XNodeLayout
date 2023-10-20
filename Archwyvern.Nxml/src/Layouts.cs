using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archwyvern.Nxml;

public partial class NodeLayout
{
    public T Generate<T>() where T : Node => (T)Tag.Generate();
    public Node Generate() => (Node)Tag.Generate();
}

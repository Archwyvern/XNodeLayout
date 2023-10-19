using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archwyvern.Nxml.Translators;

public struct StringName
{
    public string value;

    public static implicit operator StringName(string value) => new() { value = value };

    public static implicit operator Godot.StringName(StringName stringName) => new(stringName.value);
}
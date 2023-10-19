using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archwyvern.Nxml.Translators;

public struct Color
{
    public Godot.Color Value;

    public static implicit operator Color(string value)
    {
        Godot.Color color;
        value = value.Replace(" ", "");

        if (value.Length < 1) {
            color = new Godot.Color();
        } else if (value[0] == '#') {
            color = new Godot.Color(value);
        } else {
            string[] parts = value.Split(",");

            color = new Godot.Color() {
                R = parts.Length >= 1 ? float.Parse(parts[0]) : 0,
                G = parts.Length >= 2 ? float.Parse(parts[1]) : 0,
                B = parts.Length >= 3 ? float.Parse(parts[2]) : 0,
                A = parts.Length >= 4 ? float.Parse(parts[3]) : 1
            };
        }

        return new Color() { Value = color };
    }

    public static implicit operator Godot.Color(Color color) => new Godot.Color(color.Value);
}

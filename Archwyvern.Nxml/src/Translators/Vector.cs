using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Archwyvern.Nxml.Translators;

public struct Vector2
{
    public Godot.Vector2 Value;

    public static implicit operator Vector2(string value)
    {
        string[] parts = value.Replace(" ", "").Split(",");

        return new Vector2() {
            Value = new Godot.Vector2() {
                X = parts.Length >= 1 ? float.Parse(parts[0]) : 0,
                Y = parts.Length >= 2 ? float.Parse(parts[1]) : 0,
            }
        };
    }

    public static implicit operator Godot.Vector2(Vector2 vector) => vector.Value;
    public static implicit operator Godot.Vector2I(Vector2 vector) => (Godot.Vector2I)vector.Value;
}

public struct Vector3
{
    public Godot.Vector3 Value;

    public static implicit operator Vector3(string value)
    {
        string[] parts = value.Replace(" ", "").Split(",");

        return new Vector3() {
            Value = new Godot.Vector3() {
                X = parts.Length >= 1 ? float.Parse(parts[0]) : 0,
                Y = parts.Length >= 2 ? float.Parse(parts[1]) : 0,
                Z = parts.Length >= 3 ? float.Parse(parts[2]) : 0,
            }
        };
    }

    public static implicit operator Godot.Vector3(Vector3 vector) => vector.Value;
    public static implicit operator Godot.Vector3I(Vector3 vector) => (Godot.Vector3I)vector.Value;
}

public struct Vector4
{
    public Godot.Vector4 Value;

    public static implicit operator Vector4(string value)
    {
        string[] parts = value.Replace(" ", "").Split(",");

        return new Vector4() {
            Value = new Godot.Vector4() {
                X = parts.Length >= 1 ? float.Parse(parts[0]) : 0,
                Y = parts.Length >= 2 ? float.Parse(parts[1]) : 0,
                Z = parts.Length >= 3 ? float.Parse(parts[2]) : 0,
                W = parts.Length >= 4 ? float.Parse(parts[3]) : 0
            }
        };
    }

    public static implicit operator Godot.Vector4(Vector4 vector) => vector.Value;
    public static implicit operator Godot.Vector4I(Vector4 vector) => (Godot.Vector4I)vector.Value;
}

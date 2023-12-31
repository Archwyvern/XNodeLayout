// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CurveTexture", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class CurveTextureTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "CurveTexture.ElementProperty.Curve")] public class Curve
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Curve", Type = typeof(CurveTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Curve => _Surrogate_Element_Curve?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.Curve")] public CurveTextureTag.ElementProperty.Curve? _Surrogate_Element_Curve;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")] public string _Surrogate_Attribute_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.Width")] public string _Surrogate_Element_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Width { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextureMode")] public string _Surrogate_Attribute_TextureMode {
            get => TextureMode != null ? ((Godot.CurveTexture.TextureModeEnum)TextureMode).ToString() : "";
            set { if (value != "") { TextureMode = System.Enum.Parse<Godot.CurveTexture.TextureModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.TextureMode")] public string _Surrogate_Element_TextureMode {
            get => TextureMode != null ? ((Godot.CurveTexture.TextureModeEnum)TextureMode).ToString() : "";
            set { if (value != "") { TextureMode = System.Enum.Parse<Godot.CurveTexture.TextureModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CurveTexture.TextureModeEnum? TextureMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.CurveTexture) return alt;
            var obj = (Godot.CurveTexture)alt ?? new Godot.CurveTexture();

            // Attributes
            if (Width != null) obj.Width = (System.Int32)Width;
            if (TextureMode != null) obj.TextureMode = (Godot.CurveTexture.TextureModeEnum)TextureMode;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements
            if (Curve != null) {
                if (((IResourceTag)Curve).ResourcePath != null) {
                    obj.Curve = (Godot.Curve)Curve.Generate(Godot.GD.Load<Godot.Curve>(((IResourceTag)Curve).ResourcePath));
                } else {
                    obj.Curve = (Godot.Curve)Curve.Generate();
                }
            }

            return obj;
        }
    }
}

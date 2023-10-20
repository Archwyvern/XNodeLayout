// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "GradientTexture2D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class GradientTexture2DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "GradientTexture2D.ElementProperty.Gradient")] public class Gradient
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Gradient", Type = typeof(GradientTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Gradient => _Surrogate_Element_Gradient?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.Gradient")] public GradientTexture2DTag.ElementProperty.Gradient? _Surrogate_Element_Gradient;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")] public string _Surrogate_Attribute_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.Width")] public string _Surrogate_Element_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Width { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Height")] public string _Surrogate_Attribute_Height {
            get => Height != null ? ((System.Int32)Height).ToString() : "";
            set { if (value != "") { Height = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.Height")] public string _Surrogate_Element_Height {
            get => Height != null ? ((System.Int32)Height).ToString() : "";
            set { if (value != "") { Height = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Height { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UseHdr")] public string _Surrogate_Attribute_UseHdr {
            get => UseHdr != null ? ((System.Boolean)UseHdr).ToString() : "";
            set { if (value != "") { UseHdr = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.UseHdr")] public string _Surrogate_Element_UseHdr {
            get => UseHdr != null ? ((System.Boolean)UseHdr).ToString() : "";
            set { if (value != "") { UseHdr = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UseHdr { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Fill")] public string _Surrogate_Attribute_Fill {
            get => Fill != null ? ((Godot.GradientTexture2D.FillEnum)Fill).ToString() : "";
            set { if (value != "") { Fill = System.Enum.Parse<Godot.GradientTexture2D.FillEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.Fill")] public string _Surrogate_Element_Fill {
            get => Fill != null ? ((Godot.GradientTexture2D.FillEnum)Fill).ToString() : "";
            set { if (value != "") { Fill = System.Enum.Parse<Godot.GradientTexture2D.FillEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GradientTexture2D.FillEnum? Fill { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Repeat")] public string _Surrogate_Attribute_Repeat {
            get => Repeat != null ? ((Godot.GradientTexture2D.RepeatEnum)Repeat).ToString() : "";
            set { if (value != "") { Repeat = System.Enum.Parse<Godot.GradientTexture2D.RepeatEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.Repeat")] public string _Surrogate_Element_Repeat {
            get => Repeat != null ? ((Godot.GradientTexture2D.RepeatEnum)Repeat).ToString() : "";
            set { if (value != "") { Repeat = System.Enum.Parse<Godot.GradientTexture2D.RepeatEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GradientTexture2D.RepeatEnum? Repeat { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FillFrom")] public string _Surrogate_FillFrom {
            get => FillFrom != null ? ((Archwyvern.Nxml.Translators.Vector2)FillFrom).ToString() : "";
            set => FillFrom = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? FillFrom;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FillTo")] public string _Surrogate_FillTo {
            get => FillTo != null ? ((Archwyvern.Nxml.Translators.Vector2)FillTo).ToString() : "";
            set => FillTo = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? FillTo;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.GradientTexture2D) return alt;
            var obj = (Godot.GradientTexture2D)alt ?? new Godot.GradientTexture2D();

            // Attributes
            if (Width != null) obj.Width = (System.Int32)Width;
            if (Height != null) obj.Height = (System.Int32)Height;
            if (UseHdr != null) obj.UseHdr = (System.Boolean)UseHdr;
            if (Fill != null) obj.Fill = (Godot.GradientTexture2D.FillEnum)Fill;
            if (Repeat != null) obj.Repeat = (Godot.GradientTexture2D.RepeatEnum)Repeat;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (FillFrom != null) obj.FillFrom = (Archwyvern.Nxml.Translators.Vector2)FillFrom;
            if (FillTo != null) obj.FillTo = (Archwyvern.Nxml.Translators.Vector2)FillTo;
            // Elements
            if (Gradient != null) {
                if (((IResourceTag)Gradient).ResourcePath != null) {
                    obj.Gradient = (Godot.Gradient)Gradient.Generate(Godot.GD.Load<Godot.Gradient>(((IResourceTag)Gradient).ResourcePath));
                } else {
                    obj.Gradient = (Godot.Gradient)Gradient.Generate();
                }
            }

            return obj;
        }
    }
}

// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "GradientTexture1D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class GradientTexture1DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "GradientTexture1D.ElementProperty.Gradient")] public class Gradient
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Gradient", Type = typeof(GradientTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Gradient => _Surrogate_Element_Gradient?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.Gradient")] public GradientTexture1DTag.ElementProperty.Gradient? _Surrogate_Element_Gradient;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")] public string _Surrogate_Attribute_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.Width")] public string _Surrogate_Element_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Width { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UseHdr")] public string _Surrogate_Attribute_UseHdr {
            get => UseHdr != null ? ((System.Boolean)UseHdr).ToString() : "";
            set { if (value != "") { UseHdr = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.UseHdr")] public string _Surrogate_Element_UseHdr {
            get => UseHdr != null ? ((System.Boolean)UseHdr).ToString() : "";
            set { if (value != "") { UseHdr = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UseHdr { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.GradientTexture1D) return alt;
            var obj = (Godot.GradientTexture1D)alt ?? new Godot.GradientTexture1D();

            // Attributes
            if (Width != null) obj.Width = (System.Int32)Width;
            if (UseHdr != null) obj.UseHdr = (System.Boolean)UseHdr;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
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

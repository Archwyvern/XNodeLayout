// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "NoiseTexture3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class NoiseTexture3DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "NoiseTexture3D.ElementProperty.ColorRamp")] public class ColorRamp
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Gradient", Type = typeof(GradientTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "NoiseTexture3D.ElementProperty.Noise")] public class Noise
            {
                [System.Xml.Serialization.XmlElement(ElementName = "FastNoiseLite", Type = typeof(FastNoiseLiteTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? ColorRamp => _Surrogate_Element_ColorRamp?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.ColorRamp")] public NoiseTexture3DTag.ElementProperty.ColorRamp? _Surrogate_Element_ColorRamp;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Noise => _Surrogate_Element_Noise?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Noise")] public NoiseTexture3DTag.ElementProperty.Noise? _Surrogate_Element_Noise;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Width")] public string _Surrogate_Attribute_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Width")] public string _Surrogate_Element_Width {
            get => Width != null ? ((System.Int32)Width).ToString() : "";
            set { if (value != "") { Width = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Width { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Height")] public string _Surrogate_Attribute_Height {
            get => Height != null ? ((System.Int32)Height).ToString() : "";
            set { if (value != "") { Height = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Height")] public string _Surrogate_Element_Height {
            get => Height != null ? ((System.Int32)Height).ToString() : "";
            set { if (value != "") { Height = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Height { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Depth")] public string _Surrogate_Attribute_Depth {
            get => Depth != null ? ((System.Int32)Depth).ToString() : "";
            set { if (value != "") { Depth = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Depth")] public string _Surrogate_Element_Depth {
            get => Depth != null ? ((System.Int32)Depth).ToString() : "";
            set { if (value != "") { Depth = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Depth { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Invert")] public string _Surrogate_Attribute_Invert {
            get => Invert != null ? ((System.Boolean)Invert).ToString() : "";
            set { if (value != "") { Invert = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Invert")] public string _Surrogate_Element_Invert {
            get => Invert != null ? ((System.Boolean)Invert).ToString() : "";
            set { if (value != "") { Invert = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Invert { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Seamless")] public string _Surrogate_Attribute_Seamless {
            get => Seamless != null ? ((System.Boolean)Seamless).ToString() : "";
            set { if (value != "") { Seamless = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Seamless")] public string _Surrogate_Element_Seamless {
            get => Seamless != null ? ((System.Boolean)Seamless).ToString() : "";
            set { if (value != "") { Seamless = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Seamless { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SeamlessBlendSkirt")] public string _Surrogate_Attribute_SeamlessBlendSkirt {
            get => SeamlessBlendSkirt != null ? ((System.Single)SeamlessBlendSkirt).ToString() : "";
            set { if (value != "") { SeamlessBlendSkirt = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.SeamlessBlendSkirt")] public string _Surrogate_Element_SeamlessBlendSkirt {
            get => SeamlessBlendSkirt != null ? ((System.Single)SeamlessBlendSkirt).ToString() : "";
            set { if (value != "") { SeamlessBlendSkirt = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? SeamlessBlendSkirt { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Normalize")] public string _Surrogate_Attribute_Normalize {
            get => Normalize != null ? ((System.Boolean)Normalize).ToString() : "";
            set { if (value != "") { Normalize = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.Normalize")] public string _Surrogate_Element_Normalize {
            get => Normalize != null ? ((System.Boolean)Normalize).ToString() : "";
            set { if (value != "") { Normalize = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Normalize { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.NoiseTexture3D) return alt;
            var obj = (Godot.NoiseTexture3D)alt ?? new Godot.NoiseTexture3D();

            // Attributes
            if (Width != null) obj.Width = (System.Int32)Width;
            if (Height != null) obj.Height = (System.Int32)Height;
            if (Depth != null) obj.Depth = (System.Int32)Depth;
            if (Invert != null) obj.Invert = (System.Boolean)Invert;
            if (Seamless != null) obj.Seamless = (System.Boolean)Seamless;
            if (SeamlessBlendSkirt != null) obj.SeamlessBlendSkirt = (System.Single)SeamlessBlendSkirt;
            if (Normalize != null) obj.Normalize = (System.Boolean)Normalize;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements
            if (ColorRamp != null) {
                if (((IResourceTag)ColorRamp).ResourcePath != null) {
                    obj.ColorRamp = (Godot.Gradient)ColorRamp.Generate(Godot.GD.Load<Godot.Gradient>(((IResourceTag)ColorRamp).ResourcePath));
                } else {
                    obj.ColorRamp = (Godot.Gradient)ColorRamp.Generate();
                }
            }
            if (Noise != null) {
                if (((IResourceTag)Noise).ResourcePath != null) {
                    obj.Noise = (Godot.Noise)Noise.Generate(Godot.GD.Load<Godot.Noise>(((IResourceTag)Noise).ResourcePath));
                } else {
                    obj.Noise = (Godot.Noise)Noise.Generate();
                }
            }

            return obj;
        }
    }
}

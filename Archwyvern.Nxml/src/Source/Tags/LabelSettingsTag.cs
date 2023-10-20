// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "LabelSettings", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class LabelSettingsTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "LabelSettings.ElementProperty.Font")] public class Font
            {
                [System.Xml.Serialization.XmlElement(ElementName = "FontFile", Type = typeof(FontFileTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "FontVariation", Type = typeof(FontVariationTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "SystemFont", Type = typeof(SystemFontTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Font => _Surrogate_Element_Font?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.Font")] public LabelSettingsTag.ElementProperty.Font? _Surrogate_Element_Font;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LineSpacing")] public string _Surrogate_Attribute_LineSpacing {
            get => LineSpacing != null ? ((System.Single)LineSpacing).ToString() : "";
            set { if (value != "") { LineSpacing = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.LineSpacing")] public string _Surrogate_Element_LineSpacing {
            get => LineSpacing != null ? ((System.Single)LineSpacing).ToString() : "";
            set { if (value != "") { LineSpacing = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? LineSpacing { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FontSize")] public string _Surrogate_Attribute_FontSize {
            get => FontSize != null ? ((System.Int32)FontSize).ToString() : "";
            set { if (value != "") { FontSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.FontSize")] public string _Surrogate_Element_FontSize {
            get => FontSize != null ? ((System.Int32)FontSize).ToString() : "";
            set { if (value != "") { FontSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? FontSize { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OutlineSize")] public string _Surrogate_Attribute_OutlineSize {
            get => OutlineSize != null ? ((System.Int32)OutlineSize).ToString() : "";
            set { if (value != "") { OutlineSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.OutlineSize")] public string _Surrogate_Element_OutlineSize {
            get => OutlineSize != null ? ((System.Int32)OutlineSize).ToString() : "";
            set { if (value != "") { OutlineSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? OutlineSize { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShadowSize")] public string _Surrogate_Attribute_ShadowSize {
            get => ShadowSize != null ? ((System.Int32)ShadowSize).ToString() : "";
            set { if (value != "") { ShadowSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.ShadowSize")] public string _Surrogate_Element_ShadowSize {
            get => ShadowSize != null ? ((System.Int32)ShadowSize).ToString() : "";
            set { if (value != "") { ShadowSize = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ShadowSize { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "LabelSettings.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FontColor")] public string _Surrogate_FontColor {
            get => FontColor != null ? ((Archwyvern.Nxml.Translators.Color)FontColor).ToString() : "";
            set => FontColor = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? FontColor;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OutlineColor")] public string _Surrogate_OutlineColor {
            get => OutlineColor != null ? ((Archwyvern.Nxml.Translators.Color)OutlineColor).ToString() : "";
            set => OutlineColor = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? OutlineColor;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShadowColor")] public string _Surrogate_ShadowColor {
            get => ShadowColor != null ? ((Archwyvern.Nxml.Translators.Color)ShadowColor).ToString() : "";
            set => ShadowColor = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? ShadowColor;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShadowOffset")] public string _Surrogate_ShadowOffset {
            get => ShadowOffset != null ? ((Archwyvern.Nxml.Translators.Vector2)ShadowOffset).ToString() : "";
            set => ShadowOffset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ShadowOffset;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.LabelSettings) return alt;
            var obj = (Godot.LabelSettings)alt ?? new Godot.LabelSettings();

            // Attributes
            if (LineSpacing != null) obj.LineSpacing = (System.Single)LineSpacing;
            if (FontSize != null) obj.FontSize = (System.Int32)FontSize;
            if (OutlineSize != null) obj.OutlineSize = (System.Int32)OutlineSize;
            if (ShadowSize != null) obj.ShadowSize = (System.Int32)ShadowSize;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (FontColor != null) obj.FontColor = (Archwyvern.Nxml.Translators.Color)FontColor;
            if (OutlineColor != null) obj.OutlineColor = (Archwyvern.Nxml.Translators.Color)OutlineColor;
            if (ShadowColor != null) obj.ShadowColor = (Archwyvern.Nxml.Translators.Color)ShadowColor;
            if (ShadowOffset != null) obj.ShadowOffset = (Archwyvern.Nxml.Translators.Vector2)ShadowOffset;
            // Elements
            if (Font != null) {
                if (((IResourceTag)Font).ResourcePath != null) {
                    obj.Font = (Godot.Font)Font.Generate(Godot.GD.Load<Godot.Font>(((IResourceTag)Font).ResourcePath));
                } else {
                    obj.Font = (Godot.Font)Font.Generate();
                }
            }

            return obj;
        }
    }
}

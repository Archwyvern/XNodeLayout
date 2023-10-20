// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "TileSet", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class TileSetTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TileShape")] public string _Surrogate_Attribute_TileShape {
            get => TileShape != null ? ((Godot.TileSet.TileShapeEnum)TileShape).ToString() : "";
            set { if (value != "") { TileShape = System.Enum.Parse<Godot.TileSet.TileShapeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.TileShape")] public string _Surrogate_Element_TileShape {
            get => TileShape != null ? ((Godot.TileSet.TileShapeEnum)TileShape).ToString() : "";
            set { if (value != "") { TileShape = System.Enum.Parse<Godot.TileSet.TileShapeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.TileSet.TileShapeEnum? TileShape { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TileLayout")] public string _Surrogate_Attribute_TileLayout {
            get => TileLayout != null ? ((Godot.TileSet.TileLayoutEnum)TileLayout).ToString() : "";
            set { if (value != "") { TileLayout = System.Enum.Parse<Godot.TileSet.TileLayoutEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.TileLayout")] public string _Surrogate_Element_TileLayout {
            get => TileLayout != null ? ((Godot.TileSet.TileLayoutEnum)TileLayout).ToString() : "";
            set { if (value != "") { TileLayout = System.Enum.Parse<Godot.TileSet.TileLayoutEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.TileSet.TileLayoutEnum? TileLayout { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TileOffsetAxis")] public string _Surrogate_Attribute_TileOffsetAxis {
            get => TileOffsetAxis != null ? ((Godot.TileSet.TileOffsetAxisEnum)TileOffsetAxis).ToString() : "";
            set { if (value != "") { TileOffsetAxis = System.Enum.Parse<Godot.TileSet.TileOffsetAxisEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.TileOffsetAxis")] public string _Surrogate_Element_TileOffsetAxis {
            get => TileOffsetAxis != null ? ((Godot.TileSet.TileOffsetAxisEnum)TileOffsetAxis).ToString() : "";
            set { if (value != "") { TileOffsetAxis = System.Enum.Parse<Godot.TileSet.TileOffsetAxisEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.TileSet.TileOffsetAxisEnum? TileOffsetAxis { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UVClipping")] public string _Surrogate_Attribute_UVClipping {
            get => UVClipping != null ? ((System.Boolean)UVClipping).ToString() : "";
            set { if (value != "") { UVClipping = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.UVClipping")] public string _Surrogate_Element_UVClipping {
            get => UVClipping != null ? ((System.Boolean)UVClipping).ToString() : "";
            set { if (value != "") { UVClipping = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UVClipping { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "TileSet.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TileSize")] public string _Surrogate_TileSize {
            get => TileSize != null ? ((Archwyvern.Nxml.Translators.Vector2)TileSize).ToString() : "";
            set => TileSize = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? TileSize;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.TileSet) return alt;
            var obj = (Godot.TileSet)alt ?? new Godot.TileSet();

            // Attributes
            if (TileShape != null) obj.TileShape = (Godot.TileSet.TileShapeEnum)TileShape;
            if (TileLayout != null) obj.TileLayout = (Godot.TileSet.TileLayoutEnum)TileLayout;
            if (TileOffsetAxis != null) obj.TileOffsetAxis = (Godot.TileSet.TileOffsetAxisEnum)TileOffsetAxis;
            if (UVClipping != null) obj.UVClipping = (System.Boolean)UVClipping;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (TileSize != null) obj.TileSize = (Archwyvern.Nxml.Translators.Vector2)TileSize;
            // Elements

            return obj;
        }
    }
}
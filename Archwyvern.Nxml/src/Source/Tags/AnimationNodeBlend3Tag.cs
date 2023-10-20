// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "AnimationNodeBlend3", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class AnimationNodeBlend3Tag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Sync")] public string _Surrogate_Attribute_Sync {
            get => Sync != null ? ((System.Boolean)Sync).ToString() : "";
            set { if (value != "") { Sync = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeBlend3.Sync")] public string _Surrogate_Element_Sync {
            get => Sync != null ? ((System.Boolean)Sync).ToString() : "";
            set { if (value != "") { Sync = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Sync { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FilterEnabled")] public string _Surrogate_Attribute_FilterEnabled {
            get => FilterEnabled != null ? ((System.Boolean)FilterEnabled).ToString() : "";
            set { if (value != "") { FilterEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeBlend3.FilterEnabled")] public string _Surrogate_Element_FilterEnabled {
            get => FilterEnabled != null ? ((System.Boolean)FilterEnabled).ToString() : "";
            set { if (value != "") { FilterEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? FilterEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeBlend3.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeBlend3.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeBlend3.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.AnimationNodeBlend3) return alt;
            var obj = (Godot.AnimationNodeBlend3)alt ?? new Godot.AnimationNodeBlend3();

            // Attributes
            if (Sync != null) obj.Sync = (System.Boolean)Sync;
            if (FilterEnabled != null) obj.FilterEnabled = (System.Boolean)FilterEnabled;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements

            return obj;
        }
    }
}

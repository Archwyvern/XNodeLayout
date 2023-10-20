// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "ImmediateMesh", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class ImmediateMeshTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ImmediateMesh.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ImmediateMesh.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ImmediateMesh.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LightmapSizeHint")] public string _Surrogate_LightmapSizeHint {
            get => LightmapSizeHint != null ? ((Archwyvern.Nxml.Translators.Vector2)LightmapSizeHint).ToString() : "";
            set => LightmapSizeHint = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? LightmapSizeHint;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.ImmediateMesh) return alt;
            var obj = (Godot.ImmediateMesh)alt ?? new Godot.ImmediateMesh();

            // Attributes
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (LightmapSizeHint != null) obj.LightmapSizeHint = (Archwyvern.Nxml.Translators.Vector2)LightmapSizeHint;
            // Elements

            return obj;
        }
    }
}

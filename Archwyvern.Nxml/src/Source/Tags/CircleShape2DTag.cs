// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CircleShape2D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class CircleShape2DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Radius")] public string _Surrogate_Attribute_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CircleShape2D.Radius")] public string _Surrogate_Element_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Radius { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CustomSolverBias")] public string _Surrogate_Attribute_CustomSolverBias {
            get => CustomSolverBias != null ? ((System.Single)CustomSolverBias).ToString() : "";
            set { if (value != "") { CustomSolverBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CircleShape2D.CustomSolverBias")] public string _Surrogate_Element_CustomSolverBias {
            get => CustomSolverBias != null ? ((System.Single)CustomSolverBias).ToString() : "";
            set { if (value != "") { CustomSolverBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? CustomSolverBias { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CircleShape2D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CircleShape2D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CircleShape2D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.CircleShape2D) return alt;
            var obj = (Godot.CircleShape2D)alt ?? new Godot.CircleShape2D();

            // Attributes
            if (Radius != null) obj.Radius = (System.Single)Radius;
            if (CustomSolverBias != null) obj.CustomSolverBias = (System.Single)CustomSolverBias;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements

            return obj;
        }
    }
}

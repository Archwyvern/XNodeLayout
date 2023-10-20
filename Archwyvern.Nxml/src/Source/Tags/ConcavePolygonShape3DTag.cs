// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "ConcavePolygonShape3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class ConcavePolygonShape3DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BackfaceCollision")] public string _Surrogate_Attribute_BackfaceCollision {
            get => BackfaceCollision != null ? ((System.Boolean)BackfaceCollision).ToString() : "";
            set { if (value != "") { BackfaceCollision = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.BackfaceCollision")] public string _Surrogate_Element_BackfaceCollision {
            get => BackfaceCollision != null ? ((System.Boolean)BackfaceCollision).ToString() : "";
            set { if (value != "") { BackfaceCollision = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? BackfaceCollision { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CustomSolverBias")] public string _Surrogate_Attribute_CustomSolverBias {
            get => CustomSolverBias != null ? ((System.Single)CustomSolverBias).ToString() : "";
            set { if (value != "") { CustomSolverBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.CustomSolverBias")] public string _Surrogate_Element_CustomSolverBias {
            get => CustomSolverBias != null ? ((System.Single)CustomSolverBias).ToString() : "";
            set { if (value != "") { CustomSolverBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? CustomSolverBias { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Margin")] public string _Surrogate_Attribute_Margin {
            get => Margin != null ? ((System.Single)Margin).ToString() : "";
            set { if (value != "") { Margin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.Margin")] public string _Surrogate_Element_Margin {
            get => Margin != null ? ((System.Single)Margin).ToString() : "";
            set { if (value != "") { Margin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Margin { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ConcavePolygonShape3D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.ConcavePolygonShape3D) return alt;
            var obj = (Godot.ConcavePolygonShape3D)alt ?? new Godot.ConcavePolygonShape3D();

            // Attributes
            if (BackfaceCollision != null) obj.BackfaceCollision = (System.Boolean)BackfaceCollision;
            if (CustomSolverBias != null) obj.CustomSolverBias = (System.Single)CustomSolverBias;
            if (Margin != null) obj.Margin = (System.Single)Margin;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements

            return obj;
        }
    }
}

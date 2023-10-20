// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "ArrayMesh", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class ArrayMeshTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "ArrayMesh.ElementProperty.ShadowMesh")] public class ShadowMesh
            {
                [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh", Type = typeof(ArrayMeshTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? ShadowMesh => _Surrogate_Element_ShadowMesh?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh.ShadowMesh")] public ArrayMeshTag.ElementProperty.ShadowMesh? _Surrogate_Element_ShadowMesh;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BlendShapeMode")] public string _Surrogate_Attribute_BlendShapeMode {
            get => BlendShapeMode != null ? ((Godot.Mesh.BlendShapeMode)BlendShapeMode).ToString() : "";
            set { if (value != "") { BlendShapeMode = System.Enum.Parse<Godot.Mesh.BlendShapeMode>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh.BlendShapeMode")] public string _Surrogate_Element_BlendShapeMode {
            get => BlendShapeMode != null ? ((Godot.Mesh.BlendShapeMode)BlendShapeMode).ToString() : "";
            set { if (value != "") { BlendShapeMode = System.Enum.Parse<Godot.Mesh.BlendShapeMode>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Mesh.BlendShapeMode? BlendShapeMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ArrayMesh.ResourceName")] public string _Surrogate_Element_ResourceName {
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
            if (alt != null && alt is not Godot.ArrayMesh) return alt;
            var obj = (Godot.ArrayMesh)alt ?? new Godot.ArrayMesh();

            // Attributes
            if (BlendShapeMode != null) obj.BlendShapeMode = (Godot.Mesh.BlendShapeMode)BlendShapeMode;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (LightmapSizeHint != null) obj.LightmapSizeHint = (Archwyvern.Nxml.Translators.Vector2)LightmapSizeHint;
            // Elements
            if (ShadowMesh != null) {
                if (((IResourceTag)ShadowMesh).ResourcePath != null) {
                    obj.ShadowMesh = (Godot.ArrayMesh)ShadowMesh.Generate(Godot.GD.Load<Godot.ArrayMesh>(((IResourceTag)ShadowMesh).ResourcePath));
                } else {
                    obj.ShadowMesh = (Godot.ArrayMesh)ShadowMesh.Generate();
                }
            }

            return obj;
        }
    }
}

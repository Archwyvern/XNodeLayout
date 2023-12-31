// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "World3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class World3DTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "World3D.ElementProperty.Environment")] public class Environment
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Environment", Type = typeof(EnvironmentTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "World3D.ElementProperty.FallbackEnvironment")] public class FallbackEnvironment
            {
                [System.Xml.Serialization.XmlElement(ElementName = "Environment", Type = typeof(EnvironmentTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "World3D.ElementProperty.CameraAttributes")] public class CameraAttributes
            {
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes", Type = typeof(CameraAttributesTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributesPhysical", Type = typeof(CameraAttributesPhysicalTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributesPractical", Type = typeof(CameraAttributesPracticalTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Environment => _Surrogate_Element_Environment?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.Environment")] public World3DTag.ElementProperty.Environment? _Surrogate_Element_Environment;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? FallbackEnvironment => _Surrogate_Element_FallbackEnvironment?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.FallbackEnvironment")] public World3DTag.ElementProperty.FallbackEnvironment? _Surrogate_Element_FallbackEnvironment;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? CameraAttributes => _Surrogate_Element_CameraAttributes?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.CameraAttributes")] public World3DTag.ElementProperty.CameraAttributes? _Surrogate_Element_CameraAttributes;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "World3D.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.World3D) return alt;
            var obj = (Godot.World3D)alt ?? new Godot.World3D();

            // Attributes
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements
            if (Environment != null) {
                if (((IResourceTag)Environment).ResourcePath != null) {
                    obj.Environment = (Godot.Environment)Environment.Generate(Godot.GD.Load<Godot.Environment>(((IResourceTag)Environment).ResourcePath));
                } else {
                    obj.Environment = (Godot.Environment)Environment.Generate();
                }
            }
            if (FallbackEnvironment != null) {
                if (((IResourceTag)FallbackEnvironment).ResourcePath != null) {
                    obj.FallbackEnvironment = (Godot.Environment)FallbackEnvironment.Generate(Godot.GD.Load<Godot.Environment>(((IResourceTag)FallbackEnvironment).ResourcePath));
                } else {
                    obj.FallbackEnvironment = (Godot.Environment)FallbackEnvironment.Generate();
                }
            }
            if (CameraAttributes != null) {
                if (((IResourceTag)CameraAttributes).ResourcePath != null) {
                    obj.CameraAttributes = (Godot.CameraAttributes)CameraAttributes.Generate(Godot.GD.Load<Godot.CameraAttributes>(((IResourceTag)CameraAttributes).ResourcePath));
                } else {
                    obj.CameraAttributes = (Godot.CameraAttributes)CameraAttributes.Generate();
                }
            }

            return obj;
        }
    }
}

// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CameraAttributes", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class CameraAttributesTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ExposureSensitivity")] public string _Surrogate_Attribute_ExposureSensitivity {
            get => ExposureSensitivity != null ? ((System.Single)ExposureSensitivity).ToString() : "";
            set { if (value != "") { ExposureSensitivity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.ExposureSensitivity")] public string _Surrogate_Element_ExposureSensitivity {
            get => ExposureSensitivity != null ? ((System.Single)ExposureSensitivity).ToString() : "";
            set { if (value != "") { ExposureSensitivity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ExposureSensitivity { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ExposureMultiplier")] public string _Surrogate_Attribute_ExposureMultiplier {
            get => ExposureMultiplier != null ? ((System.Single)ExposureMultiplier).ToString() : "";
            set { if (value != "") { ExposureMultiplier = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.ExposureMultiplier")] public string _Surrogate_Element_ExposureMultiplier {
            get => ExposureMultiplier != null ? ((System.Single)ExposureMultiplier).ToString() : "";
            set { if (value != "") { ExposureMultiplier = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ExposureMultiplier { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AutoExposureEnabled")] public string _Surrogate_Attribute_AutoExposureEnabled {
            get => AutoExposureEnabled != null ? ((System.Boolean)AutoExposureEnabled).ToString() : "";
            set { if (value != "") { AutoExposureEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.AutoExposureEnabled")] public string _Surrogate_Element_AutoExposureEnabled {
            get => AutoExposureEnabled != null ? ((System.Boolean)AutoExposureEnabled).ToString() : "";
            set { if (value != "") { AutoExposureEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? AutoExposureEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AutoExposureScale")] public string _Surrogate_Attribute_AutoExposureScale {
            get => AutoExposureScale != null ? ((System.Single)AutoExposureScale).ToString() : "";
            set { if (value != "") { AutoExposureScale = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.AutoExposureScale")] public string _Surrogate_Element_AutoExposureScale {
            get => AutoExposureScale != null ? ((System.Single)AutoExposureScale).ToString() : "";
            set { if (value != "") { AutoExposureScale = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AutoExposureScale { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AutoExposureSpeed")] public string _Surrogate_Attribute_AutoExposureSpeed {
            get => AutoExposureSpeed != null ? ((System.Single)AutoExposureSpeed).ToString() : "";
            set { if (value != "") { AutoExposureSpeed = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.AutoExposureSpeed")] public string _Surrogate_Element_AutoExposureSpeed {
            get => AutoExposureSpeed != null ? ((System.Single)AutoExposureSpeed).ToString() : "";
            set { if (value != "") { AutoExposureSpeed = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AutoExposureSpeed { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.CameraAttributes) return alt;
            var obj = (Godot.CameraAttributes)alt ?? new Godot.CameraAttributes();

            // Attributes
            if (ExposureSensitivity != null) obj.ExposureSensitivity = (System.Single)ExposureSensitivity;
            if (ExposureMultiplier != null) obj.ExposureMultiplier = (System.Single)ExposureMultiplier;
            if (AutoExposureEnabled != null) obj.AutoExposureEnabled = (System.Boolean)AutoExposureEnabled;
            if (AutoExposureScale != null) obj.AutoExposureScale = (System.Single)AutoExposureScale;
            if (AutoExposureSpeed != null) obj.AutoExposureSpeed = (System.Single)AutoExposureSpeed;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements

            return obj;
        }
    }
}

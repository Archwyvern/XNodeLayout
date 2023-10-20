// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "AnimationNodeAnimation", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class AnimationNodeAnimationTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PlayMode")] public string _Surrogate_Attribute_PlayMode {
            get => PlayMode != null ? ((Godot.AnimationNodeAnimation.PlayModeEnum)PlayMode).ToString() : "";
            set { if (value != "") { PlayMode = System.Enum.Parse<Godot.AnimationNodeAnimation.PlayModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeAnimation.PlayMode")] public string _Surrogate_Element_PlayMode {
            get => PlayMode != null ? ((Godot.AnimationNodeAnimation.PlayModeEnum)PlayMode).ToString() : "";
            set { if (value != "") { PlayMode = System.Enum.Parse<Godot.AnimationNodeAnimation.PlayModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.AnimationNodeAnimation.PlayModeEnum? PlayMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FilterEnabled")] public string _Surrogate_Attribute_FilterEnabled {
            get => FilterEnabled != null ? ((System.Boolean)FilterEnabled).ToString() : "";
            set { if (value != "") { FilterEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeAnimation.FilterEnabled")] public string _Surrogate_Element_FilterEnabled {
            get => FilterEnabled != null ? ((System.Boolean)FilterEnabled).ToString() : "";
            set { if (value != "") { FilterEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? FilterEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeAnimation.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeAnimation.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "AnimationNodeAnimation.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Animation")] public string _Surrogate_Animation {
            get => Animation != null ? ((Archwyvern.Nxml.Translators.StringName)Animation).ToString() : "";
            set => Animation = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? Animation;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.AnimationNodeAnimation) return alt;
            var obj = (Godot.AnimationNodeAnimation)alt ?? new Godot.AnimationNodeAnimation();

            // Attributes
            if (PlayMode != null) obj.PlayMode = (Godot.AnimationNodeAnimation.PlayModeEnum)PlayMode;
            if (FilterEnabled != null) obj.FilterEnabled = (System.Boolean)FilterEnabled;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (Animation != null) obj.Animation = (Archwyvern.Nxml.Translators.StringName)Animation;
            // Elements

            return obj;
        }
    }
}

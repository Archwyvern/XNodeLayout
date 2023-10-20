// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "ParallaxBackground", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class ParallaxBackgroundTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollIgnoreCameraZoom")] public string _Surrogate_Attribute_ScrollIgnoreCameraZoom {
            get => ScrollIgnoreCameraZoom != null ? ((System.Boolean)ScrollIgnoreCameraZoom).ToString() : "";
            set { if (value != "") { ScrollIgnoreCameraZoom = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ScrollIgnoreCameraZoom")] public string _Surrogate_Element_ScrollIgnoreCameraZoom {
            get => ScrollIgnoreCameraZoom != null ? ((System.Boolean)ScrollIgnoreCameraZoom).ToString() : "";
            set { if (value != "") { ScrollIgnoreCameraZoom = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ScrollIgnoreCameraZoom { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Layer")] public string _Surrogate_Attribute_Layer {
            get => Layer != null ? ((System.Int32)Layer).ToString() : "";
            set { if (value != "") { Layer = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.Layer")] public string _Surrogate_Element_Layer {
            get => Layer != null ? ((System.Int32)Layer).ToString() : "";
            set { if (value != "") { Layer = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Layer { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rotation")] public string _Surrogate_Attribute_Rotation {
            get => Rotation != null ? ((System.Single)Rotation).ToString() : "";
            set { if (value != "") { Rotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.Rotation")] public string _Surrogate_Element_Rotation {
            get => Rotation != null ? ((System.Single)Rotation).ToString() : "";
            set { if (value != "") { Rotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Rotation { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FollowViewportEnabled")] public string _Surrogate_Attribute_FollowViewportEnabled {
            get => FollowViewportEnabled != null ? ((System.Boolean)FollowViewportEnabled).ToString() : "";
            set { if (value != "") { FollowViewportEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.FollowViewportEnabled")] public string _Surrogate_Element_FollowViewportEnabled {
            get => FollowViewportEnabled != null ? ((System.Boolean)FollowViewportEnabled).ToString() : "";
            set { if (value != "") { FollowViewportEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? FollowViewportEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FollowViewportScale")] public string _Surrogate_Attribute_FollowViewportScale {
            get => FollowViewportScale != null ? ((System.Single)FollowViewportScale).ToString() : "";
            set { if (value != "") { FollowViewportScale = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.FollowViewportScale")] public string _Surrogate_Element_FollowViewportScale {
            get => FollowViewportScale != null ? ((System.Single)FollowViewportScale).ToString() : "";
            set { if (value != "") { FollowViewportScale = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? FollowViewportScale { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "ParallaxBackground.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollOffset")] public string _Surrogate_ScrollOffset {
            get => ScrollOffset != null ? ((Archwyvern.Nxml.Translators.Vector2)ScrollOffset).ToString() : "";
            set => ScrollOffset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ScrollOffset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollBaseOffset")] public string _Surrogate_ScrollBaseOffset {
            get => ScrollBaseOffset != null ? ((Archwyvern.Nxml.Translators.Vector2)ScrollBaseOffset).ToString() : "";
            set => ScrollBaseOffset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ScrollBaseOffset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollBaseScale")] public string _Surrogate_ScrollBaseScale {
            get => ScrollBaseScale != null ? ((Archwyvern.Nxml.Translators.Vector2)ScrollBaseScale).ToString() : "";
            set => ScrollBaseScale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ScrollBaseScale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollLimitBegin")] public string _Surrogate_ScrollLimitBegin {
            get => ScrollLimitBegin != null ? ((Archwyvern.Nxml.Translators.Vector2)ScrollLimitBegin).ToString() : "";
            set => ScrollLimitBegin = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ScrollLimitBegin;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ScrollLimitEnd")] public string _Surrogate_ScrollLimitEnd {
            get => ScrollLimitEnd != null ? ((Archwyvern.Nxml.Translators.Vector2)ScrollLimitEnd).ToString() : "";
            set => ScrollLimitEnd = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? ScrollLimitEnd;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Offset")] public string _Surrogate_Offset {
            get => Offset != null ? ((Archwyvern.Nxml.Translators.Vector2)Offset).ToString() : "";
            set => Offset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Offset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Scale")] public string _Surrogate_Scale {
            get => Scale != null ? ((Archwyvern.Nxml.Translators.Vector2)Scale).ToString() : "";
            set => Scale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Scale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Name")] public string _Surrogate_Name {
            get => Name != null ? ((Archwyvern.Nxml.Translators.StringName)Name).ToString() : "";
            set => Name = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? Name;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.ParallaxBackground) return alt;
            var obj = (Godot.ParallaxBackground)alt ?? new Godot.ParallaxBackground();

            // Attributes
            if (ScrollIgnoreCameraZoom != null) obj.ScrollIgnoreCameraZoom = (System.Boolean)ScrollIgnoreCameraZoom;
            if (Layer != null) obj.Layer = (System.Int32)Layer;
            if (Visible != null) obj.Visible = (System.Boolean)Visible;
            if (Rotation != null) obj.Rotation = (System.Single)Rotation;
            if (FollowViewportEnabled != null) obj.FollowViewportEnabled = (System.Boolean)FollowViewportEnabled;
            if (FollowViewportScale != null) obj.FollowViewportScale = (System.Single)FollowViewportScale;
            if (UniqueNameInOwner != null) obj.UniqueNameInOwner = (System.Boolean)UniqueNameInOwner;
            if (SceneFilePath != null) obj.SceneFilePath = (System.String)SceneFilePath;
            if (ProcessMode != null) obj.ProcessMode = (Godot.Node.ProcessModeEnum)ProcessMode;
            if (ProcessPriority != null) obj.ProcessPriority = (System.Int32)ProcessPriority;
            if (ProcessPhysicsPriority != null) obj.ProcessPhysicsPriority = (System.Int32)ProcessPhysicsPriority;
            if (ProcessThreadGroup != null) obj.ProcessThreadGroup = (Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup;
            if (ProcessThreadGroupOrder != null) obj.ProcessThreadGroupOrder = (System.Int32)ProcessThreadGroupOrder;
            if (ProcessThreadMessages != null) obj.ProcessThreadMessages = (Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages;
            if (EditorDescription != null) obj.EditorDescription = (System.String)EditorDescription;
            // Overloaded Attributes
            if (ScrollOffset != null) obj.ScrollOffset = (Archwyvern.Nxml.Translators.Vector2)ScrollOffset;
            if (ScrollBaseOffset != null) obj.ScrollBaseOffset = (Archwyvern.Nxml.Translators.Vector2)ScrollBaseOffset;
            if (ScrollBaseScale != null) obj.ScrollBaseScale = (Archwyvern.Nxml.Translators.Vector2)ScrollBaseScale;
            if (ScrollLimitBegin != null) obj.ScrollLimitBegin = (Archwyvern.Nxml.Translators.Vector2)ScrollLimitBegin;
            if (ScrollLimitEnd != null) obj.ScrollLimitEnd = (Archwyvern.Nxml.Translators.Vector2)ScrollLimitEnd;
            if (Offset != null) obj.Offset = (Archwyvern.Nxml.Translators.Vector2)Offset;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector2)Scale;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements

            return obj;
        }
    }
}

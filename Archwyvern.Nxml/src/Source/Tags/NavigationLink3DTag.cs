// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "NavigationLink3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class NavigationLink3DTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Enabled")] public string _Surrogate_Attribute_Enabled {
            get => Enabled != null ? ((System.Boolean)Enabled).ToString() : "";
            set { if (value != "") { Enabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.Enabled")] public string _Surrogate_Element_Enabled {
            get => Enabled != null ? ((System.Boolean)Enabled).ToString() : "";
            set { if (value != "") { Enabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Enabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Bidirectional")] public string _Surrogate_Attribute_Bidirectional {
            get => Bidirectional != null ? ((System.Boolean)Bidirectional).ToString() : "";
            set { if (value != "") { Bidirectional = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.Bidirectional")] public string _Surrogate_Element_Bidirectional {
            get => Bidirectional != null ? ((System.Boolean)Bidirectional).ToString() : "";
            set { if (value != "") { Bidirectional = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Bidirectional { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "NavigationLayers")] public string _Surrogate_Attribute_NavigationLayers {
            get => NavigationLayers != null ? ((System.UInt32)NavigationLayers).ToString() : "";
            set { if (value != "") { NavigationLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.NavigationLayers")] public string _Surrogate_Element_NavigationLayers {
            get => NavigationLayers != null ? ((System.UInt32)NavigationLayers).ToString() : "";
            set { if (value != "") { NavigationLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? NavigationLayers { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EnterCost")] public string _Surrogate_Attribute_EnterCost {
            get => EnterCost != null ? ((System.Single)EnterCost).ToString() : "";
            set { if (value != "") { EnterCost = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.EnterCost")] public string _Surrogate_Element_EnterCost {
            get => EnterCost != null ? ((System.Single)EnterCost).ToString() : "";
            set { if (value != "") { EnterCost = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? EnterCost { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TravelCost")] public string _Surrogate_Attribute_TravelCost {
            get => TravelCost != null ? ((System.Single)TravelCost).ToString() : "";
            set { if (value != "") { TravelCost = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.TravelCost")] public string _Surrogate_Element_TravelCost {
            get => TravelCost != null ? ((System.Single)TravelCost).ToString() : "";
            set { if (value != "") { TravelCost = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? TravelCost { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationEditMode")] public string _Surrogate_Attribute_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.RotationEditMode")] public string _Surrogate_Element_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node3D.RotationEditModeEnum? RotationEditMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationOrder")] public string _Surrogate_Attribute_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.RotationOrder")] public string _Surrogate_Element_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.EulerOrder? RotationOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_Attribute_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.TopLevel")] public string _Surrogate_Element_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationLink3D.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "StartPosition")] public string _Surrogate_StartPosition {
            get => StartPosition != null ? ((Archwyvern.Nxml.Translators.Vector3)StartPosition).ToString() : "";
            set => StartPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? StartPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EndPosition")] public string _Surrogate_EndPosition {
            get => EndPosition != null ? ((Archwyvern.Nxml.Translators.Vector3)EndPosition).ToString() : "";
            set => EndPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? EndPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Position")] public string _Surrogate_Position {
            get => Position != null ? ((Archwyvern.Nxml.Translators.Vector3)Position).ToString() : "";
            set => Position = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? Position;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rotation")] public string _Surrogate_Rotation {
            get => Rotation != null ? ((Archwyvern.Nxml.Translators.Vector3)Rotation).ToString() : "";
            set => Rotation = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? Rotation;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationDegrees")] public string _Surrogate_RotationDegrees {
            get => RotationDegrees != null ? ((Archwyvern.Nxml.Translators.Vector3)RotationDegrees).ToString() : "";
            set => RotationDegrees = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? RotationDegrees;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Scale")] public string _Surrogate_Scale {
            get => Scale != null ? ((Archwyvern.Nxml.Translators.Vector3)Scale).ToString() : "";
            set => Scale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? Scale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalPosition")] public string _Surrogate_GlobalPosition {
            get => GlobalPosition != null ? ((Archwyvern.Nxml.Translators.Vector3)GlobalPosition).ToString() : "";
            set => GlobalPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? GlobalPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalRotation")] public string _Surrogate_GlobalRotation {
            get => GlobalRotation != null ? ((Archwyvern.Nxml.Translators.Vector3)GlobalRotation).ToString() : "";
            set => GlobalRotation = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? GlobalRotation;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalRotationDegrees")] public string _Surrogate_GlobalRotationDegrees {
            get => GlobalRotationDegrees != null ? ((Archwyvern.Nxml.Translators.Vector3)GlobalRotationDegrees).ToString() : "";
            set => GlobalRotationDegrees = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? GlobalRotationDegrees;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Name")] public string _Surrogate_Name {
            get => Name != null ? ((Archwyvern.Nxml.Translators.StringName)Name).ToString() : "";
            set => Name = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? Name;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.NavigationLink3D) return alt;
            var obj = (Godot.NavigationLink3D)alt ?? new Godot.NavigationLink3D();

            // Attributes
            if (Enabled != null) obj.Enabled = (System.Boolean)Enabled;
            if (Bidirectional != null) obj.Bidirectional = (System.Boolean)Bidirectional;
            if (NavigationLayers != null) obj.NavigationLayers = (System.UInt32)NavigationLayers;
            if (EnterCost != null) obj.EnterCost = (System.Single)EnterCost;
            if (TravelCost != null) obj.TravelCost = (System.Single)TravelCost;
            if (RotationEditMode != null) obj.RotationEditMode = (Godot.Node3D.RotationEditModeEnum)RotationEditMode;
            if (RotationOrder != null) obj.RotationOrder = (Godot.EulerOrder)RotationOrder;
            if (TopLevel != null) obj.TopLevel = (System.Boolean)TopLevel;
            if (Visible != null) obj.Visible = (System.Boolean)Visible;
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
            if (StartPosition != null) obj.StartPosition = (Archwyvern.Nxml.Translators.Vector3)StartPosition;
            if (EndPosition != null) obj.EndPosition = (Archwyvern.Nxml.Translators.Vector3)EndPosition;
            if (Position != null) obj.Position = (Archwyvern.Nxml.Translators.Vector3)Position;
            if (Rotation != null) obj.Rotation = (Archwyvern.Nxml.Translators.Vector3)Rotation;
            if (RotationDegrees != null) obj.RotationDegrees = (Archwyvern.Nxml.Translators.Vector3)RotationDegrees;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector3)Scale;
            if (GlobalPosition != null) obj.GlobalPosition = (Archwyvern.Nxml.Translators.Vector3)GlobalPosition;
            if (GlobalRotation != null) obj.GlobalRotation = (Archwyvern.Nxml.Translators.Vector3)GlobalRotation;
            if (GlobalRotationDegrees != null) obj.GlobalRotationDegrees = (Archwyvern.Nxml.Translators.Vector3)GlobalRotationDegrees;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements

            return obj;
        }
    }
}

// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "VoxelGI", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class VoxelGITag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "VoxelGI.ElementProperty.CameraAttributes")] public class CameraAttributes
            {
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributes", Type = typeof(CameraAttributesTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributesPhysical", Type = typeof(CameraAttributesPhysicalTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CameraAttributesPractical", Type = typeof(CameraAttributesPracticalTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "VoxelGI.ElementProperty.Data")] public class Data
            {
                [System.Xml.Serialization.XmlElement(ElementName = "VoxelGIData", Type = typeof(VoxelGIDataTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? CameraAttributes => _Surrogate_Element_CameraAttributes?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.CameraAttributes")] public VoxelGITag.ElementProperty.CameraAttributes? _Surrogate_Element_CameraAttributes;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Data => _Surrogate_Element_Data?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.Data")] public VoxelGITag.ElementProperty.Data? _Surrogate_Element_Data;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Subdiv")] public string _Surrogate_Attribute_Subdiv {
            get => Subdiv != null ? ((Godot.VoxelGI.SubdivEnum)Subdiv).ToString() : "";
            set { if (value != "") { Subdiv = System.Enum.Parse<Godot.VoxelGI.SubdivEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.Subdiv")] public string _Surrogate_Element_Subdiv {
            get => Subdiv != null ? ((Godot.VoxelGI.SubdivEnum)Subdiv).ToString() : "";
            set { if (value != "") { Subdiv = System.Enum.Parse<Godot.VoxelGI.SubdivEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.VoxelGI.SubdivEnum? Subdiv { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Layers")] public string _Surrogate_Attribute_Layers {
            get => Layers != null ? ((System.UInt32)Layers).ToString() : "";
            set { if (value != "") { Layers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.Layers")] public string _Surrogate_Element_Layers {
            get => Layers != null ? ((System.UInt32)Layers).ToString() : "";
            set { if (value != "") { Layers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? Layers { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SortingOffset")] public string _Surrogate_Attribute_SortingOffset {
            get => SortingOffset != null ? ((System.Single)SortingOffset).ToString() : "";
            set { if (value != "") { SortingOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.SortingOffset")] public string _Surrogate_Element_SortingOffset {
            get => SortingOffset != null ? ((System.Single)SortingOffset).ToString() : "";
            set { if (value != "") { SortingOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? SortingOffset { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SortingUseAabbCenter")] public string _Surrogate_Attribute_SortingUseAabbCenter {
            get => SortingUseAabbCenter != null ? ((System.Boolean)SortingUseAabbCenter).ToString() : "";
            set { if (value != "") { SortingUseAabbCenter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.SortingUseAabbCenter")] public string _Surrogate_Element_SortingUseAabbCenter {
            get => SortingUseAabbCenter != null ? ((System.Boolean)SortingUseAabbCenter).ToString() : "";
            set { if (value != "") { SortingUseAabbCenter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? SortingUseAabbCenter { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationEditMode")] public string _Surrogate_Attribute_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.RotationEditMode")] public string _Surrogate_Element_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node3D.RotationEditModeEnum? RotationEditMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationOrder")] public string _Surrogate_Attribute_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.RotationOrder")] public string _Surrogate_Element_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.EulerOrder? RotationOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_Attribute_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.TopLevel")] public string _Surrogate_Element_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "VoxelGI.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Size")] public string _Surrogate_Size {
            get => Size != null ? ((Archwyvern.Nxml.Translators.Vector3)Size).ToString() : "";
            set => Size = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? Size;
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
            if (alt != null && alt is not Godot.VoxelGI) return alt;
            var obj = (Godot.VoxelGI)alt ?? new Godot.VoxelGI();

            // Attributes
            if (Subdiv != null) obj.Subdiv = (Godot.VoxelGI.SubdivEnum)Subdiv;
            if (Layers != null) obj.Layers = (System.UInt32)Layers;
            if (SortingOffset != null) obj.SortingOffset = (System.Single)SortingOffset;
            if (SortingUseAabbCenter != null) obj.SortingUseAabbCenter = (System.Boolean)SortingUseAabbCenter;
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
            if (Size != null) obj.Size = (Archwyvern.Nxml.Translators.Vector3)Size;
            if (Position != null) obj.Position = (Archwyvern.Nxml.Translators.Vector3)Position;
            if (Rotation != null) obj.Rotation = (Archwyvern.Nxml.Translators.Vector3)Rotation;
            if (RotationDegrees != null) obj.RotationDegrees = (Archwyvern.Nxml.Translators.Vector3)RotationDegrees;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector3)Scale;
            if (GlobalPosition != null) obj.GlobalPosition = (Archwyvern.Nxml.Translators.Vector3)GlobalPosition;
            if (GlobalRotation != null) obj.GlobalRotation = (Archwyvern.Nxml.Translators.Vector3)GlobalRotation;
            if (GlobalRotationDegrees != null) obj.GlobalRotationDegrees = (Archwyvern.Nxml.Translators.Vector3)GlobalRotationDegrees;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements
            if (CameraAttributes != null) {
                if (((IResourceTag)CameraAttributes).ResourcePath != null) {
                    obj.CameraAttributes = (Godot.CameraAttributes)CameraAttributes.Generate(Godot.GD.Load<Godot.CameraAttributes>(((IResourceTag)CameraAttributes).ResourcePath));
                } else {
                    obj.CameraAttributes = (Godot.CameraAttributes)CameraAttributes.Generate();
                }
            }
            if (Data != null) {
                if (((IResourceTag)Data).ResourcePath != null) {
                    obj.Data = (Godot.VoxelGIData)Data.Generate(Godot.GD.Load<Godot.VoxelGIData>(((IResourceTag)Data).ResourcePath));
                } else {
                    obj.Data = (Godot.VoxelGIData)Data.Generate();
                }
            }

            return obj;
        }
    }
}

// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "NavigationAgent3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class NavigationAgent3DTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathDesiredDistance")] public string _Surrogate_Attribute_PathDesiredDistance {
            get => PathDesiredDistance != null ? ((System.Single)PathDesiredDistance).ToString() : "";
            set { if (value != "") { PathDesiredDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathDesiredDistance")] public string _Surrogate_Element_PathDesiredDistance {
            get => PathDesiredDistance != null ? ((System.Single)PathDesiredDistance).ToString() : "";
            set { if (value != "") { PathDesiredDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? PathDesiredDistance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TargetDesiredDistance")] public string _Surrogate_Attribute_TargetDesiredDistance {
            get => TargetDesiredDistance != null ? ((System.Single)TargetDesiredDistance).ToString() : "";
            set { if (value != "") { TargetDesiredDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.TargetDesiredDistance")] public string _Surrogate_Element_TargetDesiredDistance {
            get => TargetDesiredDistance != null ? ((System.Single)TargetDesiredDistance).ToString() : "";
            set { if (value != "") { TargetDesiredDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? TargetDesiredDistance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathHeightOffset")] public string _Surrogate_Attribute_PathHeightOffset {
            get => PathHeightOffset != null ? ((System.Single)PathHeightOffset).ToString() : "";
            set { if (value != "") { PathHeightOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathHeightOffset")] public string _Surrogate_Element_PathHeightOffset {
            get => PathHeightOffset != null ? ((System.Single)PathHeightOffset).ToString() : "";
            set { if (value != "") { PathHeightOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? PathHeightOffset { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathMaxDistance")] public string _Surrogate_Attribute_PathMaxDistance {
            get => PathMaxDistance != null ? ((System.Single)PathMaxDistance).ToString() : "";
            set { if (value != "") { PathMaxDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathMaxDistance")] public string _Surrogate_Element_PathMaxDistance {
            get => PathMaxDistance != null ? ((System.Single)PathMaxDistance).ToString() : "";
            set { if (value != "") { PathMaxDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? PathMaxDistance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "NavigationLayers")] public string _Surrogate_Attribute_NavigationLayers {
            get => NavigationLayers != null ? ((System.UInt32)NavigationLayers).ToString() : "";
            set { if (value != "") { NavigationLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.NavigationLayers")] public string _Surrogate_Element_NavigationLayers {
            get => NavigationLayers != null ? ((System.UInt32)NavigationLayers).ToString() : "";
            set { if (value != "") { NavigationLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? NavigationLayers { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathfindingAlgorithm")] public string _Surrogate_Attribute_PathfindingAlgorithm {
            get => PathfindingAlgorithm != null ? ((Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum)PathfindingAlgorithm).ToString() : "";
            set { if (value != "") { PathfindingAlgorithm = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathfindingAlgorithm")] public string _Surrogate_Element_PathfindingAlgorithm {
            get => PathfindingAlgorithm != null ? ((Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum)PathfindingAlgorithm).ToString() : "";
            set { if (value != "") { PathfindingAlgorithm = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum? PathfindingAlgorithm { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathPostprocessing")] public string _Surrogate_Attribute_PathPostprocessing {
            get => PathPostprocessing != null ? ((Godot.NavigationPathQueryParameters3D.PathPostProcessing)PathPostprocessing).ToString() : "";
            set { if (value != "") { PathPostprocessing = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathPostProcessing>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathPostprocessing")] public string _Surrogate_Element_PathPostprocessing {
            get => PathPostprocessing != null ? ((Godot.NavigationPathQueryParameters3D.PathPostProcessing)PathPostprocessing).ToString() : "";
            set { if (value != "") { PathPostprocessing = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathPostProcessing>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.NavigationPathQueryParameters3D.PathPostProcessing? PathPostprocessing { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PathMetadataFlags")] public string _Surrogate_Attribute_PathMetadataFlags {
            get => PathMetadataFlags != null ? ((Godot.NavigationPathQueryParameters3D.PathMetadataFlags)PathMetadataFlags).ToString() : "";
            set { if (value != "") { PathMetadataFlags = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathMetadataFlags>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.PathMetadataFlags")] public string _Surrogate_Element_PathMetadataFlags {
            get => PathMetadataFlags != null ? ((Godot.NavigationPathQueryParameters3D.PathMetadataFlags)PathMetadataFlags).ToString() : "";
            set { if (value != "") { PathMetadataFlags = System.Enum.Parse<Godot.NavigationPathQueryParameters3D.PathMetadataFlags>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.NavigationPathQueryParameters3D.PathMetadataFlags? PathMetadataFlags { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AvoidanceEnabled")] public string _Surrogate_Attribute_AvoidanceEnabled {
            get => AvoidanceEnabled != null ? ((System.Boolean)AvoidanceEnabled).ToString() : "";
            set { if (value != "") { AvoidanceEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.AvoidanceEnabled")] public string _Surrogate_Element_AvoidanceEnabled {
            get => AvoidanceEnabled != null ? ((System.Boolean)AvoidanceEnabled).ToString() : "";
            set { if (value != "") { AvoidanceEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? AvoidanceEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Height")] public string _Surrogate_Attribute_Height {
            get => Height != null ? ((System.Single)Height).ToString() : "";
            set { if (value != "") { Height = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.Height")] public string _Surrogate_Element_Height {
            get => Height != null ? ((System.Single)Height).ToString() : "";
            set { if (value != "") { Height = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Height { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Radius")] public string _Surrogate_Attribute_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.Radius")] public string _Surrogate_Element_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Radius { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "NeighborDistance")] public string _Surrogate_Attribute_NeighborDistance {
            get => NeighborDistance != null ? ((System.Single)NeighborDistance).ToString() : "";
            set { if (value != "") { NeighborDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.NeighborDistance")] public string _Surrogate_Element_NeighborDistance {
            get => NeighborDistance != null ? ((System.Single)NeighborDistance).ToString() : "";
            set { if (value != "") { NeighborDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? NeighborDistance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MaxNeighbors")] public string _Surrogate_Attribute_MaxNeighbors {
            get => MaxNeighbors != null ? ((System.Int32)MaxNeighbors).ToString() : "";
            set { if (value != "") { MaxNeighbors = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.MaxNeighbors")] public string _Surrogate_Element_MaxNeighbors {
            get => MaxNeighbors != null ? ((System.Int32)MaxNeighbors).ToString() : "";
            set { if (value != "") { MaxNeighbors = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? MaxNeighbors { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TimeHorizonAgents")] public string _Surrogate_Attribute_TimeHorizonAgents {
            get => TimeHorizonAgents != null ? ((System.Single)TimeHorizonAgents).ToString() : "";
            set { if (value != "") { TimeHorizonAgents = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.TimeHorizonAgents")] public string _Surrogate_Element_TimeHorizonAgents {
            get => TimeHorizonAgents != null ? ((System.Single)TimeHorizonAgents).ToString() : "";
            set { if (value != "") { TimeHorizonAgents = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? TimeHorizonAgents { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TimeHorizonObstacles")] public string _Surrogate_Attribute_TimeHorizonObstacles {
            get => TimeHorizonObstacles != null ? ((System.Single)TimeHorizonObstacles).ToString() : "";
            set { if (value != "") { TimeHorizonObstacles = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.TimeHorizonObstacles")] public string _Surrogate_Element_TimeHorizonObstacles {
            get => TimeHorizonObstacles != null ? ((System.Single)TimeHorizonObstacles).ToString() : "";
            set { if (value != "") { TimeHorizonObstacles = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? TimeHorizonObstacles { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MaxSpeed")] public string _Surrogate_Attribute_MaxSpeed {
            get => MaxSpeed != null ? ((System.Single)MaxSpeed).ToString() : "";
            set { if (value != "") { MaxSpeed = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.MaxSpeed")] public string _Surrogate_Element_MaxSpeed {
            get => MaxSpeed != null ? ((System.Single)MaxSpeed).ToString() : "";
            set { if (value != "") { MaxSpeed = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? MaxSpeed { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Use3DAvoidance")] public string _Surrogate_Attribute_Use3DAvoidance {
            get => Use3DAvoidance != null ? ((System.Boolean)Use3DAvoidance).ToString() : "";
            set { if (value != "") { Use3DAvoidance = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.Use3DAvoidance")] public string _Surrogate_Element_Use3DAvoidance {
            get => Use3DAvoidance != null ? ((System.Boolean)Use3DAvoidance).ToString() : "";
            set { if (value != "") { Use3DAvoidance = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Use3DAvoidance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AvoidanceLayers")] public string _Surrogate_Attribute_AvoidanceLayers {
            get => AvoidanceLayers != null ? ((System.UInt32)AvoidanceLayers).ToString() : "";
            set { if (value != "") { AvoidanceLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.AvoidanceLayers")] public string _Surrogate_Element_AvoidanceLayers {
            get => AvoidanceLayers != null ? ((System.UInt32)AvoidanceLayers).ToString() : "";
            set { if (value != "") { AvoidanceLayers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? AvoidanceLayers { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AvoidanceMask")] public string _Surrogate_Attribute_AvoidanceMask {
            get => AvoidanceMask != null ? ((System.UInt32)AvoidanceMask).ToString() : "";
            set { if (value != "") { AvoidanceMask = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.AvoidanceMask")] public string _Surrogate_Element_AvoidanceMask {
            get => AvoidanceMask != null ? ((System.UInt32)AvoidanceMask).ToString() : "";
            set { if (value != "") { AvoidanceMask = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? AvoidanceMask { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AvoidancePriority")] public string _Surrogate_Attribute_AvoidancePriority {
            get => AvoidancePriority != null ? ((System.Single)AvoidancePriority).ToString() : "";
            set { if (value != "") { AvoidancePriority = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.AvoidancePriority")] public string _Surrogate_Element_AvoidancePriority {
            get => AvoidancePriority != null ? ((System.Single)AvoidancePriority).ToString() : "";
            set { if (value != "") { AvoidancePriority = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AvoidancePriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DebugEnabled")] public string _Surrogate_Attribute_DebugEnabled {
            get => DebugEnabled != null ? ((System.Boolean)DebugEnabled).ToString() : "";
            set { if (value != "") { DebugEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.DebugEnabled")] public string _Surrogate_Element_DebugEnabled {
            get => DebugEnabled != null ? ((System.Boolean)DebugEnabled).ToString() : "";
            set { if (value != "") { DebugEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? DebugEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DebugUseCustom")] public string _Surrogate_Attribute_DebugUseCustom {
            get => DebugUseCustom != null ? ((System.Boolean)DebugUseCustom).ToString() : "";
            set { if (value != "") { DebugUseCustom = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.DebugUseCustom")] public string _Surrogate_Element_DebugUseCustom {
            get => DebugUseCustom != null ? ((System.Boolean)DebugUseCustom).ToString() : "";
            set { if (value != "") { DebugUseCustom = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? DebugUseCustom { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DebugPathCustomPointSize")] public string _Surrogate_Attribute_DebugPathCustomPointSize {
            get => DebugPathCustomPointSize != null ? ((System.Single)DebugPathCustomPointSize).ToString() : "";
            set { if (value != "") { DebugPathCustomPointSize = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.DebugPathCustomPointSize")] public string _Surrogate_Element_DebugPathCustomPointSize {
            get => DebugPathCustomPointSize != null ? ((System.Single)DebugPathCustomPointSize).ToString() : "";
            set { if (value != "") { DebugPathCustomPointSize = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? DebugPathCustomPointSize { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "NavigationAgent3D.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TargetPosition")] public string _Surrogate_TargetPosition {
            get => TargetPosition != null ? ((Archwyvern.Nxml.Translators.Vector3)TargetPosition).ToString() : "";
            set => TargetPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? TargetPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Velocity")] public string _Surrogate_Velocity {
            get => Velocity != null ? ((Archwyvern.Nxml.Translators.Vector3)Velocity).ToString() : "";
            set => Velocity = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? Velocity;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DebugPathCustomColor")] public string _Surrogate_DebugPathCustomColor {
            get => DebugPathCustomColor != null ? ((Archwyvern.Nxml.Translators.Color)DebugPathCustomColor).ToString() : "";
            set => DebugPathCustomColor = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? DebugPathCustomColor;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Name")] public string _Surrogate_Name {
            get => Name != null ? ((Archwyvern.Nxml.Translators.StringName)Name).ToString() : "";
            set => Name = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? Name;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.NavigationAgent3D) return alt;
            var obj = (Godot.NavigationAgent3D)alt ?? new Godot.NavigationAgent3D();

            // Attributes
            if (PathDesiredDistance != null) obj.PathDesiredDistance = (System.Single)PathDesiredDistance;
            if (TargetDesiredDistance != null) obj.TargetDesiredDistance = (System.Single)TargetDesiredDistance;
            if (PathHeightOffset != null) obj.PathHeightOffset = (System.Single)PathHeightOffset;
            if (PathMaxDistance != null) obj.PathMaxDistance = (System.Single)PathMaxDistance;
            if (NavigationLayers != null) obj.NavigationLayers = (System.UInt32)NavigationLayers;
            if (PathfindingAlgorithm != null) obj.PathfindingAlgorithm = (Godot.NavigationPathQueryParameters3D.PathfindingAlgorithmEnum)PathfindingAlgorithm;
            if (PathPostprocessing != null) obj.PathPostprocessing = (Godot.NavigationPathQueryParameters3D.PathPostProcessing)PathPostprocessing;
            if (PathMetadataFlags != null) obj.PathMetadataFlags = (Godot.NavigationPathQueryParameters3D.PathMetadataFlags)PathMetadataFlags;
            if (AvoidanceEnabled != null) obj.AvoidanceEnabled = (System.Boolean)AvoidanceEnabled;
            if (Height != null) obj.Height = (System.Single)Height;
            if (Radius != null) obj.Radius = (System.Single)Radius;
            if (NeighborDistance != null) obj.NeighborDistance = (System.Single)NeighborDistance;
            if (MaxNeighbors != null) obj.MaxNeighbors = (System.Int32)MaxNeighbors;
            if (TimeHorizonAgents != null) obj.TimeHorizonAgents = (System.Single)TimeHorizonAgents;
            if (TimeHorizonObstacles != null) obj.TimeHorizonObstacles = (System.Single)TimeHorizonObstacles;
            if (MaxSpeed != null) obj.MaxSpeed = (System.Single)MaxSpeed;
            if (Use3DAvoidance != null) obj.Use3DAvoidance = (System.Boolean)Use3DAvoidance;
            if (AvoidanceLayers != null) obj.AvoidanceLayers = (System.UInt32)AvoidanceLayers;
            if (AvoidanceMask != null) obj.AvoidanceMask = (System.UInt32)AvoidanceMask;
            if (AvoidancePriority != null) obj.AvoidancePriority = (System.Single)AvoidancePriority;
            if (DebugEnabled != null) obj.DebugEnabled = (System.Boolean)DebugEnabled;
            if (DebugUseCustom != null) obj.DebugUseCustom = (System.Boolean)DebugUseCustom;
            if (DebugPathCustomPointSize != null) obj.DebugPathCustomPointSize = (System.Single)DebugPathCustomPointSize;
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
            if (TargetPosition != null) obj.TargetPosition = (Archwyvern.Nxml.Translators.Vector3)TargetPosition;
            if (Velocity != null) obj.Velocity = (Archwyvern.Nxml.Translators.Vector3)Velocity;
            if (DebugPathCustomColor != null) obj.DebugPathCustomColor = (Archwyvern.Nxml.Translators.Color)DebugPathCustomColor;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements

            return obj;
        }
    }
}

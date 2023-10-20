// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "Area3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class Area3DTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
        }

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Monitoring")] public string _Surrogate_Attribute_Monitoring {
            get => Monitoring != null ? ((System.Boolean)Monitoring).ToString() : "";
            set { if (value != "") { Monitoring = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.Monitoring")] public string _Surrogate_Element_Monitoring {
            get => Monitoring != null ? ((System.Boolean)Monitoring).ToString() : "";
            set { if (value != "") { Monitoring = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Monitoring { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Monitorable")] public string _Surrogate_Attribute_Monitorable {
            get => Monitorable != null ? ((System.Boolean)Monitorable).ToString() : "";
            set { if (value != "") { Monitorable = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.Monitorable")] public string _Surrogate_Element_Monitorable {
            get => Monitorable != null ? ((System.Boolean)Monitorable).ToString() : "";
            set { if (value != "") { Monitorable = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Monitorable { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Priority")] public string _Surrogate_Attribute_Priority {
            get => Priority != null ? ((System.Int32)Priority).ToString() : "";
            set { if (value != "") { Priority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.Priority")] public string _Surrogate_Element_Priority {
            get => Priority != null ? ((System.Int32)Priority).ToString() : "";
            set { if (value != "") { Priority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Priority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GravitySpaceOverride")] public string _Surrogate_Attribute_GravitySpaceOverride {
            get => GravitySpaceOverride != null ? ((Godot.Area3D.SpaceOverride)GravitySpaceOverride).ToString() : "";
            set { if (value != "") { GravitySpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.GravitySpaceOverride")] public string _Surrogate_Element_GravitySpaceOverride {
            get => GravitySpaceOverride != null ? ((Godot.Area3D.SpaceOverride)GravitySpaceOverride).ToString() : "";
            set { if (value != "") { GravitySpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Area3D.SpaceOverride? GravitySpaceOverride { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GravityPoint")] public string _Surrogate_Attribute_GravityPoint {
            get => GravityPoint != null ? ((System.Boolean)GravityPoint).ToString() : "";
            set { if (value != "") { GravityPoint = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.GravityPoint")] public string _Surrogate_Element_GravityPoint {
            get => GravityPoint != null ? ((System.Boolean)GravityPoint).ToString() : "";
            set { if (value != "") { GravityPoint = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? GravityPoint { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GravityPointUnitDistance")] public string _Surrogate_Attribute_GravityPointUnitDistance {
            get => GravityPointUnitDistance != null ? ((System.Single)GravityPointUnitDistance).ToString() : "";
            set { if (value != "") { GravityPointUnitDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.GravityPointUnitDistance")] public string _Surrogate_Element_GravityPointUnitDistance {
            get => GravityPointUnitDistance != null ? ((System.Single)GravityPointUnitDistance).ToString() : "";
            set { if (value != "") { GravityPointUnitDistance = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? GravityPointUnitDistance { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Gravity")] public string _Surrogate_Attribute_Gravity {
            get => Gravity != null ? ((System.Single)Gravity).ToString() : "";
            set { if (value != "") { Gravity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.Gravity")] public string _Surrogate_Element_Gravity {
            get => Gravity != null ? ((System.Single)Gravity).ToString() : "";
            set { if (value != "") { Gravity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Gravity { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LinearDampSpaceOverride")] public string _Surrogate_Attribute_LinearDampSpaceOverride {
            get => LinearDampSpaceOverride != null ? ((Godot.Area3D.SpaceOverride)LinearDampSpaceOverride).ToString() : "";
            set { if (value != "") { LinearDampSpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.LinearDampSpaceOverride")] public string _Surrogate_Element_LinearDampSpaceOverride {
            get => LinearDampSpaceOverride != null ? ((Godot.Area3D.SpaceOverride)LinearDampSpaceOverride).ToString() : "";
            set { if (value != "") { LinearDampSpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Area3D.SpaceOverride? LinearDampSpaceOverride { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LinearDamp")] public string _Surrogate_Attribute_LinearDamp {
            get => LinearDamp != null ? ((System.Single)LinearDamp).ToString() : "";
            set { if (value != "") { LinearDamp = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.LinearDamp")] public string _Surrogate_Element_LinearDamp {
            get => LinearDamp != null ? ((System.Single)LinearDamp).ToString() : "";
            set { if (value != "") { LinearDamp = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? LinearDamp { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AngularDampSpaceOverride")] public string _Surrogate_Attribute_AngularDampSpaceOverride {
            get => AngularDampSpaceOverride != null ? ((Godot.Area3D.SpaceOverride)AngularDampSpaceOverride).ToString() : "";
            set { if (value != "") { AngularDampSpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.AngularDampSpaceOverride")] public string _Surrogate_Element_AngularDampSpaceOverride {
            get => AngularDampSpaceOverride != null ? ((Godot.Area3D.SpaceOverride)AngularDampSpaceOverride).ToString() : "";
            set { if (value != "") { AngularDampSpaceOverride = System.Enum.Parse<Godot.Area3D.SpaceOverride>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Area3D.SpaceOverride? AngularDampSpaceOverride { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AngularDamp")] public string _Surrogate_Attribute_AngularDamp {
            get => AngularDamp != null ? ((System.Single)AngularDamp).ToString() : "";
            set { if (value != "") { AngularDamp = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.AngularDamp")] public string _Surrogate_Element_AngularDamp {
            get => AngularDamp != null ? ((System.Single)AngularDamp).ToString() : "";
            set { if (value != "") { AngularDamp = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AngularDamp { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WindForceMagnitude")] public string _Surrogate_Attribute_WindForceMagnitude {
            get => WindForceMagnitude != null ? ((System.Single)WindForceMagnitude).ToString() : "";
            set { if (value != "") { WindForceMagnitude = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.WindForceMagnitude")] public string _Surrogate_Element_WindForceMagnitude {
            get => WindForceMagnitude != null ? ((System.Single)WindForceMagnitude).ToString() : "";
            set { if (value != "") { WindForceMagnitude = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? WindForceMagnitude { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "WindAttenuationFactor")] public string _Surrogate_Attribute_WindAttenuationFactor {
            get => WindAttenuationFactor != null ? ((System.Single)WindAttenuationFactor).ToString() : "";
            set { if (value != "") { WindAttenuationFactor = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.WindAttenuationFactor")] public string _Surrogate_Element_WindAttenuationFactor {
            get => WindAttenuationFactor != null ? ((System.Single)WindAttenuationFactor).ToString() : "";
            set { if (value != "") { WindAttenuationFactor = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? WindAttenuationFactor { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AudioBusOverride")] public string _Surrogate_Attribute_AudioBusOverride {
            get => AudioBusOverride != null ? ((System.Boolean)AudioBusOverride).ToString() : "";
            set { if (value != "") { AudioBusOverride = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.AudioBusOverride")] public string _Surrogate_Element_AudioBusOverride {
            get => AudioBusOverride != null ? ((System.Boolean)AudioBusOverride).ToString() : "";
            set { if (value != "") { AudioBusOverride = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? AudioBusOverride { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ReverbBusEnabled")] public string _Surrogate_Attribute_ReverbBusEnabled {
            get => ReverbBusEnabled != null ? ((System.Boolean)ReverbBusEnabled).ToString() : "";
            set { if (value != "") { ReverbBusEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ReverbBusEnabled")] public string _Surrogate_Element_ReverbBusEnabled {
            get => ReverbBusEnabled != null ? ((System.Boolean)ReverbBusEnabled).ToString() : "";
            set { if (value != "") { ReverbBusEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ReverbBusEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ReverbBusAmount")] public string _Surrogate_Attribute_ReverbBusAmount {
            get => ReverbBusAmount != null ? ((System.Single)ReverbBusAmount).ToString() : "";
            set { if (value != "") { ReverbBusAmount = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ReverbBusAmount")] public string _Surrogate_Element_ReverbBusAmount {
            get => ReverbBusAmount != null ? ((System.Single)ReverbBusAmount).ToString() : "";
            set { if (value != "") { ReverbBusAmount = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ReverbBusAmount { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ReverbBusUniformity")] public string _Surrogate_Attribute_ReverbBusUniformity {
            get => ReverbBusUniformity != null ? ((System.Single)ReverbBusUniformity).ToString() : "";
            set { if (value != "") { ReverbBusUniformity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ReverbBusUniformity")] public string _Surrogate_Element_ReverbBusUniformity {
            get => ReverbBusUniformity != null ? ((System.Single)ReverbBusUniformity).ToString() : "";
            set { if (value != "") { ReverbBusUniformity = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ReverbBusUniformity { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "DisableMode")] public string _Surrogate_Attribute_DisableMode {
            get => DisableMode != null ? ((Godot.CollisionObject3D.DisableModeEnum)DisableMode).ToString() : "";
            set { if (value != "") { DisableMode = System.Enum.Parse<Godot.CollisionObject3D.DisableModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.DisableMode")] public string _Surrogate_Element_DisableMode {
            get => DisableMode != null ? ((Godot.CollisionObject3D.DisableModeEnum)DisableMode).ToString() : "";
            set { if (value != "") { DisableMode = System.Enum.Parse<Godot.CollisionObject3D.DisableModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CollisionObject3D.DisableModeEnum? DisableMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CollisionLayer")] public string _Surrogate_Attribute_CollisionLayer {
            get => CollisionLayer != null ? ((System.UInt32)CollisionLayer).ToString() : "";
            set { if (value != "") { CollisionLayer = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.CollisionLayer")] public string _Surrogate_Element_CollisionLayer {
            get => CollisionLayer != null ? ((System.UInt32)CollisionLayer).ToString() : "";
            set { if (value != "") { CollisionLayer = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? CollisionLayer { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CollisionMask")] public string _Surrogate_Attribute_CollisionMask {
            get => CollisionMask != null ? ((System.UInt32)CollisionMask).ToString() : "";
            set { if (value != "") { CollisionMask = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.CollisionMask")] public string _Surrogate_Element_CollisionMask {
            get => CollisionMask != null ? ((System.UInt32)CollisionMask).ToString() : "";
            set { if (value != "") { CollisionMask = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? CollisionMask { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CollisionPriority")] public string _Surrogate_Attribute_CollisionPriority {
            get => CollisionPriority != null ? ((System.Single)CollisionPriority).ToString() : "";
            set { if (value != "") { CollisionPriority = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.CollisionPriority")] public string _Surrogate_Element_CollisionPriority {
            get => CollisionPriority != null ? ((System.Single)CollisionPriority).ToString() : "";
            set { if (value != "") { CollisionPriority = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? CollisionPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "InputRayPickable")] public string _Surrogate_Attribute_InputRayPickable {
            get => InputRayPickable != null ? ((System.Boolean)InputRayPickable).ToString() : "";
            set { if (value != "") { InputRayPickable = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.InputRayPickable")] public string _Surrogate_Element_InputRayPickable {
            get => InputRayPickable != null ? ((System.Boolean)InputRayPickable).ToString() : "";
            set { if (value != "") { InputRayPickable = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? InputRayPickable { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "InputCaptureOnDrag")] public string _Surrogate_Attribute_InputCaptureOnDrag {
            get => InputCaptureOnDrag != null ? ((System.Boolean)InputCaptureOnDrag).ToString() : "";
            set { if (value != "") { InputCaptureOnDrag = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.InputCaptureOnDrag")] public string _Surrogate_Element_InputCaptureOnDrag {
            get => InputCaptureOnDrag != null ? ((System.Boolean)InputCaptureOnDrag).ToString() : "";
            set { if (value != "") { InputCaptureOnDrag = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? InputCaptureOnDrag { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationEditMode")] public string _Surrogate_Attribute_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.RotationEditMode")] public string _Surrogate_Element_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node3D.RotationEditModeEnum? RotationEditMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationOrder")] public string _Surrogate_Attribute_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.RotationOrder")] public string _Surrogate_Element_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.EulerOrder? RotationOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_Attribute_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.TopLevel")] public string _Surrogate_Element_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "Area3D.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GravityPointCenter")] public string _Surrogate_GravityPointCenter {
            get => GravityPointCenter != null ? ((Archwyvern.Nxml.Translators.Vector3)GravityPointCenter).ToString() : "";
            set => GravityPointCenter = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? GravityPointCenter;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GravityDirection")] public string _Surrogate_GravityDirection {
            get => GravityDirection != null ? ((Archwyvern.Nxml.Translators.Vector3)GravityDirection).ToString() : "";
            set => GravityDirection = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector3? GravityDirection;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AudioBusName")] public string _Surrogate_AudioBusName {
            get => AudioBusName != null ? ((Archwyvern.Nxml.Translators.StringName)AudioBusName).ToString() : "";
            set => AudioBusName = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? AudioBusName;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ReverbBusName")] public string _Surrogate_ReverbBusName {
            get => ReverbBusName != null ? ((Archwyvern.Nxml.Translators.StringName)ReverbBusName).ToString() : "";
            set => ReverbBusName = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? ReverbBusName;
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
            if (alt != null && alt is not Godot.Area3D) return alt;
            var obj = (Godot.Area3D)alt ?? new Godot.Area3D();

            // Attributes
            if (Monitoring != null) obj.Monitoring = (System.Boolean)Monitoring;
            if (Monitorable != null) obj.Monitorable = (System.Boolean)Monitorable;
            if (Priority != null) obj.Priority = (System.Int32)Priority;
            if (GravitySpaceOverride != null) obj.GravitySpaceOverride = (Godot.Area3D.SpaceOverride)GravitySpaceOverride;
            if (GravityPoint != null) obj.GravityPoint = (System.Boolean)GravityPoint;
            if (GravityPointUnitDistance != null) obj.GravityPointUnitDistance = (System.Single)GravityPointUnitDistance;
            if (Gravity != null) obj.Gravity = (System.Single)Gravity;
            if (LinearDampSpaceOverride != null) obj.LinearDampSpaceOverride = (Godot.Area3D.SpaceOverride)LinearDampSpaceOverride;
            if (LinearDamp != null) obj.LinearDamp = (System.Single)LinearDamp;
            if (AngularDampSpaceOverride != null) obj.AngularDampSpaceOverride = (Godot.Area3D.SpaceOverride)AngularDampSpaceOverride;
            if (AngularDamp != null) obj.AngularDamp = (System.Single)AngularDamp;
            if (WindForceMagnitude != null) obj.WindForceMagnitude = (System.Single)WindForceMagnitude;
            if (WindAttenuationFactor != null) obj.WindAttenuationFactor = (System.Single)WindAttenuationFactor;
            if (AudioBusOverride != null) obj.AudioBusOverride = (System.Boolean)AudioBusOverride;
            if (ReverbBusEnabled != null) obj.ReverbBusEnabled = (System.Boolean)ReverbBusEnabled;
            if (ReverbBusAmount != null) obj.ReverbBusAmount = (System.Single)ReverbBusAmount;
            if (ReverbBusUniformity != null) obj.ReverbBusUniformity = (System.Single)ReverbBusUniformity;
            if (DisableMode != null) obj.DisableMode = (Godot.CollisionObject3D.DisableModeEnum)DisableMode;
            if (CollisionLayer != null) obj.CollisionLayer = (System.UInt32)CollisionLayer;
            if (CollisionMask != null) obj.CollisionMask = (System.UInt32)CollisionMask;
            if (CollisionPriority != null) obj.CollisionPriority = (System.Single)CollisionPriority;
            if (InputRayPickable != null) obj.InputRayPickable = (System.Boolean)InputRayPickable;
            if (InputCaptureOnDrag != null) obj.InputCaptureOnDrag = (System.Boolean)InputCaptureOnDrag;
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
            if (GravityPointCenter != null) obj.GravityPointCenter = (Archwyvern.Nxml.Translators.Vector3)GravityPointCenter;
            if (GravityDirection != null) obj.GravityDirection = (Archwyvern.Nxml.Translators.Vector3)GravityDirection;
            if (AudioBusName != null) obj.AudioBusName = (Archwyvern.Nxml.Translators.StringName)AudioBusName;
            if (ReverbBusName != null) obj.ReverbBusName = (Archwyvern.Nxml.Translators.StringName)ReverbBusName;
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
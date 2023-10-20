// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "PathFollow2D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class PathFollow2DTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "PathFollow2D.ElementProperty.Material")] public class Material
            {
                [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial", Type = typeof(CanvasItemMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial", Type = typeof(FogMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "Material", Type = typeof(MaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "OrmMaterial3D", Type = typeof(OrmMaterial3DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial", Type = typeof(PanoramaSkyMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ParticleProcessMaterial", Type = typeof(ParticleProcessMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PhysicalSkyMaterial", Type = typeof(PhysicalSkyMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PlaceholderMaterial", Type = typeof(PlaceholderMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ProceduralSkyMaterial", Type = typeof(ProceduralSkyMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ShaderMaterial", Type = typeof(ShaderMaterialTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "StandardMaterial3D", Type = typeof(StandardMaterial3DTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

        }

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Material => _Surrogate_Element_Material?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Material")] public PathFollow2DTag.ElementProperty.Material? _Surrogate_Element_Material;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Progress")] public string _Surrogate_Attribute_Progress {
            get => Progress != null ? ((System.Single)Progress).ToString() : "";
            set { if (value != "") { Progress = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Progress")] public string _Surrogate_Element_Progress {
            get => Progress != null ? ((System.Single)Progress).ToString() : "";
            set { if (value != "") { Progress = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Progress { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProgressRatio")] public string _Surrogate_Attribute_ProgressRatio {
            get => ProgressRatio != null ? ((System.Single)ProgressRatio).ToString() : "";
            set { if (value != "") { ProgressRatio = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProgressRatio")] public string _Surrogate_Element_ProgressRatio {
            get => ProgressRatio != null ? ((System.Single)ProgressRatio).ToString() : "";
            set { if (value != "") { ProgressRatio = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ProgressRatio { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "HOffset")] public string _Surrogate_Attribute_HOffset {
            get => HOffset != null ? ((System.Single)HOffset).ToString() : "";
            set { if (value != "") { HOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.HOffset")] public string _Surrogate_Element_HOffset {
            get => HOffset != null ? ((System.Single)HOffset).ToString() : "";
            set { if (value != "") { HOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? HOffset { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VOffset")] public string _Surrogate_Attribute_VOffset {
            get => VOffset != null ? ((System.Single)VOffset).ToString() : "";
            set { if (value != "") { VOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.VOffset")] public string _Surrogate_Element_VOffset {
            get => VOffset != null ? ((System.Single)VOffset).ToString() : "";
            set { if (value != "") { VOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? VOffset { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rotates")] public string _Surrogate_Attribute_Rotates {
            get => Rotates != null ? ((System.Boolean)Rotates).ToString() : "";
            set { if (value != "") { Rotates = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Rotates")] public string _Surrogate_Element_Rotates {
            get => Rotates != null ? ((System.Boolean)Rotates).ToString() : "";
            set { if (value != "") { Rotates = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Rotates { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CubicInterp")] public string _Surrogate_Attribute_CubicInterp {
            get => CubicInterp != null ? ((System.Boolean)CubicInterp).ToString() : "";
            set { if (value != "") { CubicInterp = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.CubicInterp")] public string _Surrogate_Element_CubicInterp {
            get => CubicInterp != null ? ((System.Boolean)CubicInterp).ToString() : "";
            set { if (value != "") { CubicInterp = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? CubicInterp { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Loop")] public string _Surrogate_Attribute_Loop {
            get => Loop != null ? ((System.Boolean)Loop).ToString() : "";
            set { if (value != "") { Loop = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Loop")] public string _Surrogate_Element_Loop {
            get => Loop != null ? ((System.Boolean)Loop).ToString() : "";
            set { if (value != "") { Loop = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Loop { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rotation")] public string _Surrogate_Attribute_Rotation {
            get => Rotation != null ? ((System.Single)Rotation).ToString() : "";
            set { if (value != "") { Rotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Rotation")] public string _Surrogate_Element_Rotation {
            get => Rotation != null ? ((System.Single)Rotation).ToString() : "";
            set { if (value != "") { Rotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Rotation { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationDegrees")] public string _Surrogate_Attribute_RotationDegrees {
            get => RotationDegrees != null ? ((System.Single)RotationDegrees).ToString() : "";
            set { if (value != "") { RotationDegrees = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.RotationDegrees")] public string _Surrogate_Element_RotationDegrees {
            get => RotationDegrees != null ? ((System.Single)RotationDegrees).ToString() : "";
            set { if (value != "") { RotationDegrees = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? RotationDegrees { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Skew")] public string _Surrogate_Attribute_Skew {
            get => Skew != null ? ((System.Single)Skew).ToString() : "";
            set { if (value != "") { Skew = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Skew")] public string _Surrogate_Element_Skew {
            get => Skew != null ? ((System.Single)Skew).ToString() : "";
            set { if (value != "") { Skew = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Skew { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalRotation")] public string _Surrogate_Attribute_GlobalRotation {
            get => GlobalRotation != null ? ((System.Single)GlobalRotation).ToString() : "";
            set { if (value != "") { GlobalRotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.GlobalRotation")] public string _Surrogate_Element_GlobalRotation {
            get => GlobalRotation != null ? ((System.Single)GlobalRotation).ToString() : "";
            set { if (value != "") { GlobalRotation = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? GlobalRotation { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalRotationDegrees")] public string _Surrogate_Attribute_GlobalRotationDegrees {
            get => GlobalRotationDegrees != null ? ((System.Single)GlobalRotationDegrees).ToString() : "";
            set { if (value != "") { GlobalRotationDegrees = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.GlobalRotationDegrees")] public string _Surrogate_Element_GlobalRotationDegrees {
            get => GlobalRotationDegrees != null ? ((System.Single)GlobalRotationDegrees).ToString() : "";
            set { if (value != "") { GlobalRotationDegrees = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? GlobalRotationDegrees { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalSkew")] public string _Surrogate_Attribute_GlobalSkew {
            get => GlobalSkew != null ? ((System.Single)GlobalSkew).ToString() : "";
            set { if (value != "") { GlobalSkew = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.GlobalSkew")] public string _Surrogate_Element_GlobalSkew {
            get => GlobalSkew != null ? ((System.Single)GlobalSkew).ToString() : "";
            set { if (value != "") { GlobalSkew = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? GlobalSkew { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShowBehindParent")] public string _Surrogate_Attribute_ShowBehindParent {
            get => ShowBehindParent != null ? ((System.Boolean)ShowBehindParent).ToString() : "";
            set { if (value != "") { ShowBehindParent = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ShowBehindParent")] public string _Surrogate_Element_ShowBehindParent {
            get => ShowBehindParent != null ? ((System.Boolean)ShowBehindParent).ToString() : "";
            set { if (value != "") { ShowBehindParent = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ShowBehindParent { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_Attribute_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.TopLevel")] public string _Surrogate_Element_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ClipChildren")] public string _Surrogate_Attribute_ClipChildren {
            get => ClipChildren != null ? ((Godot.CanvasItem.ClipChildrenMode)ClipChildren).ToString() : "";
            set { if (value != "") { ClipChildren = System.Enum.Parse<Godot.CanvasItem.ClipChildrenMode>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ClipChildren")] public string _Surrogate_Element_ClipChildren {
            get => ClipChildren != null ? ((Godot.CanvasItem.ClipChildrenMode)ClipChildren).ToString() : "";
            set { if (value != "") { ClipChildren = System.Enum.Parse<Godot.CanvasItem.ClipChildrenMode>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.ClipChildrenMode? ClipChildren { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LightMask")] public string _Surrogate_Attribute_LightMask {
            get => LightMask != null ? ((System.Int32)LightMask).ToString() : "";
            set { if (value != "") { LightMask = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.LightMask")] public string _Surrogate_Element_LightMask {
            get => LightMask != null ? ((System.Int32)LightMask).ToString() : "";
            set { if (value != "") { LightMask = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? LightMask { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityLayer")] public string _Surrogate_Attribute_VisibilityLayer {
            get => VisibilityLayer != null ? ((System.UInt32)VisibilityLayer).ToString() : "";
            set { if (value != "") { VisibilityLayer = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.VisibilityLayer")] public string _Surrogate_Element_VisibilityLayer {
            get => VisibilityLayer != null ? ((System.UInt32)VisibilityLayer).ToString() : "";
            set { if (value != "") { VisibilityLayer = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? VisibilityLayer { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ZIndex")] public string _Surrogate_Attribute_ZIndex {
            get => ZIndex != null ? ((System.Int32)ZIndex).ToString() : "";
            set { if (value != "") { ZIndex = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ZIndex")] public string _Surrogate_Element_ZIndex {
            get => ZIndex != null ? ((System.Int32)ZIndex).ToString() : "";
            set { if (value != "") { ZIndex = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ZIndex { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ZAsRelative")] public string _Surrogate_Attribute_ZAsRelative {
            get => ZAsRelative != null ? ((System.Boolean)ZAsRelative).ToString() : "";
            set { if (value != "") { ZAsRelative = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ZAsRelative")] public string _Surrogate_Element_ZAsRelative {
            get => ZAsRelative != null ? ((System.Boolean)ZAsRelative).ToString() : "";
            set { if (value != "") { ZAsRelative = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ZAsRelative { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "YSortEnabled")] public string _Surrogate_Attribute_YSortEnabled {
            get => YSortEnabled != null ? ((System.Boolean)YSortEnabled).ToString() : "";
            set { if (value != "") { YSortEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.YSortEnabled")] public string _Surrogate_Element_YSortEnabled {
            get => YSortEnabled != null ? ((System.Boolean)YSortEnabled).ToString() : "";
            set { if (value != "") { YSortEnabled = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? YSortEnabled { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextureFilter")] public string _Surrogate_Attribute_TextureFilter {
            get => TextureFilter != null ? ((Godot.CanvasItem.TextureFilterEnum)TextureFilter).ToString() : "";
            set { if (value != "") { TextureFilter = System.Enum.Parse<Godot.CanvasItem.TextureFilterEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.TextureFilter")] public string _Surrogate_Element_TextureFilter {
            get => TextureFilter != null ? ((Godot.CanvasItem.TextureFilterEnum)TextureFilter).ToString() : "";
            set { if (value != "") { TextureFilter = System.Enum.Parse<Godot.CanvasItem.TextureFilterEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.TextureFilterEnum? TextureFilter { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextureRepeat")] public string _Surrogate_Attribute_TextureRepeat {
            get => TextureRepeat != null ? ((Godot.CanvasItem.TextureRepeatEnum)TextureRepeat).ToString() : "";
            set { if (value != "") { TextureRepeat = System.Enum.Parse<Godot.CanvasItem.TextureRepeatEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.TextureRepeat")] public string _Surrogate_Element_TextureRepeat {
            get => TextureRepeat != null ? ((Godot.CanvasItem.TextureRepeatEnum)TextureRepeat).ToString() : "";
            set { if (value != "") { TextureRepeat = System.Enum.Parse<Godot.CanvasItem.TextureRepeatEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.TextureRepeatEnum? TextureRepeat { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UseParentMaterial")] public string _Surrogate_Attribute_UseParentMaterial {
            get => UseParentMaterial != null ? ((System.Boolean)UseParentMaterial).ToString() : "";
            set { if (value != "") { UseParentMaterial = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.UseParentMaterial")] public string _Surrogate_Element_UseParentMaterial {
            get => UseParentMaterial != null ? ((System.Boolean)UseParentMaterial).ToString() : "";
            set { if (value != "") { UseParentMaterial = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UseParentMaterial { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PathFollow2D.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Position")] public string _Surrogate_Position {
            get => Position != null ? ((Archwyvern.Nxml.Translators.Vector2)Position).ToString() : "";
            set => Position = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Position;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Scale")] public string _Surrogate_Scale {
            get => Scale != null ? ((Archwyvern.Nxml.Translators.Vector2)Scale).ToString() : "";
            set => Scale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Scale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalPosition")] public string _Surrogate_GlobalPosition {
            get => GlobalPosition != null ? ((Archwyvern.Nxml.Translators.Vector2)GlobalPosition).ToString() : "";
            set => GlobalPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? GlobalPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalScale")] public string _Surrogate_GlobalScale {
            get => GlobalScale != null ? ((Archwyvern.Nxml.Translators.Vector2)GlobalScale).ToString() : "";
            set => GlobalScale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? GlobalScale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Modulate")] public string _Surrogate_Modulate {
            get => Modulate != null ? ((Archwyvern.Nxml.Translators.Color)Modulate).ToString() : "";
            set => Modulate = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? Modulate;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SelfModulate")] public string _Surrogate_SelfModulate {
            get => SelfModulate != null ? ((Archwyvern.Nxml.Translators.Color)SelfModulate).ToString() : "";
            set => SelfModulate = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? SelfModulate;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Name")] public string _Surrogate_Name {
            get => Name != null ? ((Archwyvern.Nxml.Translators.StringName)Name).ToString() : "";
            set => Name = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? Name;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.PathFollow2D) return alt;
            var obj = (Godot.PathFollow2D)alt ?? new Godot.PathFollow2D();

            // Attributes
            if (Progress != null) obj.Progress = (System.Single)Progress;
            if (ProgressRatio != null) obj.ProgressRatio = (System.Single)ProgressRatio;
            if (HOffset != null) obj.HOffset = (System.Single)HOffset;
            if (VOffset != null) obj.VOffset = (System.Single)VOffset;
            if (Rotates != null) obj.Rotates = (System.Boolean)Rotates;
            if (CubicInterp != null) obj.CubicInterp = (System.Boolean)CubicInterp;
            if (Loop != null) obj.Loop = (System.Boolean)Loop;
            if (Rotation != null) obj.Rotation = (System.Single)Rotation;
            if (RotationDegrees != null) obj.RotationDegrees = (System.Single)RotationDegrees;
            if (Skew != null) obj.Skew = (System.Single)Skew;
            if (GlobalRotation != null) obj.GlobalRotation = (System.Single)GlobalRotation;
            if (GlobalRotationDegrees != null) obj.GlobalRotationDegrees = (System.Single)GlobalRotationDegrees;
            if (GlobalSkew != null) obj.GlobalSkew = (System.Single)GlobalSkew;
            if (Visible != null) obj.Visible = (System.Boolean)Visible;
            if (ShowBehindParent != null) obj.ShowBehindParent = (System.Boolean)ShowBehindParent;
            if (TopLevel != null) obj.TopLevel = (System.Boolean)TopLevel;
            if (ClipChildren != null) obj.ClipChildren = (Godot.CanvasItem.ClipChildrenMode)ClipChildren;
            if (LightMask != null) obj.LightMask = (System.Int32)LightMask;
            if (VisibilityLayer != null) obj.VisibilityLayer = (System.UInt32)VisibilityLayer;
            if (ZIndex != null) obj.ZIndex = (System.Int32)ZIndex;
            if (ZAsRelative != null) obj.ZAsRelative = (System.Boolean)ZAsRelative;
            if (YSortEnabled != null) obj.YSortEnabled = (System.Boolean)YSortEnabled;
            if (TextureFilter != null) obj.TextureFilter = (Godot.CanvasItem.TextureFilterEnum)TextureFilter;
            if (TextureRepeat != null) obj.TextureRepeat = (Godot.CanvasItem.TextureRepeatEnum)TextureRepeat;
            if (UseParentMaterial != null) obj.UseParentMaterial = (System.Boolean)UseParentMaterial;
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
            if (Position != null) obj.Position = (Archwyvern.Nxml.Translators.Vector2)Position;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector2)Scale;
            if (GlobalPosition != null) obj.GlobalPosition = (Archwyvern.Nxml.Translators.Vector2)GlobalPosition;
            if (GlobalScale != null) obj.GlobalScale = (Archwyvern.Nxml.Translators.Vector2)GlobalScale;
            if (Modulate != null) obj.Modulate = (Archwyvern.Nxml.Translators.Color)Modulate;
            if (SelfModulate != null) obj.SelfModulate = (Archwyvern.Nxml.Translators.Color)SelfModulate;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements
            if (Material != null) {
                if (((IResourceTag)Material).ResourcePath != null) {
                    obj.Material = (Godot.Material)Material.Generate(Godot.GD.Load<Godot.Material>(((IResourceTag)Material).ResourcePath));
                } else {
                    obj.Material = (Godot.Material)Material.Generate();
                }
            }

            return obj;
        }
    }
}
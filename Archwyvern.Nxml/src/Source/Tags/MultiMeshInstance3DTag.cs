// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "MultiMeshInstance3D", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class MultiMeshInstance3DTag : Archwyvern.Nxml.BaseNodeTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "MultiMeshInstance3D.ElementProperty.Multimesh")] public class Multimesh
            {
                [System.Xml.Serialization.XmlElement(ElementName = "MultiMesh", Type = typeof(MultiMeshTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "MultiMeshInstance3D.ElementProperty.MaterialOverride")] public class MaterialOverride
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

            [System.Xml.Serialization.XmlType(TypeName = "MultiMeshInstance3D.ElementProperty.MaterialOverlay")] public class MaterialOverlay
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

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Multimesh => _Surrogate_Element_Multimesh?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.Multimesh")] public MultiMeshInstance3DTag.ElementProperty.Multimesh? _Surrogate_Element_Multimesh;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? MaterialOverride => _Surrogate_Element_MaterialOverride?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.MaterialOverride")] public MultiMeshInstance3DTag.ElementProperty.MaterialOverride? _Surrogate_Element_MaterialOverride;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? MaterialOverlay => _Surrogate_Element_MaterialOverlay?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.MaterialOverlay")] public MultiMeshInstance3DTag.ElementProperty.MaterialOverlay? _Surrogate_Element_MaterialOverlay;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Transparency")] public string _Surrogate_Attribute_Transparency {
            get => Transparency != null ? ((System.Single)Transparency).ToString() : "";
            set { if (value != "") { Transparency = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.Transparency")] public string _Surrogate_Element_Transparency {
            get => Transparency != null ? ((System.Single)Transparency).ToString() : "";
            set { if (value != "") { Transparency = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Transparency { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CastShadow")] public string _Surrogate_Attribute_CastShadow {
            get => CastShadow != null ? ((Godot.GeometryInstance3D.ShadowCastingSetting)CastShadow).ToString() : "";
            set { if (value != "") { CastShadow = System.Enum.Parse<Godot.GeometryInstance3D.ShadowCastingSetting>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.CastShadow")] public string _Surrogate_Element_CastShadow {
            get => CastShadow != null ? ((Godot.GeometryInstance3D.ShadowCastingSetting)CastShadow).ToString() : "";
            set { if (value != "") { CastShadow = System.Enum.Parse<Godot.GeometryInstance3D.ShadowCastingSetting>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GeometryInstance3D.ShadowCastingSetting? CastShadow { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ExtraCullMargin")] public string _Surrogate_Attribute_ExtraCullMargin {
            get => ExtraCullMargin != null ? ((System.Single)ExtraCullMargin).ToString() : "";
            set { if (value != "") { ExtraCullMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ExtraCullMargin")] public string _Surrogate_Element_ExtraCullMargin {
            get => ExtraCullMargin != null ? ((System.Single)ExtraCullMargin).ToString() : "";
            set { if (value != "") { ExtraCullMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? ExtraCullMargin { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LodBias")] public string _Surrogate_Attribute_LodBias {
            get => LodBias != null ? ((System.Single)LodBias).ToString() : "";
            set { if (value != "") { LodBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.LodBias")] public string _Surrogate_Element_LodBias {
            get => LodBias != null ? ((System.Single)LodBias).ToString() : "";
            set { if (value != "") { LodBias = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? LodBias { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "IgnoreOcclusionCulling")] public string _Surrogate_Attribute_IgnoreOcclusionCulling {
            get => IgnoreOcclusionCulling != null ? ((System.Boolean)IgnoreOcclusionCulling).ToString() : "";
            set { if (value != "") { IgnoreOcclusionCulling = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.IgnoreOcclusionCulling")] public string _Surrogate_Element_IgnoreOcclusionCulling {
            get => IgnoreOcclusionCulling != null ? ((System.Boolean)IgnoreOcclusionCulling).ToString() : "";
            set { if (value != "") { IgnoreOcclusionCulling = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? IgnoreOcclusionCulling { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GIMode")] public string _Surrogate_Attribute_GIMode {
            get => GIMode != null ? ((Godot.GeometryInstance3D.GIModeEnum)GIMode).ToString() : "";
            set { if (value != "") { GIMode = System.Enum.Parse<Godot.GeometryInstance3D.GIModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.GIMode")] public string _Surrogate_Element_GIMode {
            get => GIMode != null ? ((Godot.GeometryInstance3D.GIModeEnum)GIMode).ToString() : "";
            set { if (value != "") { GIMode = System.Enum.Parse<Godot.GeometryInstance3D.GIModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GeometryInstance3D.GIModeEnum? GIMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GILightmapScale")] public string _Surrogate_Attribute_GILightmapScale {
            get => GILightmapScale != null ? ((Godot.GeometryInstance3D.LightmapScale)GILightmapScale).ToString() : "";
            set { if (value != "") { GILightmapScale = System.Enum.Parse<Godot.GeometryInstance3D.LightmapScale>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.GILightmapScale")] public string _Surrogate_Element_GILightmapScale {
            get => GILightmapScale != null ? ((Godot.GeometryInstance3D.LightmapScale)GILightmapScale).ToString() : "";
            set { if (value != "") { GILightmapScale = System.Enum.Parse<Godot.GeometryInstance3D.LightmapScale>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GeometryInstance3D.LightmapScale? GILightmapScale { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityRangeBegin")] public string _Surrogate_Attribute_VisibilityRangeBegin {
            get => VisibilityRangeBegin != null ? ((System.Single)VisibilityRangeBegin).ToString() : "";
            set { if (value != "") { VisibilityRangeBegin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.VisibilityRangeBegin")] public string _Surrogate_Element_VisibilityRangeBegin {
            get => VisibilityRangeBegin != null ? ((System.Single)VisibilityRangeBegin).ToString() : "";
            set { if (value != "") { VisibilityRangeBegin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? VisibilityRangeBegin { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityRangeBeginMargin")] public string _Surrogate_Attribute_VisibilityRangeBeginMargin {
            get => VisibilityRangeBeginMargin != null ? ((System.Single)VisibilityRangeBeginMargin).ToString() : "";
            set { if (value != "") { VisibilityRangeBeginMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.VisibilityRangeBeginMargin")] public string _Surrogate_Element_VisibilityRangeBeginMargin {
            get => VisibilityRangeBeginMargin != null ? ((System.Single)VisibilityRangeBeginMargin).ToString() : "";
            set { if (value != "") { VisibilityRangeBeginMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? VisibilityRangeBeginMargin { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityRangeEnd")] public string _Surrogate_Attribute_VisibilityRangeEnd {
            get => VisibilityRangeEnd != null ? ((System.Single)VisibilityRangeEnd).ToString() : "";
            set { if (value != "") { VisibilityRangeEnd = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.VisibilityRangeEnd")] public string _Surrogate_Element_VisibilityRangeEnd {
            get => VisibilityRangeEnd != null ? ((System.Single)VisibilityRangeEnd).ToString() : "";
            set { if (value != "") { VisibilityRangeEnd = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? VisibilityRangeEnd { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityRangeEndMargin")] public string _Surrogate_Attribute_VisibilityRangeEndMargin {
            get => VisibilityRangeEndMargin != null ? ((System.Single)VisibilityRangeEndMargin).ToString() : "";
            set { if (value != "") { VisibilityRangeEndMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.VisibilityRangeEndMargin")] public string _Surrogate_Element_VisibilityRangeEndMargin {
            get => VisibilityRangeEndMargin != null ? ((System.Single)VisibilityRangeEndMargin).ToString() : "";
            set { if (value != "") { VisibilityRangeEndMargin = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? VisibilityRangeEndMargin { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityRangeFadeMode")] public string _Surrogate_Attribute_VisibilityRangeFadeMode {
            get => VisibilityRangeFadeMode != null ? ((Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum)VisibilityRangeFadeMode).ToString() : "";
            set { if (value != "") { VisibilityRangeFadeMode = System.Enum.Parse<Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.VisibilityRangeFadeMode")] public string _Surrogate_Element_VisibilityRangeFadeMode {
            get => VisibilityRangeFadeMode != null ? ((Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum)VisibilityRangeFadeMode).ToString() : "";
            set { if (value != "") { VisibilityRangeFadeMode = System.Enum.Parse<Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum? VisibilityRangeFadeMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Layers")] public string _Surrogate_Attribute_Layers {
            get => Layers != null ? ((System.UInt32)Layers).ToString() : "";
            set { if (value != "") { Layers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.Layers")] public string _Surrogate_Element_Layers {
            get => Layers != null ? ((System.UInt32)Layers).ToString() : "";
            set { if (value != "") { Layers = System.UInt32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? Layers { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SortingOffset")] public string _Surrogate_Attribute_SortingOffset {
            get => SortingOffset != null ? ((System.Single)SortingOffset).ToString() : "";
            set { if (value != "") { SortingOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.SortingOffset")] public string _Surrogate_Element_SortingOffset {
            get => SortingOffset != null ? ((System.Single)SortingOffset).ToString() : "";
            set { if (value != "") { SortingOffset = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? SortingOffset { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SortingUseAabbCenter")] public string _Surrogate_Attribute_SortingUseAabbCenter {
            get => SortingUseAabbCenter != null ? ((System.Boolean)SortingUseAabbCenter).ToString() : "";
            set { if (value != "") { SortingUseAabbCenter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.SortingUseAabbCenter")] public string _Surrogate_Element_SortingUseAabbCenter {
            get => SortingUseAabbCenter != null ? ((System.Boolean)SortingUseAabbCenter).ToString() : "";
            set { if (value != "") { SortingUseAabbCenter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? SortingUseAabbCenter { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationEditMode")] public string _Surrogate_Attribute_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.RotationEditMode")] public string _Surrogate_Element_RotationEditMode {
            get => RotationEditMode != null ? ((Godot.Node3D.RotationEditModeEnum)RotationEditMode).ToString() : "";
            set { if (value != "") { RotationEditMode = System.Enum.Parse<Godot.Node3D.RotationEditModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node3D.RotationEditModeEnum? RotationEditMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationOrder")] public string _Surrogate_Attribute_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.RotationOrder")] public string _Surrogate_Element_RotationOrder {
            get => RotationOrder != null ? ((Godot.EulerOrder)RotationOrder).ToString() : "";
            set { if (value != "") { RotationOrder = System.Enum.Parse<Godot.EulerOrder>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.EulerOrder? RotationOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_Attribute_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.TopLevel")] public string _Surrogate_Element_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set { if (value != "") { TopLevel = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Attribute_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.Visible")] public string _Surrogate_Element_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set { if (value != "") { Visible = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_Attribute_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.UniqueNameInOwner")] public string _Surrogate_Element_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set { if (value != "") { UniqueNameInOwner = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_Attribute_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.SceneFilePath")] public string _Surrogate_Element_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set { if (value != "") { SceneFilePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_Attribute_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessMode")] public string _Surrogate_Element_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set { if (value != "") { ProcessMode = System.Enum.Parse<Godot.Node.ProcessModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_Attribute_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessPriority")] public string _Surrogate_Element_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set { if (value != "") { ProcessPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_Attribute_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessPhysicsPriority")] public string _Surrogate_Element_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set { if (value != "") { ProcessPhysicsPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_Attribute_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessThreadGroup")] public string _Surrogate_Element_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set { if (value != "") { ProcessThreadGroup = System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_Attribute_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessThreadGroupOrder")] public string _Surrogate_Element_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set { if (value != "") { ProcessThreadGroupOrder = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_Attribute_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.ProcessThreadMessages")] public string _Surrogate_Element_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set { if (value != "") { ProcessThreadMessages = System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_Attribute_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "MultiMeshInstance3D.EditorDescription")] public string _Surrogate_Element_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set { if (value != "") { EditorDescription = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription { get; set; }
#nullable disable

        // Overloaded Attributes
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
            if (alt != null && alt is not Godot.MultiMeshInstance3D) return alt;
            var obj = (Godot.MultiMeshInstance3D)alt ?? new Godot.MultiMeshInstance3D();

            // Attributes
            if (Transparency != null) obj.Transparency = (System.Single)Transparency;
            if (CastShadow != null) obj.CastShadow = (Godot.GeometryInstance3D.ShadowCastingSetting)CastShadow;
            if (ExtraCullMargin != null) obj.ExtraCullMargin = (System.Single)ExtraCullMargin;
            if (LodBias != null) obj.LodBias = (System.Single)LodBias;
            if (IgnoreOcclusionCulling != null) obj.IgnoreOcclusionCulling = (System.Boolean)IgnoreOcclusionCulling;
            if (GIMode != null) obj.GIMode = (Godot.GeometryInstance3D.GIModeEnum)GIMode;
            if (GILightmapScale != null) obj.GILightmapScale = (Godot.GeometryInstance3D.LightmapScale)GILightmapScale;
            if (VisibilityRangeBegin != null) obj.VisibilityRangeBegin = (System.Single)VisibilityRangeBegin;
            if (VisibilityRangeBeginMargin != null) obj.VisibilityRangeBeginMargin = (System.Single)VisibilityRangeBeginMargin;
            if (VisibilityRangeEnd != null) obj.VisibilityRangeEnd = (System.Single)VisibilityRangeEnd;
            if (VisibilityRangeEndMargin != null) obj.VisibilityRangeEndMargin = (System.Single)VisibilityRangeEndMargin;
            if (VisibilityRangeFadeMode != null) obj.VisibilityRangeFadeMode = (Godot.GeometryInstance3D.VisibilityRangeFadeModeEnum)VisibilityRangeFadeMode;
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
            if (Position != null) obj.Position = (Archwyvern.Nxml.Translators.Vector3)Position;
            if (Rotation != null) obj.Rotation = (Archwyvern.Nxml.Translators.Vector3)Rotation;
            if (RotationDegrees != null) obj.RotationDegrees = (Archwyvern.Nxml.Translators.Vector3)RotationDegrees;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector3)Scale;
            if (GlobalPosition != null) obj.GlobalPosition = (Archwyvern.Nxml.Translators.Vector3)GlobalPosition;
            if (GlobalRotation != null) obj.GlobalRotation = (Archwyvern.Nxml.Translators.Vector3)GlobalRotation;
            if (GlobalRotationDegrees != null) obj.GlobalRotationDegrees = (Archwyvern.Nxml.Translators.Vector3)GlobalRotationDegrees;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;
            // Elements
            if (Multimesh != null) {
                if (((IResourceTag)Multimesh).ResourcePath != null) {
                    obj.Multimesh = (Godot.MultiMesh)Multimesh.Generate(Godot.GD.Load<Godot.MultiMesh>(((IResourceTag)Multimesh).ResourcePath));
                } else {
                    obj.Multimesh = (Godot.MultiMesh)Multimesh.Generate();
                }
            }
            if (MaterialOverride != null) {
                if (((IResourceTag)MaterialOverride).ResourcePath != null) {
                    obj.MaterialOverride = (Godot.Material)MaterialOverride.Generate(Godot.GD.Load<Godot.Material>(((IResourceTag)MaterialOverride).ResourcePath));
                } else {
                    obj.MaterialOverride = (Godot.Material)MaterialOverride.Generate();
                }
            }
            if (MaterialOverlay != null) {
                if (((IResourceTag)MaterialOverlay).ResourcePath != null) {
                    obj.MaterialOverlay = (Godot.Material)MaterialOverlay.Generate(Godot.GD.Load<Godot.Material>(((IResourceTag)MaterialOverlay).ResourcePath));
                } else {
                    obj.MaterialOverlay = (Godot.Material)MaterialOverlay.Generate();
                }
            }

            return obj;
        }
    }
}

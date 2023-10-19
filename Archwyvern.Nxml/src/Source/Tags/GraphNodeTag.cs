// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "GraphNode", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class GraphNodeTag : Archwyvern.Nxml.Tag
    {
#nullable enable
        // Simple Fields
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Title")] public string _Surrogate_Title {
            get => Title != null ? ((System.String)Title).ToString() : "";
            set => Title = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? Title;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShowClose")] public string _Surrogate_ShowClose {
            get => ShowClose != null ? ((System.Boolean)ShowClose).ToString() : "";
            set => ShowClose = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ShowClose;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Resizable")] public string _Surrogate_Resizable {
            get => Resizable != null ? ((System.Boolean)Resizable).ToString() : "";
            set => Resizable = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Resizable;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Draggable")] public string _Surrogate_Draggable {
            get => Draggable != null ? ((System.Boolean)Draggable).ToString() : "";
            set => Draggable = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Draggable;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Selectable")] public string _Surrogate_Selectable {
            get => Selectable != null ? ((System.Boolean)Selectable).ToString() : "";
            set => Selectable = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Selectable;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Selected")] public string _Surrogate_Selected {
            get => Selected != null ? ((System.Boolean)Selected).ToString() : "";
            set => Selected = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Selected;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Comment")] public string _Surrogate_Comment {
            get => Comment != null ? ((System.Boolean)Comment).ToString() : "";
            set => Comment = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Comment;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Overlay")] public string _Surrogate_Overlay {
            get => Overlay != null ? ((Godot.GraphNode.OverlayEnum)Overlay).ToString() : "";
            set => Overlay = value != "" ? System.Enum.Parse<Godot.GraphNode.OverlayEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.GraphNode.OverlayEnum? Overlay;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextDirection")] public string _Surrogate_TextDirection {
            get => TextDirection != null ? ((Godot.Control.TextDirection)TextDirection).ToString() : "";
            set => TextDirection = value != "" ? System.Enum.Parse<Godot.Control.TextDirection>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.TextDirection? TextDirection;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Language")] public string _Surrogate_Language {
            get => Language != null ? ((System.String)Language).ToString() : "";
            set => Language = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? Language;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ClipContents")] public string _Surrogate_ClipContents {
            get => ClipContents != null ? ((System.Boolean)ClipContents).ToString() : "";
            set => ClipContents = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ClipContents;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LayoutDirection")] public string _Surrogate_LayoutDirection {
            get => LayoutDirection != null ? ((Godot.Control.LayoutDirectionEnum)LayoutDirection).ToString() : "";
            set => LayoutDirection = value != "" ? System.Enum.Parse<Godot.Control.LayoutDirectionEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.LayoutDirectionEnum? LayoutDirection;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LayoutMode")] public string _Surrogate_LayoutMode {
            get => LayoutMode != null ? ((System.Int32)LayoutMode).ToString() : "";
            set => LayoutMode = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? LayoutMode;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AnchorsPreset")] public string _Surrogate_AnchorsPreset {
            get => AnchorsPreset != null ? ((System.Int32)AnchorsPreset).ToString() : "";
            set => AnchorsPreset = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? AnchorsPreset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AnchorLeft")] public string _Surrogate_AnchorLeft {
            get => AnchorLeft != null ? ((System.Single)AnchorLeft).ToString() : "";
            set => AnchorLeft = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AnchorLeft;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AnchorTop")] public string _Surrogate_AnchorTop {
            get => AnchorTop != null ? ((System.Single)AnchorTop).ToString() : "";
            set => AnchorTop = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AnchorTop;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AnchorRight")] public string _Surrogate_AnchorRight {
            get => AnchorRight != null ? ((System.Single)AnchorRight).ToString() : "";
            set => AnchorRight = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AnchorRight;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AnchorBottom")] public string _Surrogate_AnchorBottom {
            get => AnchorBottom != null ? ((System.Single)AnchorBottom).ToString() : "";
            set => AnchorBottom = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? AnchorBottom;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OffsetLeft")] public string _Surrogate_OffsetLeft {
            get => OffsetLeft != null ? ((System.Single)OffsetLeft).ToString() : "";
            set => OffsetLeft = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? OffsetLeft;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OffsetTop")] public string _Surrogate_OffsetTop {
            get => OffsetTop != null ? ((System.Single)OffsetTop).ToString() : "";
            set => OffsetTop = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? OffsetTop;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OffsetRight")] public string _Surrogate_OffsetRight {
            get => OffsetRight != null ? ((System.Single)OffsetRight).ToString() : "";
            set => OffsetRight = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? OffsetRight;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "OffsetBottom")] public string _Surrogate_OffsetBottom {
            get => OffsetBottom != null ? ((System.Single)OffsetBottom).ToString() : "";
            set => OffsetBottom = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? OffsetBottom;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GrowHorizontal")] public string _Surrogate_GrowHorizontal {
            get => GrowHorizontal != null ? ((Godot.Control.GrowDirection)GrowHorizontal).ToString() : "";
            set => GrowHorizontal = value != "" ? System.Enum.Parse<Godot.Control.GrowDirection>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.GrowDirection? GrowHorizontal;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GrowVertical")] public string _Surrogate_GrowVertical {
            get => GrowVertical != null ? ((Godot.Control.GrowDirection)GrowVertical).ToString() : "";
            set => GrowVertical = value != "" ? System.Enum.Parse<Godot.Control.GrowDirection>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.GrowDirection? GrowVertical;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rotation")] public string _Surrogate_Rotation {
            get => Rotation != null ? ((System.Single)Rotation).ToString() : "";
            set => Rotation = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Rotation;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RotationDegrees")] public string _Surrogate_RotationDegrees {
            get => RotationDegrees != null ? ((System.Single)RotationDegrees).ToString() : "";
            set => RotationDegrees = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? RotationDegrees;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SizeFlagsHorizontal")] public string _Surrogate_SizeFlagsHorizontal {
            get => SizeFlagsHorizontal != null ? ((Godot.Control.SizeFlags)SizeFlagsHorizontal).ToString() : "";
            set => SizeFlagsHorizontal = value != "" ? System.Enum.Parse<Godot.Control.SizeFlags>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.SizeFlags? SizeFlagsHorizontal;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SizeFlagsVertical")] public string _Surrogate_SizeFlagsVertical {
            get => SizeFlagsVertical != null ? ((Godot.Control.SizeFlags)SizeFlagsVertical).ToString() : "";
            set => SizeFlagsVertical = value != "" ? System.Enum.Parse<Godot.Control.SizeFlags>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.SizeFlags? SizeFlagsVertical;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SizeFlagsStretchRatio")] public string _Surrogate_SizeFlagsStretchRatio {
            get => SizeFlagsStretchRatio != null ? ((System.Single)SizeFlagsStretchRatio).ToString() : "";
            set => SizeFlagsStretchRatio = value != "" ? System.Single.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? SizeFlagsStretchRatio;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AutoTranslate")] public string _Surrogate_AutoTranslate {
            get => AutoTranslate != null ? ((System.Boolean)AutoTranslate).ToString() : "";
            set => AutoTranslate = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? AutoTranslate;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LocalizeNumeralSystem")] public string _Surrogate_LocalizeNumeralSystem {
            get => LocalizeNumeralSystem != null ? ((System.Boolean)LocalizeNumeralSystem).ToString() : "";
            set => LocalizeNumeralSystem = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? LocalizeNumeralSystem;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TooltipText")] public string _Surrogate_TooltipText {
            get => TooltipText != null ? ((System.String)TooltipText).ToString() : "";
            set => TooltipText = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? TooltipText;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FocusMode")] public string _Surrogate_FocusMode {
            get => FocusMode != null ? ((Godot.Control.FocusModeEnum)FocusMode).ToString() : "";
            set => FocusMode = value != "" ? System.Enum.Parse<Godot.Control.FocusModeEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.FocusModeEnum? FocusMode;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MouseFilter")] public string _Surrogate_MouseFilter {
            get => MouseFilter != null ? ((Godot.Control.MouseFilterEnum)MouseFilter).ToString() : "";
            set => MouseFilter = value != "" ? System.Enum.Parse<Godot.Control.MouseFilterEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.MouseFilterEnum? MouseFilter;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MouseForcePassScrollEvents")] public string _Surrogate_MouseForcePassScrollEvents {
            get => MouseForcePassScrollEvents != null ? ((System.Boolean)MouseForcePassScrollEvents).ToString() : "";
            set => MouseForcePassScrollEvents = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? MouseForcePassScrollEvents;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "MouseDefaultCursorShape")] public string _Surrogate_MouseDefaultCursorShape {
            get => MouseDefaultCursorShape != null ? ((Godot.Control.CursorShape)MouseDefaultCursorShape).ToString() : "";
            set => MouseDefaultCursorShape = value != "" ? System.Enum.Parse<Godot.Control.CursorShape>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Control.CursorShape? MouseDefaultCursorShape;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Visible")] public string _Surrogate_Visible {
            get => Visible != null ? ((System.Boolean)Visible).ToString() : "";
            set => Visible = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Visible;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ShowBehindParent")] public string _Surrogate_ShowBehindParent {
            get => ShowBehindParent != null ? ((System.Boolean)ShowBehindParent).ToString() : "";
            set => ShowBehindParent = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ShowBehindParent;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TopLevel")] public string _Surrogate_TopLevel {
            get => TopLevel != null ? ((System.Boolean)TopLevel).ToString() : "";
            set => TopLevel = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? TopLevel;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ClipChildren")] public string _Surrogate_ClipChildren {
            get => ClipChildren != null ? ((Godot.CanvasItem.ClipChildrenMode)ClipChildren).ToString() : "";
            set => ClipChildren = value != "" ? System.Enum.Parse<Godot.CanvasItem.ClipChildrenMode>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.ClipChildrenMode? ClipChildren;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LightMask")] public string _Surrogate_LightMask {
            get => LightMask != null ? ((System.Int32)LightMask).ToString() : "";
            set => LightMask = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? LightMask;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "VisibilityLayer")] public string _Surrogate_VisibilityLayer {
            get => VisibilityLayer != null ? ((System.UInt32)VisibilityLayer).ToString() : "";
            set => VisibilityLayer = value != "" ? System.UInt32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.UInt32? VisibilityLayer;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ZIndex")] public string _Surrogate_ZIndex {
            get => ZIndex != null ? ((System.Int32)ZIndex).ToString() : "";
            set => ZIndex = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ZIndex;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ZAsRelative")] public string _Surrogate_ZAsRelative {
            get => ZAsRelative != null ? ((System.Boolean)ZAsRelative).ToString() : "";
            set => ZAsRelative = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ZAsRelative;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "YSortEnabled")] public string _Surrogate_YSortEnabled {
            get => YSortEnabled != null ? ((System.Boolean)YSortEnabled).ToString() : "";
            set => YSortEnabled = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? YSortEnabled;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextureFilter")] public string _Surrogate_TextureFilter {
            get => TextureFilter != null ? ((Godot.CanvasItem.TextureFilterEnum)TextureFilter).ToString() : "";
            set => TextureFilter = value != "" ? System.Enum.Parse<Godot.CanvasItem.TextureFilterEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.TextureFilterEnum? TextureFilter;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "TextureRepeat")] public string _Surrogate_TextureRepeat {
            get => TextureRepeat != null ? ((Godot.CanvasItem.TextureRepeatEnum)TextureRepeat).ToString() : "";
            set => TextureRepeat = value != "" ? System.Enum.Parse<Godot.CanvasItem.TextureRepeatEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItem.TextureRepeatEnum? TextureRepeat;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UseParentMaterial")] public string _Surrogate_UseParentMaterial {
            get => UseParentMaterial != null ? ((System.Boolean)UseParentMaterial).ToString() : "";
            set => UseParentMaterial = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UseParentMaterial;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UniqueNameInOwner")] public string _Surrogate_UniqueNameInOwner {
            get => UniqueNameInOwner != null ? ((System.Boolean)UniqueNameInOwner).ToString() : "";
            set => UniqueNameInOwner = value != "" ? System.Boolean.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? UniqueNameInOwner;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "SceneFilePath")] public string _Surrogate_SceneFilePath {
            get => SceneFilePath != null ? ((System.String)SceneFilePath).ToString() : "";
            set => SceneFilePath = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? SceneFilePath;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessMode")] public string _Surrogate_ProcessMode {
            get => ProcessMode != null ? ((Godot.Node.ProcessModeEnum)ProcessMode).ToString() : "";
            set => ProcessMode = value != "" ? System.Enum.Parse<Godot.Node.ProcessModeEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessModeEnum? ProcessMode;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPriority")] public string _Surrogate_ProcessPriority {
            get => ProcessPriority != null ? ((System.Int32)ProcessPriority).ToString() : "";
            set => ProcessPriority = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPriority;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessPhysicsPriority")] public string _Surrogate_ProcessPhysicsPriority {
            get => ProcessPhysicsPriority != null ? ((System.Int32)ProcessPhysicsPriority).ToString() : "";
            set => ProcessPhysicsPriority = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessPhysicsPriority;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroup")] public string _Surrogate_ProcessThreadGroup {
            get => ProcessThreadGroup != null ? ((Godot.Node.ProcessThreadGroupEnum)ProcessThreadGroup).ToString() : "";
            set => ProcessThreadGroup = value != "" ? System.Enum.Parse<Godot.Node.ProcessThreadGroupEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadGroupEnum? ProcessThreadGroup;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadGroupOrder")] public string _Surrogate_ProcessThreadGroupOrder {
            get => ProcessThreadGroupOrder != null ? ((System.Int32)ProcessThreadGroupOrder).ToString() : "";
            set => ProcessThreadGroupOrder = value != "" ? System.Int32.Parse(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ProcessThreadGroupOrder;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ProcessThreadMessages")] public string _Surrogate_ProcessThreadMessages {
            get => ProcessThreadMessages != null ? ((Godot.Node.ProcessThreadMessagesEnum)ProcessThreadMessages).ToString() : "";
            set => ProcessThreadMessages = value != "" ? System.Enum.Parse<Godot.Node.ProcessThreadMessagesEnum>(value) : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.Node.ProcessThreadMessagesEnum? ProcessThreadMessages;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EditorDescription")] public string _Surrogate_EditorDescription {
            get => EditorDescription != null ? ((System.String)EditorDescription).ToString() : "";
            set => EditorDescription = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? EditorDescription;
#nullable disable

        // Overloaded Fields
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PositionOffset")] public string _Surrogate_PositionOffset {
            get => PositionOffset != null ? ((Archwyvern.Nxml.Translators.Vector2)PositionOffset).ToString() : "";
            set => PositionOffset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? PositionOffset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "CustomMinimumSize")] public string _Surrogate_CustomMinimumSize {
            get => CustomMinimumSize != null ? ((Archwyvern.Nxml.Translators.Vector2)CustomMinimumSize).ToString() : "";
            set => CustomMinimumSize = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? CustomMinimumSize;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Size")] public string _Surrogate_Size {
            get => Size != null ? ((Archwyvern.Nxml.Translators.Vector2)Size).ToString() : "";
            set => Size = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Size;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Position")] public string _Surrogate_Position {
            get => Position != null ? ((Archwyvern.Nxml.Translators.Vector2)Position).ToString() : "";
            set => Position = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Position;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "GlobalPosition")] public string _Surrogate_GlobalPosition {
            get => GlobalPosition != null ? ((Archwyvern.Nxml.Translators.Vector2)GlobalPosition).ToString() : "";
            set => GlobalPosition = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? GlobalPosition;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Scale")] public string _Surrogate_Scale {
            get => Scale != null ? ((Archwyvern.Nxml.Translators.Vector2)Scale).ToString() : "";
            set => Scale = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? Scale;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "PivotOffset")] public string _Surrogate_PivotOffset {
            get => PivotOffset != null ? ((Archwyvern.Nxml.Translators.Vector2)PivotOffset).ToString() : "";
            set => PivotOffset = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? PivotOffset;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ThemeTypeVariation")] public string _Surrogate_ThemeTypeVariation {
            get => ThemeTypeVariation != null ? ((Archwyvern.Nxml.Translators.StringName)ThemeTypeVariation).ToString() : "";
            set => ThemeTypeVariation = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.StringName? ThemeTypeVariation;
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

        public override Godot.Node CreateNode()
        {
            var obj = new Godot.GraphNode();

            if (Title != null) obj.Title = (System.String)Title;
            if (ShowClose != null) obj.ShowClose = (System.Boolean)ShowClose;
            if (Resizable != null) obj.Resizable = (System.Boolean)Resizable;
            if (Draggable != null) obj.Draggable = (System.Boolean)Draggable;
            if (Selectable != null) obj.Selectable = (System.Boolean)Selectable;
            if (Selected != null) obj.Selected = (System.Boolean)Selected;
            if (Comment != null) obj.Comment = (System.Boolean)Comment;
            if (Overlay != null) obj.Overlay = (Godot.GraphNode.OverlayEnum)Overlay;
            if (TextDirection != null) obj.TextDirection = (Godot.Control.TextDirection)TextDirection;
            if (Language != null) obj.Language = (System.String)Language;
            if (ClipContents != null) obj.ClipContents = (System.Boolean)ClipContents;
            if (LayoutDirection != null) obj.LayoutDirection = (Godot.Control.LayoutDirectionEnum)LayoutDirection;
            if (LayoutMode != null) obj.LayoutMode = (System.Int32)LayoutMode;
            if (AnchorsPreset != null) obj.AnchorsPreset = (System.Int32)AnchorsPreset;
            if (AnchorLeft != null) obj.AnchorLeft = (System.Single)AnchorLeft;
            if (AnchorTop != null) obj.AnchorTop = (System.Single)AnchorTop;
            if (AnchorRight != null) obj.AnchorRight = (System.Single)AnchorRight;
            if (AnchorBottom != null) obj.AnchorBottom = (System.Single)AnchorBottom;
            if (OffsetLeft != null) obj.OffsetLeft = (System.Single)OffsetLeft;
            if (OffsetTop != null) obj.OffsetTop = (System.Single)OffsetTop;
            if (OffsetRight != null) obj.OffsetRight = (System.Single)OffsetRight;
            if (OffsetBottom != null) obj.OffsetBottom = (System.Single)OffsetBottom;
            if (GrowHorizontal != null) obj.GrowHorizontal = (Godot.Control.GrowDirection)GrowHorizontal;
            if (GrowVertical != null) obj.GrowVertical = (Godot.Control.GrowDirection)GrowVertical;
            if (Rotation != null) obj.Rotation = (System.Single)Rotation;
            if (RotationDegrees != null) obj.RotationDegrees = (System.Single)RotationDegrees;
            if (SizeFlagsHorizontal != null) obj.SizeFlagsHorizontal = (Godot.Control.SizeFlags)SizeFlagsHorizontal;
            if (SizeFlagsVertical != null) obj.SizeFlagsVertical = (Godot.Control.SizeFlags)SizeFlagsVertical;
            if (SizeFlagsStretchRatio != null) obj.SizeFlagsStretchRatio = (System.Single)SizeFlagsStretchRatio;
            if (AutoTranslate != null) obj.AutoTranslate = (System.Boolean)AutoTranslate;
            if (LocalizeNumeralSystem != null) obj.LocalizeNumeralSystem = (System.Boolean)LocalizeNumeralSystem;
            if (TooltipText != null) obj.TooltipText = (System.String)TooltipText;
            if (FocusMode != null) obj.FocusMode = (Godot.Control.FocusModeEnum)FocusMode;
            if (MouseFilter != null) obj.MouseFilter = (Godot.Control.MouseFilterEnum)MouseFilter;
            if (MouseForcePassScrollEvents != null) obj.MouseForcePassScrollEvents = (System.Boolean)MouseForcePassScrollEvents;
            if (MouseDefaultCursorShape != null) obj.MouseDefaultCursorShape = (Godot.Control.CursorShape)MouseDefaultCursorShape;
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
            if (PositionOffset != null) obj.PositionOffset = (Archwyvern.Nxml.Translators.Vector2)PositionOffset;
            if (CustomMinimumSize != null) obj.CustomMinimumSize = (Archwyvern.Nxml.Translators.Vector2)CustomMinimumSize;
            if (Size != null) obj.Size = (Archwyvern.Nxml.Translators.Vector2)Size;
            if (Position != null) obj.Position = (Archwyvern.Nxml.Translators.Vector2)Position;
            if (GlobalPosition != null) obj.GlobalPosition = (Archwyvern.Nxml.Translators.Vector2)GlobalPosition;
            if (Scale != null) obj.Scale = (Archwyvern.Nxml.Translators.Vector2)Scale;
            if (PivotOffset != null) obj.PivotOffset = (Archwyvern.Nxml.Translators.Vector2)PivotOffset;
            if (ThemeTypeVariation != null) obj.ThemeTypeVariation = (Archwyvern.Nxml.Translators.StringName)ThemeTypeVariation;
            if (Modulate != null) obj.Modulate = (Archwyvern.Nxml.Translators.Color)Modulate;
            if (SelfModulate != null) obj.SelfModulate = (Archwyvern.Nxml.Translators.Color)SelfModulate;
            if (Name != null) obj.Name = (Archwyvern.Nxml.Translators.StringName)Name;

            return obj;
        }
    }
}

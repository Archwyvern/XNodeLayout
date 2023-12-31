// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CanvasItemMaterial", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class CanvasItemMaterialTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "CanvasItemMaterial.ElementProperty.NextPass")] public class NextPass
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

        [System.Xml.Serialization.XmlIgnore] public BaseTag? NextPass => _Surrogate_Element_NextPass?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.NextPass")] public CanvasItemMaterialTag.ElementProperty.NextPass? _Surrogate_Element_NextPass;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "BlendMode")] public string _Surrogate_Attribute_BlendMode {
            get => BlendMode != null ? ((Godot.CanvasItemMaterial.BlendModeEnum)BlendMode).ToString() : "";
            set { if (value != "") { BlendMode = System.Enum.Parse<Godot.CanvasItemMaterial.BlendModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.BlendMode")] public string _Surrogate_Element_BlendMode {
            get => BlendMode != null ? ((Godot.CanvasItemMaterial.BlendModeEnum)BlendMode).ToString() : "";
            set { if (value != "") { BlendMode = System.Enum.Parse<Godot.CanvasItemMaterial.BlendModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItemMaterial.BlendModeEnum? BlendMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LightMode")] public string _Surrogate_Attribute_LightMode {
            get => LightMode != null ? ((Godot.CanvasItemMaterial.LightModeEnum)LightMode).ToString() : "";
            set { if (value != "") { LightMode = System.Enum.Parse<Godot.CanvasItemMaterial.LightModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.LightMode")] public string _Surrogate_Element_LightMode {
            get => LightMode != null ? ((Godot.CanvasItemMaterial.LightModeEnum)LightMode).ToString() : "";
            set { if (value != "") { LightMode = System.Enum.Parse<Godot.CanvasItemMaterial.LightModeEnum>(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public Godot.CanvasItemMaterial.LightModeEnum? LightMode { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ParticlesAnimation")] public string _Surrogate_Attribute_ParticlesAnimation {
            get => ParticlesAnimation != null ? ((System.Boolean)ParticlesAnimation).ToString() : "";
            set { if (value != "") { ParticlesAnimation = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ParticlesAnimation")] public string _Surrogate_Element_ParticlesAnimation {
            get => ParticlesAnimation != null ? ((System.Boolean)ParticlesAnimation).ToString() : "";
            set { if (value != "") { ParticlesAnimation = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ParticlesAnimation { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ParticlesAnimHFrames")] public string _Surrogate_Attribute_ParticlesAnimHFrames {
            get => ParticlesAnimHFrames != null ? ((System.Int32)ParticlesAnimHFrames).ToString() : "";
            set { if (value != "") { ParticlesAnimHFrames = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ParticlesAnimHFrames")] public string _Surrogate_Element_ParticlesAnimHFrames {
            get => ParticlesAnimHFrames != null ? ((System.Int32)ParticlesAnimHFrames).ToString() : "";
            set { if (value != "") { ParticlesAnimHFrames = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ParticlesAnimHFrames { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ParticlesAnimVFrames")] public string _Surrogate_Attribute_ParticlesAnimVFrames {
            get => ParticlesAnimVFrames != null ? ((System.Int32)ParticlesAnimVFrames).ToString() : "";
            set { if (value != "") { ParticlesAnimVFrames = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ParticlesAnimVFrames")] public string _Surrogate_Element_ParticlesAnimVFrames {
            get => ParticlesAnimVFrames != null ? ((System.Int32)ParticlesAnimVFrames).ToString() : "";
            set { if (value != "") { ParticlesAnimVFrames = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? ParticlesAnimVFrames { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ParticlesAnimLoop")] public string _Surrogate_Attribute_ParticlesAnimLoop {
            get => ParticlesAnimLoop != null ? ((System.Boolean)ParticlesAnimLoop).ToString() : "";
            set { if (value != "") { ParticlesAnimLoop = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ParticlesAnimLoop")] public string _Surrogate_Element_ParticlesAnimLoop {
            get => ParticlesAnimLoop != null ? ((System.Boolean)ParticlesAnimLoop).ToString() : "";
            set { if (value != "") { ParticlesAnimLoop = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ParticlesAnimLoop { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RenderPriority")] public string _Surrogate_Attribute_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.RenderPriority")] public string _Surrogate_Element_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? RenderPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CanvasItemMaterial.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.CanvasItemMaterial) return alt;
            var obj = (Godot.CanvasItemMaterial)alt ?? new Godot.CanvasItemMaterial();

            // Attributes
            if (BlendMode != null) obj.BlendMode = (Godot.CanvasItemMaterial.BlendModeEnum)BlendMode;
            if (LightMode != null) obj.LightMode = (Godot.CanvasItemMaterial.LightModeEnum)LightMode;
            if (ParticlesAnimation != null) obj.ParticlesAnimation = (System.Boolean)ParticlesAnimation;
            if (ParticlesAnimHFrames != null) obj.ParticlesAnimHFrames = (System.Int32)ParticlesAnimHFrames;
            if (ParticlesAnimVFrames != null) obj.ParticlesAnimVFrames = (System.Int32)ParticlesAnimVFrames;
            if (ParticlesAnimLoop != null) obj.ParticlesAnimLoop = (System.Boolean)ParticlesAnimLoop;
            if (RenderPriority != null) obj.RenderPriority = (System.Int32)RenderPriority;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements
            if (NextPass != null) {
                if (((IResourceTag)NextPass).ResourcePath != null) {
                    obj.NextPass = (Godot.Material)NextPass.Generate(Godot.GD.Load<Godot.Material>(((IResourceTag)NextPass).ResourcePath));
                } else {
                    obj.NextPass = (Godot.Material)NextPass.Generate();
                }
            }

            return obj;
        }
    }
}

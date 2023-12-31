// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "PanoramaSkyMaterial", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class PanoramaSkyMaterialTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "PanoramaSkyMaterial.ElementProperty.Panorama")] public class Panorama
            {
                [System.Xml.Serialization.XmlElement(ElementName = "AnimatedTexture", Type = typeof(AnimatedTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "AtlasTexture", Type = typeof(AtlasTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CameraTexture", Type = typeof(CameraTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CanvasTexture", Type = typeof(CanvasTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CompressedTexture2D", Type = typeof(CompressedTexture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CurveTexture", Type = typeof(CurveTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "CurveXyzTexture", Type = typeof(CurveXyzTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture1D", Type = typeof(GradientTexture1DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "GradientTexture2D", Type = typeof(GradientTexture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ImageTexture", Type = typeof(ImageTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "MeshTexture", Type = typeof(MeshTextureTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture2D", Type = typeof(NoiseTexture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PlaceholderTexture2D", Type = typeof(PlaceholderTexture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PortableCompressedTexture2D", Type = typeof(PortableCompressedTexture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "Texture2D", Type = typeof(Texture2DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ViewportTexture", Type = typeof(ViewportTextureTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "PanoramaSkyMaterial.ElementProperty.NextPass")] public class NextPass
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

        [System.Xml.Serialization.XmlIgnore] public BaseTag? Panorama => _Surrogate_Element_Panorama?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.Panorama")] public PanoramaSkyMaterialTag.ElementProperty.Panorama? _Surrogate_Element_Panorama;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? NextPass => _Surrogate_Element_NextPass?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.NextPass")] public PanoramaSkyMaterialTag.ElementProperty.NextPass? _Surrogate_Element_NextPass;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Filter")] public string _Surrogate_Attribute_Filter {
            get => Filter != null ? ((System.Boolean)Filter).ToString() : "";
            set { if (value != "") { Filter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.Filter")] public string _Surrogate_Element_Filter {
            get => Filter != null ? ((System.Boolean)Filter).ToString() : "";
            set { if (value != "") { Filter = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? Filter { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RenderPriority")] public string _Surrogate_Attribute_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.RenderPriority")] public string _Surrogate_Element_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? RenderPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "PanoramaSkyMaterial.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.PanoramaSkyMaterial) return alt;
            var obj = (Godot.PanoramaSkyMaterial)alt ?? new Godot.PanoramaSkyMaterial();

            // Attributes
            if (Filter != null) obj.Filter = (System.Boolean)Filter;
            if (RenderPriority != null) obj.RenderPriority = (System.Int32)RenderPriority;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            // Elements
            if (Panorama != null) {
                if (((IResourceTag)Panorama).ResourcePath != null) {
                    obj.Panorama = (Godot.Texture2D)Panorama.Generate(Godot.GD.Load<Godot.Texture2D>(((IResourceTag)Panorama).ResourcePath));
                } else {
                    obj.Panorama = (Godot.Texture2D)Panorama.Generate();
                }
            }
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

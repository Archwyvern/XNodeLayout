// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "FogMaterial", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class FogMaterialTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "FogMaterial.ElementProperty.DensityTexture")] public class DensityTexture
            {
                [System.Xml.Serialization.XmlElement(ElementName = "CompressedTexture3D", Type = typeof(CompressedTexture3DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "ImageTexture3D", Type = typeof(ImageTexture3DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "NoiseTexture3D", Type = typeof(NoiseTexture3DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "PlaceholderTexture3D", Type = typeof(PlaceholderTexture3DTag))]
                [System.Xml.Serialization.XmlElement(ElementName = "Texture3D", Type = typeof(Texture3DTag))]
                public Archwyvern.Nxml.BaseTag? Value;
            }

            [System.Xml.Serialization.XmlType(TypeName = "FogMaterial.ElementProperty.NextPass")] public class NextPass
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

        [System.Xml.Serialization.XmlIgnore] public BaseTag? DensityTexture => _Surrogate_Element_DensityTexture?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.DensityTexture")] public FogMaterialTag.ElementProperty.DensityTexture? _Surrogate_Element_DensityTexture;

        [System.Xml.Serialization.XmlIgnore] public BaseTag? NextPass => _Surrogate_Element_NextPass?.Value;
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.NextPass")] public FogMaterialTag.ElementProperty.NextPass? _Surrogate_Element_NextPass;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Density")] public string _Surrogate_Attribute_Density {
            get => Density != null ? ((System.Single)Density).ToString() : "";
            set { if (value != "") { Density = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.Density")] public string _Surrogate_Element_Density {
            get => Density != null ? ((System.Single)Density).ToString() : "";
            set { if (value != "") { Density = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Density { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "HeightFalloff")] public string _Surrogate_Attribute_HeightFalloff {
            get => HeightFalloff != null ? ((System.Single)HeightFalloff).ToString() : "";
            set { if (value != "") { HeightFalloff = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.HeightFalloff")] public string _Surrogate_Element_HeightFalloff {
            get => HeightFalloff != null ? ((System.Single)HeightFalloff).ToString() : "";
            set { if (value != "") { HeightFalloff = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? HeightFalloff { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "EdgeFade")] public string _Surrogate_Attribute_EdgeFade {
            get => EdgeFade != null ? ((System.Single)EdgeFade).ToString() : "";
            set { if (value != "") { EdgeFade = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.EdgeFade")] public string _Surrogate_Element_EdgeFade {
            get => EdgeFade != null ? ((System.Single)EdgeFade).ToString() : "";
            set { if (value != "") { EdgeFade = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? EdgeFade { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RenderPriority")] public string _Surrogate_Attribute_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.RenderPriority")] public string _Surrogate_Element_RenderPriority {
            get => RenderPriority != null ? ((System.Int32)RenderPriority).ToString() : "";
            set { if (value != "") { RenderPriority = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? RenderPriority { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "FogMaterial.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Albedo")] public string _Surrogate_Albedo {
            get => Albedo != null ? ((Archwyvern.Nxml.Translators.Color)Albedo).ToString() : "";
            set => Albedo = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? Albedo;
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Emission")] public string _Surrogate_Emission {
            get => Emission != null ? ((Archwyvern.Nxml.Translators.Color)Emission).ToString() : "";
            set => Emission = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Color? Emission;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.FogMaterial) return alt;
            var obj = (Godot.FogMaterial)alt ?? new Godot.FogMaterial();

            // Attributes
            if (Density != null) obj.Density = (System.Single)Density;
            if (HeightFalloff != null) obj.HeightFalloff = (System.Single)HeightFalloff;
            if (EdgeFade != null) obj.EdgeFade = (System.Single)EdgeFade;
            if (RenderPriority != null) obj.RenderPriority = (System.Int32)RenderPriority;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (Albedo != null) obj.Albedo = (Archwyvern.Nxml.Translators.Color)Albedo;
            if (Emission != null) obj.Emission = (Archwyvern.Nxml.Translators.Color)Emission;
            // Elements
            if (DensityTexture != null) {
                if (((IResourceTag)DensityTexture).ResourcePath != null) {
                    obj.DensityTexture = (Godot.Texture3D)DensityTexture.Generate(Godot.GD.Load<Godot.Texture3D>(((IResourceTag)DensityTexture).ResourcePath));
                } else {
                    obj.DensityTexture = (Godot.Texture3D)DensityTexture.Generate();
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
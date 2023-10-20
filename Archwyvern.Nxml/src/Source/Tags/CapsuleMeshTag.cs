// <auto-generated />
namespace Archwyvern.Nxml.Tags
{
    [System.Xml.Serialization.XmlRoot(ElementName = "CapsuleMesh", Namespace = "http://archwyvern.com/xsd/nxml")]
    public class CapsuleMeshTag : Archwyvern.Nxml.BaseTag, Archwyvern.Nxml.IResourceTag
    {
#nullable enable
        public static class ElementProperty
        {
            [System.Xml.Serialization.XmlType(TypeName = "CapsuleMesh.ElementProperty.Material")] public class Material
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
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.Material")] public CapsuleMeshTag.ElementProperty.Material? _Surrogate_Element_Material;

        // Simple Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Radius")] public string _Surrogate_Attribute_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.Radius")] public string _Surrogate_Element_Radius {
            get => Radius != null ? ((System.Single)Radius).ToString() : "";
            set { if (value != "") { Radius = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Radius { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Height")] public string _Surrogate_Attribute_Height {
            get => Height != null ? ((System.Single)Height).ToString() : "";
            set { if (value != "") { Height = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.Height")] public string _Surrogate_Element_Height {
            get => Height != null ? ((System.Single)Height).ToString() : "";
            set { if (value != "") { Height = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? Height { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "RadialSegments")] public string _Surrogate_Attribute_RadialSegments {
            get => RadialSegments != null ? ((System.Int32)RadialSegments).ToString() : "";
            set { if (value != "") { RadialSegments = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.RadialSegments")] public string _Surrogate_Element_RadialSegments {
            get => RadialSegments != null ? ((System.Int32)RadialSegments).ToString() : "";
            set { if (value != "") { RadialSegments = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? RadialSegments { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "Rings")] public string _Surrogate_Attribute_Rings {
            get => Rings != null ? ((System.Int32)Rings).ToString() : "";
            set { if (value != "") { Rings = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.Rings")] public string _Surrogate_Element_Rings {
            get => Rings != null ? ((System.Int32)Rings).ToString() : "";
            set { if (value != "") { Rings = System.Int32.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Int32? Rings { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "FlipFaces")] public string _Surrogate_Attribute_FlipFaces {
            get => FlipFaces != null ? ((System.Boolean)FlipFaces).ToString() : "";
            set { if (value != "") { FlipFaces = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.FlipFaces")] public string _Surrogate_Element_FlipFaces {
            get => FlipFaces != null ? ((System.Boolean)FlipFaces).ToString() : "";
            set { if (value != "") { FlipFaces = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? FlipFaces { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "AddUV2")] public string _Surrogate_Attribute_AddUV2 {
            get => AddUV2 != null ? ((System.Boolean)AddUV2).ToString() : "";
            set { if (value != "") { AddUV2 = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.AddUV2")] public string _Surrogate_Element_AddUV2 {
            get => AddUV2 != null ? ((System.Boolean)AddUV2).ToString() : "";
            set { if (value != "") { AddUV2 = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? AddUV2 { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "UV2Padding")] public string _Surrogate_Attribute_UV2Padding {
            get => UV2Padding != null ? ((System.Single)UV2Padding).ToString() : "";
            set { if (value != "") { UV2Padding = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.UV2Padding")] public string _Surrogate_Element_UV2Padding {
            get => UV2Padding != null ? ((System.Single)UV2Padding).ToString() : "";
            set { if (value != "") { UV2Padding = System.Single.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Single? UV2Padding { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceLocalToScene")] public string _Surrogate_Attribute_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.ResourceLocalToScene")] public string _Surrogate_Element_ResourceLocalToScene {
            get => ResourceLocalToScene != null ? ((System.Boolean)ResourceLocalToScene).ToString() : "";
            set { if (value != "") { ResourceLocalToScene = System.Boolean.Parse(value); } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.Boolean? ResourceLocalToScene { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourcePath")] public string _Surrogate_Attribute_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.ResourcePath")] public string _Surrogate_Element_ResourcePath {
            get => ResourcePath != null ? ((System.String)ResourcePath).ToString() : "";
            set { if (value != "") { ResourcePath = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourcePath { get; set; }
        [System.Xml.Serialization.XmlAttribute(AttributeName = "ResourceName")] public string _Surrogate_Attribute_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlElement(ElementName = "CapsuleMesh.ResourceName")] public string _Surrogate_Element_ResourceName {
            get => ResourceName != null ? ((System.String)ResourceName).ToString() : "";
            set { if (value != "") { ResourceName = value; } }
        }
        [System.Xml.Serialization.XmlIgnore] public System.String? ResourceName { get; set; }
#nullable disable

        // Overloaded Attributes
        [System.Xml.Serialization.XmlAttribute(AttributeName = "LightmapSizeHint")] public string _Surrogate_LightmapSizeHint {
            get => LightmapSizeHint != null ? ((Archwyvern.Nxml.Translators.Vector2)LightmapSizeHint).ToString() : "";
            set => LightmapSizeHint = value != "" ? value : null;
        }
        [System.Xml.Serialization.XmlIgnore] public Archwyvern.Nxml.Translators.Vector2? LightmapSizeHint;

        internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)
        {
            if (alt != null && alt is not Godot.CapsuleMesh) return alt;
            var obj = (Godot.CapsuleMesh)alt ?? new Godot.CapsuleMesh();

            // Attributes
            if (Radius != null) obj.Radius = (System.Single)Radius;
            if (Height != null) obj.Height = (System.Single)Height;
            if (RadialSegments != null) obj.RadialSegments = (System.Int32)RadialSegments;
            if (Rings != null) obj.Rings = (System.Int32)Rings;
            if (FlipFaces != null) obj.FlipFaces = (System.Boolean)FlipFaces;
            if (AddUV2 != null) obj.AddUV2 = (System.Boolean)AddUV2;
            if (UV2Padding != null) obj.UV2Padding = (System.Single)UV2Padding;
            if (ResourceLocalToScene != null) obj.ResourceLocalToScene = (System.Boolean)ResourceLocalToScene;
            if (ResourcePath != null) obj.ResourcePath = (System.String)ResourcePath;
            if (ResourceName != null) obj.ResourceName = (System.String)ResourceName;
            // Overloaded Attributes
            if (LightmapSizeHint != null) obj.LightmapSizeHint = (Archwyvern.Nxml.Translators.Vector2)LightmapSizeHint;
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
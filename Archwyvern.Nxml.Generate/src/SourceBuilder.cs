using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Archwyvern.Nxml.Generate;

public class SourceBuilder
{
    private const string NS = "http://archwyvern.com/xsd/nxml";

    public static Dictionary<Type, string> CreateTags(IEnumerable<Template> templates)
    {
        var sources = new Dictionary<Type, string>();

        foreach (var template in templates) {
            sources.Add(template.Type, CreateTag(template));
        }

        return sources;
    }

    public static string CreateTag(Template template)
    {
        bool isNodeType = template.Type.IsAssignableTo(typeof(Node));
        string baseType = isNodeType ? "BaseNodeTag" : "BaseTag";
        string typeName = template.Type.Name;
        string interfaceString = template.Type.IsAssignableTo(typeof(Resource)) ? ", Archwyvern.Nxml.IResourceTag" : "";

        var writer = new Writer();

        writer.AppendLine("// <auto-generated />");
        writer.AppendLine($"namespace {template.Namespace}");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine($"[System.Xml.Serialization.XmlRoot(ElementName = \"{typeName}\", Namespace = \"{NS}\")]");
        writer.AppendLine($"public class {template.ClassName} : Archwyvern.Nxml.{baseType}{interfaceString}");
        writer.AppendLine("{").Indent(1);
        writer.AppendLine("#nullable enable", false);

        writer.AppendLine("public static class ElementProperty");
        writer.AppendLine("{").Indent(1);

        foreach (var element in template.Elements.Values) {
            writer.AppendLine($"[System.Xml.Serialization.XmlType(TypeName = \"{typeName}.ElementProperty.{element.Name}\")] public class {element.Name}");
            writer.AppendLine("{").Indent(1);

            foreach (var subT in element.SubTypeTemplates) {
                writer.AppendLine($"[System.Xml.Serialization.XmlElement(ElementName = \"{subT.Type.Name}\", Type = typeof({subT.ClassName}))]");
            }

            writer.AppendLine("public Archwyvern.Nxml.BaseTag? Value;");
            writer.Indent(-1).AppendLine("}");
            writer.AppendLine(null, false);
        }

        writer.Indent(-1).AppendLine("}");

        foreach (var element in template.Elements.Values) {
            writer.AppendLine(null, false);
            writer.AppendLine($"[System.Xml.Serialization.XmlIgnore] public BaseTag? {element.Name} => _Surrogate_Element_{element.Name}?.Value;");
            writer.Append($"[System.Xml.Serialization.XmlElement(ElementName = \"{typeName}.{element.Name}\")] ");
            writer.AppendLine($"public {template.ClassName}.ElementProperty.{element.Name}? _Surrogate_Element_{element.Name};", false);
        }

        writer.AppendLine(null, false);

        writer.AppendLine("// Simple Attributes");
        foreach (var attribute in template.SimpleAttributes.Values) {
            foreach (var area in new[] { "Attribute", "Element" }) {
                var xmlName = area == "Element" ? template.Type.Name + "." + attribute.Name : attribute.Name;

                writer.AppendLine($"[System.Xml.Serialization.Xml{area}({area}Name = \"{xmlName}\")] public string _Surrogate_{area}_{attribute.Name} {{").Indent(1);
                writer.AppendLine($"get => {attribute.Name} != null ? (({attribute.Type.PrintName()}){attribute.Name}).ToString() : \"\";");

                writer.Append($"set {{ if (value != \"\") {{ {attribute.Name} = ");
                if (attribute.Type == typeof(string)) {
                    writer.Append($"value");
                } else if (attribute.Type.IsEnum) {
                    writer.Append($"System.Enum.Parse<{attribute.Type.PrintName()}>(value)");
                } else {
                    writer.Append($"{attribute.Type.PrintName()}.Parse(value)");
                }
                writer.AppendLine("; } }", false);

                writer.Indent(-1).AppendLine("}");
            }
            writer.AppendLine($"[System.Xml.Serialization.XmlIgnore] public {attribute.Type.PrintName()}? {attribute.Name} {{ get; set; }}");
        }
        writer.AppendLine("#nullable disable", false);
        writer.AppendLine(null, false);

        writer.AppendLine("// Overloaded Attributes");

        foreach (var attribute in template.OverloadedAttributes.Values) {
            writer.AppendLine($"[System.Xml.Serialization.XmlAttribute(AttributeName = \"{attribute.Name}\")] public string _Surrogate_{attribute.Name} {{").Indent(1);
            writer.AppendLine($"get => {attribute.Name} != null ? (({attribute.Type}){attribute.Name}).ToString() : \"\";");
            writer.AppendLine($"set => {attribute.Name} = value != \"\" ? value : null;");
            writer.Indent(-1).AppendLine("}");
            writer.AppendLine($"[System.Xml.Serialization.XmlIgnore] public {attribute.Type}? {attribute.Name};");
        }

        writer.AppendLine(null, false);

        writer.AppendLine($"internal override Godot.GodotObject CreateObject(Godot.GodotObject alt = null)");
        writer.AppendLine("{").Indent(1);
        writer.AppendLine($"if (alt != null && alt is not {template.Type.PrintName()}) return alt;");
        writer.AppendLine($"var obj = ({template.Type.PrintName()})alt ?? new {template.Type.PrintName()}();");
        writer.AppendLine(null, false);

        writer.AppendLine("// Attributes");
        foreach (var attribute in template.SimpleAttributes.Values) {
            writer.AppendLine($"if ({attribute.Name} != null) obj.{attribute.Name} = ({attribute.Type.PrintName()}){attribute.Name};");
        }
        writer.AppendLine("// Overloaded Attributes");
        foreach (var attribute in template.OverloadedAttributes.Values) {
            writer.AppendLine($"if ({attribute.Name} != null) obj.{attribute.Name} = ({attribute.Type}){attribute.Name};");
        }
        writer.AppendLine("// Elements");
        foreach (var element in template.Elements.Values) {
            writer.AppendLine($"if ({element.Name} != null) {{").Indent(1);

            if (element.Type.IsAssignableTo(typeof(Resource))) {
                writer.AppendLine($"if (((IResourceTag){element.Name}).ResourcePath != null) {{").Indent(1);
                writer.AppendLine(
                    $"obj.{element.Name} = ({element.Type}){element.Name}.Generate(" +
                        $"Godot.GD.Load<{element.Type.PrintName()}>(((IResourceTag){element.Name}).ResourcePath));");
                writer.Indent(-1).AppendLine("} else {").Indent(1);
                writer.AppendLine($"obj.{element.Name} = ({element.Type}){element.Name}.Generate();");
                writer.Indent(-1).AppendLine("}");
            } else {
                writer.AppendLine($"obj.{element.Name} = ({element.Type}){element.Name}.Generate();");
            }
            writer.Indent(-1).AppendLine("}");
        }

        writer.AppendLine(null, false);
        writer.AppendLine("return obj;");

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");

        return writer.ToString();
    }

    public static string CreateManifest(IEnumerable<Template> templates)
    {
        var writer = new Writer();

        writer.AppendLine("// <auto-generated />");
        writer.AppendLine($"namespace Archwyvern.Nxml");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine($"public class Manifest");
        writer.AppendLine("{").Indent(1);

        writer.Append("public static readonly System.Collections.Immutable.ImmutableDictionary<string, System.Type> Tags = ");
        writer.AppendLine("System.Collections.Immutable.ImmutableDictionary.CreateRange(", false).Indent(1);
        writer.AppendLine("new System.Collections.Generic.Dictionary<string, System.Type>() {").Indent(1);

        foreach (var template in templates) {
            writer.AppendLine($"{{ \"{ template.Type.Name}\", typeof({template.Namespace}.{template.ClassName}) }},");
        }

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine(");");

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");

        return writer.ToString();
    }

    public static string CreateSupportTags(IEnumerable<Template> templates)
    {
        var writer = new Writer();

        // class NodeTag

        writer.AppendLine("// <auto-generated />");
        writer.AppendLine("namespace Archwyvern.Nxml");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine("public abstract partial class BaseNodeTag");
        writer.AppendLine("{").Indent(1);

        foreach (var template in templates.Where(t => t.Type.IsAssignableTo(typeof(Node)))) {
            writer.Append($"[System.Xml.Serialization.XmlElement(ElementName = \"{template.Type.Name}\", ");
            writer.AppendLine($"Type = typeof({template.Namespace}.{template.ClassName}))]", false);
        }

        writer.AppendLine("public System.Collections.Generic.List<Archwyvern.Nxml.BaseNodeTag> Children;");

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");
        writer.AppendLine(null, false);

        // class NodeLayout
        writer.AppendLine("// <auto-generated />");
        writer.AppendLine("namespace Archwyvern.Nxml");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine($"[System.Xml.Serialization.XmlRoot(ElementName = \"NodeLayout\", Namespace = \"{NS}\")]");
        writer.AppendLine("public partial class NodeLayout");
        writer.AppendLine("{").Indent(1);

        foreach (var template in templates.Where(t => t.Type.IsAssignableTo(typeof(Node)))) {
            writer.Append($"[System.Xml.Serialization.XmlElement(ElementName = \"{template.Type.Name}\", ");
            writer.AppendLine($"Type = typeof({template.Namespace}.{template.ClassName}))]", false);
        }

        writer.AppendLine("public Archwyvern.Nxml.BaseNodeTag Tag;");

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");

        return writer.ToString();
    }

    public static string CreateOverrides(IEnumerable<Template> templates)
    {
        var writer = new Writer();

        writer.AppendLine("// <auto-generated />");
        writer.AppendLine("namespace Archwyvern.Nxml");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine("internal class Overrides");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine("public static System.Xml.Serialization.XmlAttributeOverrides Create()");
        writer.AppendLine("{").Indent(1);

        writer.AppendLine("System.Xml.Serialization.XmlAttributeOverrides attributeOverrides = new();");
        writer.AppendLine(null, false);

        var types = new HashSet<Type>();

        foreach (var template in templates) {
            foreach (var type in template.AttributeOverrideTypes) {
                if (types.Contains(type)) {
                    continue;
                }

                types.Add(type);
                var typeName = type.FullName.Replace("+", ".");

                writer.AppendLine("attributeOverrides.Add(").Indent(1);
                writer.AppendLine($"typeof({typeName}),");
                writer.AppendLine("new () {").Indent(1);
                writer.AppendLine($"XmlType = new() {{ TypeName = \"{typeName}\" }}");
                writer.Indent(-1).AppendLine("}");
                writer.Indent(-1).AppendLine(");");
            }
        }

        writer.AppendLine(null, false);
        writer.AppendLine("return attributeOverrides;");

        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");
        writer.Indent(-1).AppendLine("}");

        return writer.ToString();
    }

    private class Writer
    {
        private StringBuilder _stringBuilder = new();
        private int _intent = 0;
        private bool _wasLine = false;

        public Writer Indent(int count)
        {
            _intent += count;

            return this;
        }

        public Writer Append(object obj = null)
        {
            if (_wasLine) {
                _stringBuilder.Append("".PadRight(_intent * 4, ' '));
            }

            _stringBuilder.Append(obj);
            _wasLine = false;

            return this;
        }

        public Writer AppendLine(object obj = null, bool indent = true)
        {
            if (indent) {
                _stringBuilder.Append("".PadRight(_intent * 4, ' '));
                _stringBuilder.AppendLine((string)obj);
            } else {
                _stringBuilder.AppendLine((string)obj);
            }

            _wasLine = true;

            return this;
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}

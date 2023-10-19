using Godot;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Archwyvern.Nxml.Generate;

public class TemplateBuilder
{
    private string _namespace;
    private List<TypeEntry> _entries = new();
    private Dictionary<Type, string> _translators = new();

    private struct TypeEntry
    {
        public Type Type;
        public Type Ancestor;
    }

    public TemplateBuilder(string ns)
    {
        _namespace = ns;
    }

    public void AddType(Type type, Type ancestor = null)
    {
        if (!type.IsClass || type.IsAbstract || type.IsGenericType) {
            throw new Exception("Only add concrete non-generic types");
        }

        _entries.Add(new() { Type = type, Ancestor = ancestor });
    }

    public void AddTranslator(Type type, string translator)
    {
        _translators.Add(type, translator);
    }

    public List<Template> GetTemplates()
    {
        var templates = new List<Template>();

        foreach (TypeEntry entry in _entries) {
            templates.Add(ProcessEntry(entry));
        }

        return templates;
    }

    private Template ProcessEntry(TypeEntry entry, Template inherits = null)
    {
        var template = new Template {
            Namespace = _namespace,
            ClassName = entry.Type.Name + "Tag",
            Type = entry.Type
        };

        ProcessTypeMembers(template, entry);

        return template;
    }

    private void ProcessTypeMembers(Template template, TypeEntry entry)
    {
        foreach (var member in entry.Type.GetMembers()) {
            if (entry.Ancestor.IsSubclassOf(member.DeclaringType)) {
                continue;
            }

            if (member is FieldInfo field && field.IsPublic && !field.IsStatic) {
                ProcessProperty(template, field.FieldType, member.Name);
            }

            if (member is PropertyInfo property && property.CanWrite) {
                ProcessProperty(template, property.PropertyType, member.Name);
            }
        }
    }

    private void ProcessProperty(Template template, Type type, string name)
    {
        var typeCode = Type.GetTypeCode(type);

        if (typeCode != TypeCode.Object) {
            if (type.IsEnum) {
                template.AttributeOverrideTypes.Add(type);
            }

            template.SimpleAttributes[name] = new() {
                Type = type,
                Name = name
            };

            return;
        }

        if (_translators.TryGetValue(type, out string translator)) {
            template.OverloadedAttributes[name] = new() {
                Type = translator,
                Name = name
            };

            return;
        }

        template.UnsupportedTypes[name] = type;
    }
}

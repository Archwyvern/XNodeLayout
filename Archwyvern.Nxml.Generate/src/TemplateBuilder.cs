using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Archwyvern.Nxml.Generate;

public struct TypeEntry
{
    public Type Type;
    public Type Ancestor;
}

public class TemplateBuilder
{
    private string _namespace;
    private List<TypeEntry> _entries = new();
    private Dictionary<Type, string> _translators = new();

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

    public IEnumerable<Template> GetTemplates()
    {
        var templates = new Dictionary<Type, Template>();

        var processedTypes = new HashSet<Type>();
        var entries = _entries;

        do {
            var resources = new HashSet<TypeEntry>();

            foreach (TypeEntry entry in entries) {
                if (!entry.Type.CanInstantiate()) {
                    continue;
                }

                if (processedTypes.Contains(entry.Type)) {
                    continue;
                }

                processedTypes.Add(entry.Type);

                var template = ProcessEntry(entry);

                foreach (var resourceType in template.ResourceTypes) {
                    resources.Add(new() { Type = resourceType, Ancestor = typeof(Resource) });

                    foreach (var resourceSubType in Assembly.GetAssembly(resourceType).GetTypes()) {
                        if (resourceSubType.IsSubclassOf(resourceType) && resourceSubType.CanInstantiate()) {
                            resources.Add(new() { Type = resourceSubType, Ancestor = typeof(Resource) });
                        }
                    }
                }

                templates.Add(entry.Type, template);
            }

            entries = resources.ToList();
        } while(entries.Count > 0);

        foreach (var template in templates.Values) {
            foreach (var element in template.Elements.Values) {
                if (element.SubTypes == null) {
                    continue;
                }

                foreach (var type in element.SubTypes) {
                    element.SubTypeTemplates.Add(templates[type]);
                }
            }
        }

        return templates.Values;
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

        if (type.IsAssignableTo(typeof(Resource))) {
            template.ResourceTypes.Add(type);
            template.Elements[name] = new() {
                Type = type,
                Name = name,
                SubTypes = type.GetInstantiatableVariants().ToList()
            };

            return;
        }

        template.UnsupportedTypes[name] = type;
    }
}

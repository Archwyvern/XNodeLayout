using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Archwyvern.Nxml.Generate;

internal class Program
{
    private static string RootDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "/../../../../Archwyvern.Nxml/";

    public static void Main(string[] args)
    {
        var builder = new TemplateBuilder("Archwyvern.Nxml.Tags");

        AddTranslators(builder);
        LoadTypes(
            builder,
            Assembly.GetAssembly(typeof(Godot.Node)),
            typeof(Godot.Node),
            typeof(Godot.Node)
        );
        /*
        LoadTypes(
            builder,
            Assembly.GetAssembly(typeof(Godot.Node)),
            typeof(Godot.Resource),
            typeof(Godot.Resource)
        );
        */
            

        var templates = builder.GetTemplates();

        GenerateSourceFiles(templates);
        DumpUnsupportedTypes(templates);
    }

    private static void AddTranslators(TemplateBuilder builder)
    {
        var objects = new Dictionary<Type, string>()
        {
            { typeof(Godot.Vector2), "Vector2"},
            { typeof(Godot.Vector2I), "Vector2"},
            { typeof(Godot.Vector3), "Vector3"},
            { typeof(Godot.Vector3I), "Vector3"},
            { typeof(Godot.Vector4), "Vector4"},
            { typeof(Godot.Vector4I), "Vector4"},
            { typeof(Godot.StringName), "StringName"},
            { typeof(Godot.Color), "Color"},
        };

        foreach (var entry in objects) {
            builder.AddTranslator(entry.Key, "Archwyvern.Nxml.Translators." + entry.Value);
        }
    }

    private static void LoadTypes(TemplateBuilder builder, Assembly assembly, Type parent, Type ancestor)
    {
        foreach (var type in assembly.GetTypes()) {
            if (!(type == parent || type.IsSubclassOf(parent))) {
                continue;
            }

            if (!type.IsClass || type.IsGenericType || type.IsAbstract) {
                continue;
            }

            builder.AddType(type, ancestor);
        }
    }
    
    private static void GenerateSourceFiles(IEnumerable<Template> templates)
    {
        string source = RootDir + "src/Source/";

        DirectoryInfo tags = new DirectoryInfo(source + "/Tags/");
        string manifest = source + "Manifest.cs";
        string supportTags = source + "SupportTags.cs";
        string overrides = source + "Overrides.cs";

        if (!tags.Exists) {
            tags.Create();
        } else {
            foreach (FileInfo file in tags.GetFiles()) {
                file.Delete();
            }
        }

        foreach (var template in templates) {
            var path = tags.FullName + $"/{template.ClassName}.cs";

            WriteFile(new FileInfo(path), SourceBuilder.CreateTag(template));
        }

        WriteFile(new FileInfo(manifest), SourceBuilder.CreateManifest(templates));
        WriteFile(new FileInfo(supportTags), SourceBuilder.CreateSupportTags(templates));
        WriteFile(new FileInfo(overrides), SourceBuilder.CreateOverrides(templates));
    }

    private static void DumpUnsupportedTypes(IEnumerable<Template> templates)
    {
        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();
        var types = new HashSet<Type>();

        sb1.AppendLine("Unhandled types");
        sb1.AppendLine("===================================");
        foreach (var template in templates) {
            foreach (var entry in template.UnsupportedTypes) {
                if (!types.Contains(entry.Value)) {
                    sb1.AppendLine(entry.Value.FullName);
                    types.Add(entry.Value);
                    sb2.AppendLine($"{entry.Value.FullName}: {template.ClassName}.{entry.Key}");
                }
            }
        }

        sb1.AppendLine("");
        sb1.AppendLine("Examples");
        sb1.AppendLine("===================================");

        WriteFile(new FileInfo(RootDir + "todo.txt"), sb1.ToString() + sb2.ToString());
    }

    private static void WriteFile(FileInfo file, string content)
    {
        var writer = file.CreateText();

        Console.WriteLine("Writing to: " + file.FullName);
        writer.Write(content);
        writer.Close();
    }
}
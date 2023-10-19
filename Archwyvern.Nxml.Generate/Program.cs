using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Archwyvern.Nxml.Generate;

internal class Program
{
    private static string RootDir = Directory.GetParent(System.Environment.CurrentDirectory).FullName + "\\..\\..\\..\\Archwyvern.Nxml\\";

    public static void Main(string[] args)
    {
        var builder = new TemplateBuilder("Archwyvern.Nxml.Tags");

        AddTranslators(builder);
        LoadGodotAssembly(builder);

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

    private static void LoadGodotAssembly(TemplateBuilder builder)
    {
        var skip = new HashSet<Type>() {
            typeof(Godot.BaseButton),
            typeof(Godot.Range),
            typeof(Godot.ScrollBar),
            typeof(Godot.Slider),
            typeof(Godot.Separator),
        };

        foreach (var type in Assembly.GetAssembly(typeof(Godot.Control)).GetTypes()) {
            if (!type.IsSubclassOf(typeof(Godot.Control)) || !type.IsClass || type.IsGenericType || type.IsAbstract) {
                continue;
            }

            if (skip.Contains(type)) {
                continue;
            }

            builder.AddType(type, typeof(Godot.Node));
        }
    }
    
    private static void GenerateSourceFiles(IEnumerable<Template> templates)
    {
        string source = RootDir + "src\\Source\\";
        DirectoryInfo tags = new DirectoryInfo(source + "\\Tags\\");
        string manifest = source + "Manifest.cs";
        string baseTag = source + "Tag.cs";
        string overrides = source + "Overrides.cs";

        if (!tags.Exists) {
            tags.Create();
        } else {
            foreach (FileInfo file in tags.GetFiles()) {
                file.Delete();
            }
        }

        foreach (var template in templates) {
            var path = tags.FullName + $"\\{template.ClassName}.cs";

            Console.WriteLine("Writing to: " + path);

            WriteFile(new FileInfo(path), SourceBuilder.CreateTag(template));
        }

        WriteFile(new FileInfo(manifest), SourceBuilder.CreateManifest(templates));
        WriteFile(new FileInfo(baseTag), SourceBuilder.CreateBaseTag(templates));
        WriteFile(new FileInfo(overrides), SourceBuilder.CreateOverrides(templates));
    }

    private static void DumpUnsupportedTypes(IEnumerable<Template> templates)
    {
        var sb = new StringBuilder();
        var types = new HashSet<Type>();

        foreach (var template in templates) {
            foreach (var entry in template.UnsupportedTypes) {
                if (!types.Contains(entry.Value)) {
                    sb.AppendLine(entry.Value.FullName);
                    types.Add(entry.Value);
                }
            }
        }

        WriteFile(new FileInfo(RootDir + "todo.txt"), sb.ToString());
    }

    private static void WriteFile(FileInfo file, string content)
    {
        var writer = file.CreateText();
        writer.Write(content);
        writer.Close();
    }
}
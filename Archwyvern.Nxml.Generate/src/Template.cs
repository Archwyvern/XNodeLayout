using System;
using System.Collections.Generic;
using System.Text;

namespace Archwyvern.Nxml.Generate;

public class Template
{
    public string Namespace;
    public string ClassName;
    public Type Type;

    public class Property
    {
        public Type Type;
        public string Name;
        public Template Template;
        public List<Type> SubTypes = new();
        public List<Template> SubTypeTemplates = new();
    }
    public struct OverloadedProperty
    {
        public string Type;
        public string Name;
    }

    public Dictionary<string, Property> SimpleAttributes = new();
    public Dictionary<string, OverloadedProperty> OverloadedAttributes = new();
    public HashSet<Type> AttributeOverrideTypes = new();

    public Dictionary<string, Property> Elements = new();

    public HashSet<Type> ResourceTypes = new(); 
    public Dictionary<string, Type> UnsupportedTypes = new(); 

}
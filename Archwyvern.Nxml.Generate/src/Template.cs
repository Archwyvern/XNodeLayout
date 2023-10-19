using System;
using System.Collections.Generic;
using System.Text;

namespace Archwyvern.Nxml.Generate;

public class Template
{
    public string Namespace;
    public string ClassName;
    public Type Type;

    public struct AttributeType
    {
        public Type Type;
        public string Name;
    }
    public struct OverloadedAttributeType
    {
        public string Type;
        public string Name;
    }

    public Dictionary<string, AttributeType> SimpleAttributes = new();
    public Dictionary<string, OverloadedAttributeType> OverloadedAttributes = new();
    public HashSet<Type> AttributeOverrideTypes = new();

    public Dictionary<string, Type> UnsupportedTypes = new(); 

}
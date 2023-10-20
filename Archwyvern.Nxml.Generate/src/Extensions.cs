using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Archwyvern.Nxml.Generate;

internal static class Extensions
{
    public static string PrintName(this Type type) => type.FullName.Replace("+", ".");

    public static bool CanInstantiate(this Type type)
    {
        var constructor = type.GetConstructor(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            null,
            Type.EmptyTypes,
            null
        );

        if (constructor == null || constructor.IsAssembly) {
            return false;
        }

        return true;
    }

    public static IEnumerable<Type> GetInstantiatableVariants(this Type type)
    {
        foreach (var assemblyType in Assembly.GetAssembly(type).GetTypes()) {
            if ((assemblyType.IsSubclassOf(type) || assemblyType == type) && assemblyType.CanInstantiate()) {
                yield return assemblyType;
            }
        }
    }
}

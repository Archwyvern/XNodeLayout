using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archwyvern.Nxml.Generate;

internal static class Extensions
{
    public static string PrintName(this Type type) => type.FullName.Replace("+", ".");
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace JustCSharp.Epub.Utilities
{
    public static class TypeExtension
    {
        public static bool IsNonClass(this Type type)
        {
            return type.IsPrimitive || type == typeof(string) || type.IsEnum;
        }
        
        public static bool IsIEnumerable(this Type type)
        {
            return type.GetInterfaces().Contains(typeof(IEnumerable<>));
        }
        
        public static Type GetIEnumerableItemType(this Type type)
        {
            if (type.IsArray)
            {
                return type.GetElementType();
            }

            return type.GetGenericArguments().FirstOrDefault();
        }
        
    }
}
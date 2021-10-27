using System;
using System.Reflection;

namespace JustCSharp.Epub.Utilities
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayNameAttribute = enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttribute<EnumDisplayAttribute>();

            if(displayNameAttribute != null)
            {
                return displayNameAttribute.Display;
            }

            return enumValue.ToString();
        }
    }
}
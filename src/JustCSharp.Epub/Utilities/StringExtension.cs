using System;
using System.Reflection;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub.Utilities
{
    public static class StringExtension
    {
        public static T ToEnum<T>(this string data) where T : Enum
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException($"Can not convert empty string to enum");
            }
            
            var enumType = typeof(T);
            var enumFields = enumType.GetFields(EpubDefaultValues.SearchPropertyFlags);

            foreach (var enumField in enumFields)
            {
                if (enumField.ToString() == data)
                {
                    return (T) enumField.GetValue(null);
                }

                var displayAttribute = enumField.GetCustomAttribute<EnumDisplayAttribute>();

                if (displayAttribute?.Display == data)
                {
                    return (T) enumField.GetValue(null);
                }
            }

            throw new ArgumentException($"Can not convert {data} to type {enumType.Name}");
        }
    }
}
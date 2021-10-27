using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Exceptions;

namespace JustCSharp.Epub.Utilities
{
    public static class ObjectExtension
    {
        public static string SerializeXml<T>(this T data, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var stringWriter = new StringWriterWithEncoding(encoding))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
        }
        
        public static string SerializeXml(this object data, Type type, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            using (var stringWriter = new StringWriterWithEncoding(encoding))
            {
                var serializer = new XmlSerializer(type);
                serializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
        }

        public static T DeserializeXml<T>(this string xmlString)
        {
            using (var stringReader = new StringReader(xmlString))
            {
                var serializer = new XmlSerializer(typeof(T));
                var data = serializer.Deserialize(stringReader);
                return (T) data;
            }
        }
        
        public static object DeserializeXml(this string xmlString, Type type)
        {
            using (var stringReader = new StringReader(xmlString))
            {
                var serializer = new XmlSerializer(type);
                var data = serializer.Deserialize(stringReader);
                return data;
            }
        }
        
        public static void Validate(this object data)
        {
            if (data == null)
            {
                return;
            }
            
            var type = data.GetType();
            var properties = type.GetProperties(EpubDefaultValues.SearchPropertyFlags);

            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                var propertyValue = property.GetValue(data);
                var requiredAttr = property.GetCustomAttribute<RequiredAttribute>();
                
                if (requiredAttr != null && propertyValue == null )
                {
                    throw new EpubValidationException($"Validate failed for type {type.Name}")
                    {
                        Parert = data,
                        Property = property.Name
                    };
                }
                
                if(propertyType.IsIEnumerable())
                {
                    var propertyValueAsList = propertyValue as IEnumerable<object>;
                    
                    if (requiredAttr != null)
                    {
                        if (propertyValueAsList?.Count() == 0)
                        {
                            throw new EpubValidationException($"Validate failed for type {type.Name}")
                            {
                                Parert = data,
                                Property = property.Name
                            };
                        }
                    }

                    var itemType = propertyType.GetIEnumerableItemType();

                    if (!itemType.IsNonClass())
                    {
                        foreach (var item in propertyValueAsList)
                        {
                            item?.Validate();
                        }
                    }
                }
                else if (!propertyType.IsNonClass())
                {
                    propertyValue?.Validate();
                }
            }
        }
    }
}

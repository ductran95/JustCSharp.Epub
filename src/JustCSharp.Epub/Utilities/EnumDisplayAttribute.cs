using System;

namespace JustCSharp.Epub.Utilities
{
    internal class EnumDisplayAttribute: Attribute
    {
        public string Display { get; set; }
        
        public EnumDisplayAttribute()
        {
            
        }
        
        public EnumDisplayAttribute(string display)
        {
            Display = display;
        }
    }
}
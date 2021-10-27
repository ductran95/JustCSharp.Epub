using System.Xml.Serialization;

namespace JustCSharp.Epub.Constants
{
    public enum EpubTextDirection
    {
        [XmlEnum(Name="ltr")]
        Ltr = 1,
        [XmlEnum(Name="rtl")]
        Rtl
    }
    
    public enum EpubPageDirection
    {
        [XmlEnum(Name="default")]
        Default = 0,
        [XmlEnum(Name="ltr")]
        Ltr,
        [XmlEnum(Name="rtl")]
        Rtl
    }
}
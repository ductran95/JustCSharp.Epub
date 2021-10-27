using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Insfrastructure;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Documents
{
    [XmlRoot(ElementName = "container", Namespace = "http://www.idpf.org/2007/opf")]
    public class EpubPackageDocument: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        [SkipValidation]
        public EpubRendition Rendition => (EpubRendition) Parent;
        
        [Required]
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        
        [Required]
        [XmlAttribute(AttributeName = "unique-identifier")]
        public string UniqueIdentifier { get; set; }
        
        [XmlAttribute(AttributeName = "xml:lang")]
        public string Language { get; set; }
        
        [XmlAttribute(AttributeName = "dir")]
        public EpubTextDirection TextDirection { get; set; }
        
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        
        [Required]
        [XmlElement(ElementName = "metadata")]
        public MetadataElement Metadata { get; set; }
        
        [Required]
        [XmlElement(ElementName = "manifest")]
        public ManifestElement Manifest { get; set; }
        
        [Required]
        [XmlElement(ElementName = "spine")]
        public SpineElement Spine { get; set; }
        
        [XmlElement(ElementName = "collection")]
        public List<CollectionElement> Collections { get; set; }

        #endregion

        #region Constructors

        internal EpubPackageDocument()
        {
            SetDefaultData();
        }

        internal EpubPackageDocument(EpubRendition metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = Rendition.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "package.ocf";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubPackageDocument newObject)
            {
            }
        }

        #endregion

        #region Sub Classes

        public struct MetadataElement
        {
            [Required]
            [XmlElement(ElementName = "dc:identifier")]
            public List<IdentifierElement> Identifiers { get; set; }
            
            [Required]
            [XmlElement(ElementName = "dc:title")]
            public List<TitleElement> Titles { get; set; }
            
            [Required]
            [XmlElement(ElementName = "dc:language")]
            public List<LanguageElement> Languages { get; set; }
            
            [Required]
            [XmlElement(ElementName = "meta")]
            public List<MetaElement> Metas { get; set; }
            
            [Required]
            [XmlElement(ElementName = "link")]
            public List<LinkElement> Links { get; set; }
            
            [XmlElement(ElementName = "dc:contributor")]
            public List<DCMESElement> Contributor { get; set; }
            
            [XmlElement(ElementName = "dc:coverage")]
            public List<DCMESElement> Coverage { get; set; }
            
            [XmlElement(ElementName = "dc:creator")]
            public List<DCMESElement> Creator { get; set; }
            
            [XmlElement(ElementName = "dc:date")]
            public List<DCMESElement> Date { get; set; }
            
            [XmlElement(ElementName = "dc:description")]
            public List<DCMESElement> Description { get; set; }
            
            [XmlElement(ElementName = "dc:format")]
            public List<DCMESElement> Format { get; set; }
            
            [XmlElement(ElementName = "dc:publisher")]
            public List<DCMESElement> Publisher { get; set; }
            
            [XmlElement(ElementName = "dc:relation")]
            public List<DCMESElement> Relation { get; set; }
            
            [XmlElement(ElementName = "dc:rights")]
            public List<DCMESElement> Rights { get; set; }
            
            [XmlElement(ElementName = "dc:source")]
            public List<DCMESElement> Source { get; set; }
            
            [XmlElement(ElementName = "dc:subject")]
            public List<DCMESElement> Subject { get; set; }
            
            [XmlElement(ElementName = "dc:type")]
            public List<DCMESElement> Type { get; set; }
            
        }
        
        public struct ManifestElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [Required]
            [XmlElement(ElementName = "item")]
            public List<ManifestItemElement> Items { get; set; }
        }
        
        public struct SpineElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlAttribute(AttributeName = "page-progression-direction")]
            public EpubPageDirection PageProgressionDirection { get; set; }
        }
        
        public struct CollectionElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlAttribute(AttributeName = "dir")]
            public EpubTextDirection TextDirection { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "role")]
            public string Role { get; set; }
            
            [XmlAttribute(AttributeName = "xml:lang")]
            public string Language { get; set; }
            
            [XmlElement(ElementName = "metadata")]
            public MetadataElement Metadata { get; set; }
            
            [XmlElement(ElementName = "collection")]
            public List<CollectionElement> Collections { get; set; }
            
            [XmlElement(ElementName = "link")]
            public List<LinkElement> Links { get; set; }
        }
        
        public struct IdentifierElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }
        
        public struct TitleElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlAttribute(AttributeName = "dir")]
            public EpubTextDirection TextDirection { get; set; }
            
            [XmlAttribute(AttributeName = "xml:lang")]
            public string Language { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }
        
        public struct LanguageElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }
        
        public struct MetaElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlAttribute(AttributeName = "dir")]
            public EpubTextDirection TextDirection { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "property")]
            public string Property { get; set; }
            
            [XmlAttribute(AttributeName = "refines")]
            public string Refines { get; set; }
            
            [XmlAttribute(AttributeName = "scheme")]
            public string Scheme { get; set; }
            
            [XmlAttribute(AttributeName = "xml:lang")]
            public string Language { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }
        
        public struct LinkElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "href")]
            public string Href { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "media-type")]
            public string MediaType { get; set; }
            
            [XmlAttribute(AttributeName = "properties")]
            public string Properties { get; set; }
            
            [XmlAttribute(AttributeName = "refines")]
            public string Refines { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "rel")]
            public string Rel { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }
        
        public struct ManifestItemElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "href")]
            public string Href { get; set; }
            
            [XmlAttribute(AttributeName = "media-overlay")]
            public string MediaOverlay { get; set; }
            
            [Required]
            [XmlAttribute(AttributeName = "media-type")]
            public string MediaType { get; set; }
            
            [XmlAttribute(AttributeName = "fallback")]
            public string Fallback { get; set; }
            
            [XmlAttribute(AttributeName = "properties")]
            public string Properties { get; set; }
        }
        
        public struct DCMESElement
        {
            [XmlAttribute(AttributeName = "id")]
            public string Id { get; set; }
            
            [XmlAttribute(AttributeName = "dir")]
            public EpubTextDirection TextDirection { get; set; }
            
            [XmlAttribute(AttributeName = "xml:lang")]
            public string Language { get; set; }
            
            [XmlText]
            public string Value { get; set; }
        }

        #endregion
    }
}
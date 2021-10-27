namespace JustCSharp.Epub.Constants
{
    public static class EpubNamespaces
    {
        public const string Rendition = "http://www.idpf.org/vocab/rendition/#";
        public const string Package = "http://idpf.org/epub/vocab/package/#";
    }

    /// <summary>
    /// Metadata meta Properties
    /// Define properties for use in the meta element's property attribute.
    /// </summary>
    public static class EpubMetadataMetaProperties
    {
        /// <summary>
        /// The alternate-script property provides an alternate expression of the associated property value in a language and script identified by the xml:lang attribute.
        /// <remarks>
        /// This property is typically attached to creator and title properties for internationalization purposes.
        /// </remarks>
        /// </summary>
        public const string AlternateScript = "alternate-script";
        
        /// <summary>
        /// The authority property identifies the system or scheme the referenced element's value is drawn from.
        /// </summary>
        public const string Authority = "authority";
        
        /// <summary>
        /// The belongs-to-collection property identifies the name of a collection to which the EPUB Publication belongs. An EPUB Publication MAY belong to one or more collections.
        /// <remarks>
        /// It is also possible chain these properties using the refines attribute to indicate that one collection is itself a member of another collection.
        /// To allow Reading System to organize collections and avoid naming collisions (e.g., unrelated collections might share a similar name, or different editions of a collection could be released), an identifier SHOULD be provided that uniquely identifies the instance of the collection. The dcterms:identifier property must carry this identifier.
        /// The collection MAY more precisely define its nature by attaching a collection-type property.
        /// The position of the EPUB Publication within the collection MAY be provided by attaching a group-position property.
        /// </remarks>
        /// </summary>
        public const string BelongsToCollection = "belongs-to-collection";
        
        /// <summary>
        /// The collection-type property indicates the form or nature of a collection.
        /// <remarks>
        /// When the collection-type value is drawn from a code list or other formal enumeration, the scheme attribute SHOULD be attached to identify its source.
        /// When a scheme is not specified, Reading Systems SHOULD recognize the following collection type values:
        /// </remarks>
        /// <example>
        /// series
        /// A sequence of related works that are formally identified as a group; typically open-ended with works issued individually over time.
        /// </example>
        /// <example>
        ///set
        /// A finite collection of works that together constitute a single intellectual unit; typically issued together and able to be sold as a unit.
        /// </example>
        /// </summary>
        public const string CollectionType = "collection-type";
        
        /// <summary>
        /// The display-seq property indicates the numeric position in which to display the current property relative to identical metadata properties.
        /// <remarks>
        /// This property only applies where precedence rules have not already been defined (e.g., precedence is given to creators based on their appearance in document order).
        /// </remarks>
        /// </summary>
        public const string DisplaySeq = "display-seq";
        
        /// <summary>
        /// The file-as property provides the normalized form of the associated property for sorting.
        /// </summary>
        public const string FileAs = "file-as";
        
        /// <summary>
        /// The group-position property indicates the numeric position in which the EPUB Publication is ordered relative to other works belonging to the same group (whether all EPUB Publications or not).
        /// <remarks>
        /// The group-position property can be attached to any metadata property that establishes the group, but is typically associated with the belongs-to-collection property.
        /// An EPUB Publication can belong to more than one group.
        /// </remarks>
        /// </summary>
        public const string GroupPosition = "group-position";
        
        /// <summary>
        /// The identifier-type property indicates the form or nature of an identifier.
        /// <remarks>
        /// When the identifier-type value is drawn from a code list or other formal enumeration, the scheme attribute SHOULD be attached to identify its source.
        /// </remarks>
        /// </summary>
        public const string IdentifierType = "identifier-type";
        
        /// <summary>
        /// The role property describes the nature of work performed by a creator or contributor (e.g., that the person is the author or editor of a work).
        /// <remarks>
        /// When the role value is drawn from a code list or other formal enumeration, the scheme attribute SHOULD be attached to identify its source.
        /// </remarks>
        /// </summary>
        public const string Role = "role";
        
        /// <summary>
        /// The source-of property indicates a unique aspect of an adapted source resource that has been retained in the given Rendition of the EPUB Publication.
        /// <remarks>
        /// This specification defines the pagination value to indicate that the referenced dc:source element is the source of the pagebreak properties defined in the content.
        /// </remarks>
        /// </summary>
        public const string SourceOf = "source-of";
        
        /// <summary>
        /// The term property provides a subject code.
        /// </summary>
        public const string Term = "term";
        
        /// <summary>
        /// The title-type property indicates the form or nature of a title.
        /// <remarks></remarks>
        /// </summary>
        public const string TitleType = "title-type";
    }

    /// <summary>
    /// Metadata Link Relationships
    /// Used in the link element rel attribute to establish the relationship of the resource referenced in the href attribute.
    /// </summary>
    public static class EpubMetadataLinkRelationships
    {
        /// <summary>
        /// The acquire keyword is used with EPUB Previews to identify where the full version of the EPUB Publication can be acquired.
        /// <remarks>
        /// </remarks>
        /// </summary>
        public const string Acquire = "acquire";
        
        /// <summary>
        /// The alternate keyword is a subset of the HTML alternate keyword for links. It differs as follows:
        /// <remarks>
        /// It cannot be paired with other keywords.
        /// If an alternate link is included in the Package Document metadata, it identifies an alternate representation of the Package Document in the format specified in the media-type attribute.
        /// If an alternate link is included in a collection element's metadata [Packages], it identifies an alternate representation of the collection in the format specified in the media-type attribute.
        /// Reading Systems do not have to generate hyperlinks for alternate links.
        /// </remarks>
        /// </summary>
        public const string Alternate = "alternate";
        
        /// <summary>
        /// Indicates that the referenced resource is a metadata record.
        /// <remarks>
        /// The media type of the record is identified in the media-type attribute [Packages] when this keyword is specified.
        /// For a list of commonly-linked metadata record types, refer to the EPUB Linked Metadata Guide
        /// If the type of record cannot be identified from the media type, an identifier property can be assigned in the properties attribute [Packages].
        /// </remarks>
        /// </summary>
        public const string Record = "record";
        
        /// <summary>
        /// Indicates that the referenced audio file provides an aural representation of the expression or resource (typically, the title or creator) specified by the refines attribute.
        /// <remarks>
        /// The media type of the audio file is identified in the media-type attribute [Packages] when this keyword is specified.
        /// </remarks>
        /// </summary>
        public const string Voicing = "voicing";
    }

    /// <summary>
    /// Metadata Link Properties
    /// Used in the link element's properties attribute to establish the type of record a referenced resource represents.
    /// </summary>
    public static class EpubMetadataLinkProperties
    {
        /// <summary>
        /// The onix property indicates the referenced resource is an ONIX record [ONIX].
        /// </summary>
        public const string Onix = "onix";
        
        /// <summary>
        /// The xmp property indicates the referenced resource is an XMP record [XMP].
        /// </summary>
        public const string Xmp = "xmp";
    }

    /// <summary>
    /// Manifest item Properties
    /// Define properties for use in the manifest item element properties attribute.
    /// </summary>
    public static class EpubManifestItemProperties
    {
        /// <summary>
        /// The cover-image property identifies the described Publication Resource as the cover image for the Publication.
        /// </summary>
        public const string CoverImage = "cover-image";
        
        /// <summary>
        /// The mathml property indicates that the described Publication Resource contains one or more instances of MathML markup.
        /// </summary>
        public const string Mathml = "mathml";
        
        /// <summary>
        /// The nav property indicates that the described Publication Resource constitutes the EPUB Navigation Document of the given Rendition.
        /// </summary>
        public const string Nav = "nav";
        
        /// <summary>
        /// The remote-resources property indicates that the described Publication Resource contains one or more internal references to other Publication Resources that are located outside of the EPUB Container.
        /// <remarks>
        /// Refer to Publication Resource Locations [EPUB32] for more information.
        /// </remarks>
        /// </summary>
        public const string RemoteResources = "remote-resources";
        
        /// <summary>
        /// 	The scripted property indicates that the described Publication Resource is a Scripted Content Document (i.e., contains scripted content and/or HTML form elements).
        /// </summary>
        public const string Scripted = "scripted";
        
        /// <summary>
        /// The svg property indicates that the described Publication Resource embeds one or more instances of SVG markup.
        /// <remarks>
        /// This property MUST be set when SVG markup is included directly in the resource and MAY be set when the SVG is referenced from the resource (e.g., from an [HTML] img, object or iframe element).
        /// </remarks>
        /// </summary>
        public const string Svg = "svg";
    }

    /// <summary>
    /// Spine itemref Properties
    /// define properties for use in the itemref element properties attribute [Packages].
    /// </summary>
    public static class EpubSpineItemRefProperties
    {
        /// <summary>
        /// The page-spread-left property indicates that the first page of the associated item element's EPUB Content Document represents the left-hand side of a two-page spread.
        /// </summary>
        public const string PageSpreadLeft = "page-spread-left";
        
        /// <summary>
        /// The page-spread-right property indicates that the first page of the associated item element's EPUB Content Document represents the right-hand side of a two-page spread.
        /// </summary>
        public const string PageSpreadRight = "page-spread-right";
    }
}
using JustCSharp.Epub.Insfrastructure;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Required container.xml file
    /// </summary>
    [XmlRoot(ElementName = "container", Namespace = "urn:oasis:names:tc:opendocument:xmlns:container")]
    public class EpubContainer : EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        [SkipValidation]
        public EpubMetaInf MetaInf => (EpubMetaInf) Parent;

        [Required]
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        
        [Required]
        [XmlArray(ElementName = "rootfiles")]
        [XmlArrayItem(ElementName = "rootfile")]
        public List<RootFileElement> RootFiles { get; set; }

        #endregion

        #region Constructors

        internal EpubContainer()
        {
            SetDefaultData();
        }

        internal EpubContainer(EpubMetaInf metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "container.xml";
            Encoding = Encoding.UTF8;
            Version = "1.0";
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubContainer newObject)
            {
                this.Version = newObject.Version;
                this.RootFiles = newObject.RootFiles;
            }
        }

        #endregion

        #region Sub Classes

        public struct RootFileElement
        {
            [Required]
            [XmlAttribute(AttributeName = "full-path")]
            public string FullPath { get; set; }

            [Required]
            [XmlAttribute(AttributeName = "media-type")]
            public string MediaType { get; set; }
        }

        #endregion
    }
}
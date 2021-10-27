using JustCSharp.Epub.Insfrastructure;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Optional metadata.xml file
    /// </summary>
    public class EpubMetadata: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        [SkipValidation]
        public EpubMetaInf MetaInf => (EpubMetaInf)Parent;

        #endregion

        #region Constructors

        internal EpubMetadata()
        {
            SetDefaultData();
        }

        internal EpubMetadata(EpubMetaInf metaInf) : this()
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }

        private void SetDefaultData()
        {
            FileName = "metadata.xml";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubMetaInf newObject)
            {
            }
        }

        #endregion
        
        #region Sub Classes

        

        #endregion
    }
}
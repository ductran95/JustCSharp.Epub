using JustCSharp.Epub.Insfrastructure;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JustCSharp.Epub.Meta
{
    /// <summary>
    /// Optional manifest.xml file
    /// </summary>
    public class EpubManifest: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubMetaInf MetaInf => (EpubMetaInf)Parent;

        #endregion

        #region Constructors

        internal EpubManifest()
        {
            SetDefaultData();
        }

        internal EpubManifest(EpubMetaInf metaInf) : this()
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }

        private void SetDefaultData()
        {
            FileName = "manifest.xml";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubManifest newObject)
            {
            }
        }

        #endregion
        
        #region Sub Classes

        

        #endregion
    }
}
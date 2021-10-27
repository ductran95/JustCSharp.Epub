using System.Text;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub.Documents
{
    public class EpubNavigationDocument: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubRendition MetaInf => (EpubRendition) Parent;

        #endregion

        #region Constructors

        internal EpubNavigationDocument()
        {
            SetDefaultData();
        }

        internal EpubNavigationDocument(EpubRendition metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "toc.xhtml";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubNavigationDocument newObject)
            {
            }
        }

        #endregion

        #region Sub Classes

        

        #endregion
    }
}
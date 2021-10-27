using System.Text;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub.Documents
{
    public class EpubContentDocument: EpubElementXmlFile
    {
        #region Const

        #endregion

        #region Properties

        public EpubRendition MetaInf => (EpubRendition) Parent;

        #endregion

        #region Constructors

        internal EpubContentDocument()
        {
            SetDefaultData();
        }

        internal EpubContentDocument(EpubRendition metaInf)
        {
            SetDefaultData();
            Parent = metaInf;
            Encoding = MetaInf.Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            FileName = "content.xhtml";
            Encoding = Encoding.UTF8;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Internal & Private Methods

        protected override void MapFrom(object data)
        {
            if (data is EpubContentDocument newObject)
            {
            }
        }

        #endregion

        #region Sub Classes

        

        #endregion
    }
}
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Insfrastructure;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Mime
{
    public class EpubMimetype : EpubElementTextFile
    {
        #region Const

        #endregion

        #region Properties

        [SkipValidation]
        public EpubPublication Publication { get; set; }

        [Required]
        public string Mimetype { get; set; }
        

        #endregion

        #region Constructors

        internal EpubMimetype()
        {
            SetDefaultData();
        }

        public EpubMimetype(EpubPublication publication) : this()
        {
            SetDefaultData();
            Publication = publication;
            Parent = publication.Parent;
            Encoding = Publication.Encoding;
        }
        
        private void SetDefaultData()
        {
            Encoding = Encoding.UTF8;
            FileName = "mimetype";
            Mimetype = "application/epub+zip";
            FileDataChanged += OnRawDataChanged;
        }

        #endregion

        #region Public Methods

        

        #endregion

        #region Internal & Private Methods

        protected void OnRawDataChanged()
        {
            Mimetype = _textContent;
        }

        protected string BuildRawData()
        {
            return Mimetype;
        }

        #endregion
    }
}
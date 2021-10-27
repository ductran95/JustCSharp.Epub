using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Documents;
using JustCSharp.Epub.Insfrastructure;
using JustCSharp.Epub.Meta;
using JustCSharp.Epub.Mime;

namespace JustCSharp.Epub
{
    public class EpubPublication: EpubElementBinaryFile
    {
        #region Const

        

        #endregion

        #region Properties

        public string Version { get; set; }
        public Encoding Encoding { get; set; }
        
        public EpubMetaInf MetaInf { get; set; }
        public List<EpubRendition> Renditions { get; set; }
        public EpubMimetype Mimetype { get; set; }

        #endregion

        #region Constructors

        public EpubPublication()
        {
            SetDefaultData();
            Parent = new EpubRootFolder();
        }

        public EpubPublication(string fileUrl)
        {
            SetDefaultData();
            
            // Auto detect version & encoding
            var directory = Path.GetDirectoryName(fileUrl);
            Parent = new EpubRootFolder(directory);
        }

        private void SetDefaultData()
        {
            Version = "3.2";
            Encoding = Encoding.UTF8;
        }

        #endregion
        
        #region Public Methods

        

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}
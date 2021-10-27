using JustCSharp.Epub.Insfrastructure;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub.Meta
{
    public class EpubMetaInf: EpubElementFolder
    {
        #region Const



        #endregion

        #region Properties

        public EpubRootFolder RootFolder => (EpubRootFolder) RootFolder;

        public EpubPublication Publication { get; set; }
        
        public EpubContainer Container { get; set; }
        public EpubManifest Manifest { get; set; }
        public EpubMetadata Metadata { get; set; }

        #endregion

        #region Constructors

        internal EpubMetaInf()
        {
            SetDefaultData();
        }
        
        internal EpubMetaInf(EpubPublication publication)
        {
            SetDefaultData();
            Publication = publication;
            Parent = publication.Parent;
        }
        
        private void SetDefaultData()
        {
            
        }

        #endregion

        #region Public Methods

        public override void Read(int bufferSize = EpubDefaultValues.BufferSize)
        {
            throw new System.NotImplementedException();
        }

        public override async Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
            throw new System.NotImplementedException();
        }

        public override async Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub.Documents
{
    public class EpubRendition: EpubElementFolder
    {
        #region Const



        #endregion

        #region Properties

        public EpubRootFolder RootFolder => (EpubRootFolder) RootFolder;

        public EpubPublication Publication { get; set; }
        
        public EpubPackageDocument PackageDocument { get; set; }
        
        public EpubNavigationDocument NavigationDocument { get; set; }
        
        public List<EpubContentDocument> ContentDocuments { get; set; }
        
        public List<IEpubAsset> Assets { get; set; }

        #endregion

        #region Constructors

        internal EpubRendition()
        {
            SetDefaultData();
        }
        
        internal EpubRendition(EpubPublication publication)
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
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Insfrastructure;

namespace JustCSharp.Epub
{
    public class EpubRootFolder: EpubElementFolder
    {
        #region Const



        #endregion

        #region Properties


        #endregion

        #region Constructors

        internal EpubRootFolder()
        {
            
        }

        internal EpubRootFolder(string folder)
        {
            Folder = folder;
        }

        #endregion

        #region Public Methods

        public override void Read(int bufferSize = EpubDefaultValues.BufferSize)
        {
        }

        public override Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
        }

        public override Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}
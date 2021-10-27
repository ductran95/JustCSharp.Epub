using System.IO;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementFolder : IReader, IWriter
    {
        #region Properties

        public EpubElementFolder Parent { get; set; }
        public string Folder { get; set; }

        #endregion

        #region Public Methods

        public abstract void Read(int bufferSize = EpubDefaultValues.BufferSize);

        public abstract Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);

        public abstract void Write(int bufferSize = EpubDefaultValues.BufferSize);

        public abstract Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);

        #endregion
        
        #region Internal & Private Methods

        internal virtual string GetFolderPath()
        {
            return Parent != null ? Path.Combine(Parent.GetFolderPath(), Folder) : Folder;
        }
        
        #endregion
    }
}

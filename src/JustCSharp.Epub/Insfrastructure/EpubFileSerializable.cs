using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubFileSerializable: EpubElementTextFile
    {
        #region Properties

        #endregion
        
        #region Constructors
        
        internal EpubFileSerializable()
        {
            FileDataChanged += OnRawDataChanged;
        }

        #endregion

        #region Public Methods

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
            this.Validate();
            TextContent = BuildRawData();
            base.Write(bufferSize);
        }

        public override async Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            this.Validate();
            TextContent = BuildRawData();
            await base.WriteAsync(bufferSize, cancellationToken);
        }

        #endregion
        
        #region Internal & Private Methods

        protected abstract void MapFrom(object data);

        protected abstract void OnRawDataChanged();

        protected abstract string BuildRawData();

        #endregion

    }
}
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementTextFile : EpubElementFile
    {
        #region Properties

        protected string _textContent;

        protected string TextContent
        {
            get => _textContent;
            set
            {
                if (value != _textContent)
                {
                    _textContent = value;
                    OnFileDataChanged();
                }
            }
        }

        public Encoding Encoding { get; set; }

        #endregion

        #region Public Methods

        public override void Read(int bufferSize = EpubDefaultValues.BufferSize)
        {
            TextContent = GetFilePath().ReadTextFile(Encoding, bufferSize);
        }

        public override async Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            TextContent = await GetFilePath().ReadTextFileAsync(Encoding, bufferSize, cancellationToken).ConfigureAwait(false);
        }

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
            GetFilePath().WriteTextFile(TextContent, Encoding, bufferSize);
        }

        public override async Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default)
        {
            await GetFilePath().WriteTextFileAsync(TextContent, Encoding, bufferSize, cancellationToken).ConfigureAwait(false);
        }

        #endregion
        
        #region Internal & Private Methods


        #endregion
    }
}

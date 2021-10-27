using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementBinaryFile: EpubElementFile
    {
        #region Properties

        protected byte[] BinaryContent { get; set; }

        #endregion

        #region Public Methods

        public override void Read(int bufferSize = EpubDefaultValues.BufferSize)
        {
            BinaryContent = GetFilePath().ReadBinaryFile(bufferSize);
        }

        public override async Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize,
            CancellationToken cancellationToken = default)
        {
            BinaryContent = await GetFilePath().ReadBinaryFileAsync(bufferSize, cancellationToken);
        }

        public override void Write(int bufferSize = EpubDefaultValues.BufferSize)
        {
            GetFilePath().WriteBinaryFile(BinaryContent, bufferSize);
        }

        public override async Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize,
            CancellationToken cancellationToken = default)
        {
             await GetFilePath().WriteBinaryFileAsync(BinaryContent, bufferSize, cancellationToken);
        }

        #endregion
        
        #region Internal & Private Methods

        

        #endregion
    }
}

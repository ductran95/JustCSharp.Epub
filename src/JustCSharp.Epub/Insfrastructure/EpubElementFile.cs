using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Annotations;
using JustCSharp.Epub.Constants;
using JustCSharp.Epub.Utilities;

namespace JustCSharp.Epub.Insfrastructure
{
    public abstract class EpubElementFile : IReader, IWriter
    {
        #region Properties

        internal event FileDataChangedEventHandler FileDataChanged;
        
        public EpubElementFolder Parent { get; set; }
        public string FileName { get; set; }

        #endregion

        #region Public Methods

        public abstract void Read(int bufferSize = EpubDefaultValues.BufferSize);

        public abstract Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);

        public abstract void Write(int bufferSize = EpubDefaultValues.BufferSize);

        public abstract Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);

        #endregion
        
        #region Internal & Private Methods

        internal virtual string GetFilePath()
        {
            return Path.Combine(Parent.GetFolderPath(), FileName);
        }
        
        protected virtual void OnFileDataChanged()
        {
            FileDataChanged?.Invoke();
        }

        #endregion

    }
}

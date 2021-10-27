using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub
{
    public interface IWriter
    {
        void Write(int bufferSize = EpubDefaultValues.BufferSize);
        Task WriteAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);
    }
}
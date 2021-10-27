using System.Threading;
using System.Threading.Tasks;
using JustCSharp.Epub.Constants;

namespace JustCSharp.Epub
{
    public interface IReader
    {
        void Read(int bufferSize = EpubDefaultValues.BufferSize);
        Task ReadAsync(int bufferSize = EpubDefaultValues.BufferSize, CancellationToken cancellationToken = default);
    }
}
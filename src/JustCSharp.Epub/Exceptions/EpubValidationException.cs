using System;

namespace JustCSharp.Epub.Exceptions
{
    public class EpubValidationException: Exception
    {
        public object Parert { get; set; }
        public string Property { get; set; }

        public EpubValidationException(string message, Exception innerException = null): base(message, innerException)
        {
            
        }
    }
}
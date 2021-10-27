using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JustCSharp.Epub.Utilities
{
    public class StringWriterWithEncoding: StringWriter
    {
        private Encoding _encoding;

        public override Encoding Encoding => _encoding;

        public StringWriterWithEncoding()
        {
            _encoding = Encoding.UTF8;
        }

        public StringWriterWithEncoding(Encoding encoding)
        {
            _encoding = encoding;
        }
    }
}

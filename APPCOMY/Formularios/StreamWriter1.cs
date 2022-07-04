using System;

namespace APPCOMY
{
    internal class StreamWriter
    {
        private FileStream fs;

        public StreamWriter(FileStream fs)
        {
            this.fs = fs;
        }

        internal void WriteLine(string text)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}
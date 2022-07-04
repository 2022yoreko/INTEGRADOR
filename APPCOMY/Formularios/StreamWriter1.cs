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
           
        }

        internal void Close()
        {

        }
    }
}
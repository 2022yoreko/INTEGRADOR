using System.IO;

namespace APPCOMY
{
    internal class FileStream 
    {
        
        private string rutarchivo;
        private FileMode append;

        public FileStream (string rutarchivo, FileMode append)
        { 
            this.rutarchivo = rutarchivo;
            this.append = append;
        }
    }
}
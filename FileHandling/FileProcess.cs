using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHandling
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename");
            }
            return File.Exists(fileName);
        }
    }
}

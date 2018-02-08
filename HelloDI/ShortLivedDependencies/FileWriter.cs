using System;
using System.IO;

namespace HelloDI.ShortLivedDependencies
{
    public class FileWriter : IFileWriter
    {
        private readonly StreamWriter _streamWriter;

        public FileWriter()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Message.txt";
            _streamWriter = new StreamWriter(path, true);
        }

        public void WriteToFile(string message)
        {
            _streamWriter.WriteLine(message);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }
}
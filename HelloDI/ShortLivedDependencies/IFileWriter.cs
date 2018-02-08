using System;

namespace HelloDI.ShortLivedDependencies
{
    public interface IFileWriter : IDisposable
    {
        void WriteToFile(string message);
    }
}
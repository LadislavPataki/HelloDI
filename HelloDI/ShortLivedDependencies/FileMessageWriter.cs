using System;

namespace HelloDI.ShortLivedDependencies
{
    public class FileMessageWriter : IMessageWriter
    {
        private readonly IWriterFactory _writerFactory;

        public FileMessageWriter(IWriterFactory writerFactory)
        {
            _writerFactory = writerFactory ?? throw new ArgumentNullException(nameof(writerFactory));
        }

        public void Write(string message)
        {
            using (var writer = _writerFactory.CreateWriter())
            {
                writer.WriteToFile(message);
            }
        }
    }
}
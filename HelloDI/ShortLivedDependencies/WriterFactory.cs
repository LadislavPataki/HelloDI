namespace HelloDI.ShortLivedDependencies
{
    public class WriterFactory : IWriterFactory
    {
        public IFileWriter CreateWriter()
        {
            return new FileWriter();
        }
    }
}
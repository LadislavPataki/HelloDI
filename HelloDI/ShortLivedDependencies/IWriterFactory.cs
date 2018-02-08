namespace HelloDI.ShortLivedDependencies
{
    public interface IWriterFactory
    {
        IFileWriter CreateWriter();
    }
}
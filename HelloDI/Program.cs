using System.Configuration;
using System.Threading;
using HelloDI.RuntimeDependencies;
using HelloDI.ShortLivedDependencies;

namespace HelloDI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var typeName =
            //    ConfigurationManager.AppSettings["messageWriter"];
            //var type = Type.GetType(typeName, true);
            //IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);


            //IMessageWriter writer = new ConsoleMessageWriter();
            //IMessageWriter secureWriter = new DecoratedMessageWriter(writer);
            //var salutation = new Salutation(secureWriter);


            //IMessageWriter writer = new ConsoleMessageWriter();
            //var salutation = new Salutation(writer);

            //salutation.Exclaim();




            #region Resolving dependencies by runtime values

            //IMessageWriter writer = new ConsoleMessageWriter();
            //ISalutationProvider salutationProvider = new SalutationProvider(writer);

            //var salutation = new LocalizedSalutation(salutationProvider);

            //salutation.Exclaim(Language.Spanish);
            //salutation.Exclaim(Language.German);

            #endregion


            IWriterFactory writerFactory = new WriterFactory();
            IMessageWriter writer = new FileMessageWriter(writerFactory);
            var salutation = new Salutation(writer);

            salutation.Exclaim();
            salutation.Exclaim();
            salutation.Exclaim();

            

        }
    }
}






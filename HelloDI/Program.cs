using System.Configuration;
using System.Security.Principal;
using System.Threading;
using HelloDI.Interception;
using HelloDI.RuntimeDependencies;
using HelloDI.ShortLivedDependencies;

namespace HelloDI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Late binding

            //var typeName =
            //    ConfigurationManager.AppSettings["messageWriter"];
            //var type = Type.GetType(typeName, true);
            //IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);

            #endregion

            #region Extensibility

            // Example 1
            // IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter(), WindowsIdentity.GetCurrent());


            // Example 2
            // IMessageWriter writer = new DecoratedMessageWriter(new ConsoleMessageWriter());

            #endregion

            #region Standard DI

            //IMessageWriter writer = new ConsoleMessageWriter();

            #endregion

            #region Resolving dependencies by runtime values

            //IMessageWriter writer = new ConsoleMessageWriter();
            //ISalutationProvider salutationProvider = new SalutationProvider(writer);

            //var salutation = new LocalizedSalutation(salutationProvider);

            //salutation.Exclaim(Language.Spanish);
            //salutation.Exclaim(Language.German);

            #endregion

            #region Short lived dependencies

            IWriterFactory writerFactory = new WriterFactory();
            IMessageWriter writer = new FileMessageWriter(writerFactory);

            #endregion

            var salutation = new Salutation(writer);

            salutation.Exclaim();
            salutation.Exclaim();
            salutation.Exclaim();
        }
    }
}






using System;
using System.Configuration;
using System.Threading;

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


            IMessageWriter writer = new ConsoleMessageWriter();
            IMessageWriter secureWriter = new DecoratedMessageWriter(writer);
            var salutation = new Salutation(secureWriter);


            //IMessageWriter writer = new ConsoleMessageWriter();
            //var salutation = new Salutation(writer);

            salutation.Exclaim();
        }
    }

    public class Salutation
    {
        private readonly IMessageWriter _writer;

        public Salutation(IMessageWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            _writer = writer;
        }

        public void Exclaim()
        {
            _writer.Write("Hello DI!");
        }
    }

    public interface IMessageWriter
    {
        void Write(string message);
    }

    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LateBindedConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"{message} - late binding message writer");
        }
    }

    public class DecoratedMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;

        public DecoratedMessageWriter(IMessageWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            _writer = writer;
        }

        public void Write(string message)
        {
            var decoratedMessage = $"{message} - decorated";
                _writer.Write(decoratedMessage);
        }
    }
}






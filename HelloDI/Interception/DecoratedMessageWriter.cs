using System;

namespace HelloDI.Interception
{
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
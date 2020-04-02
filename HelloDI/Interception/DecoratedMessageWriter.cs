using System;

namespace HelloDI.Interception
{
    public class DecoratedMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;

        public DecoratedMessageWriter(IMessageWriter writer)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public void Write(string message)
        {
            var decoratedMessage = $"{message} - decorated";
            _writer.Write(decoratedMessage);
        }
    }
}
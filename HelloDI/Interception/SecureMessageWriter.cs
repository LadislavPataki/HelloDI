using System.Security.Principal;

namespace HelloDI.Interception
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _messageWriter;
        private readonly IIdentity _identity;

        public SecureMessageWriter(IMessageWriter messageWriter, IIdentity identity)
        {
            if (messageWriter != null) _messageWriter = messageWriter;
            if (identity != null) _identity = identity;
        }

        public void Write(string message)
        {
            if (_identity.IsAuthenticated)
            {
                _messageWriter.Write(message);
            }
        }
    }
}
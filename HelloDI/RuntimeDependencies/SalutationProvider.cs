using System;

namespace HelloDI.RuntimeDependencies
{
    class SalutationProvider : ISalutationProvider
    {
        private readonly IMessageWriter _messageWriter;

        public SalutationProvider(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter ?? throw new ArgumentNullException(nameof(messageWriter));
        }

        public SalutationBase GetSalutation(Language language)
        {
            switch (language)
            {
                case Language.Spanish:
                    return new SpanishSalutation(_messageWriter);
                case Language.German:
                    return new GermanSalutation(_messageWriter);
                case Language.English:
                default:
                    return null;
            }
        }
    }
}
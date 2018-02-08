using System;

namespace HelloDI.RuntimeDependencies
{
    public abstract class SalutationBase
    {
        private readonly IMessageWriter _writer;

        protected SalutationBase(IMessageWriter writer)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        protected void ExclaimInternal(string salutation)
        {
            _writer.Write(salutation);
        }

        public abstract void Exclaim();
    }
}
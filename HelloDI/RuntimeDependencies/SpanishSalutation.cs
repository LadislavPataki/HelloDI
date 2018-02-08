namespace HelloDI.RuntimeDependencies
{
    public class SpanishSalutation : SalutationBase
    {
        public SpanishSalutation(IMessageWriter writer) : base(writer)
        {
        }

        public override void Exclaim()
        {
            ExclaimInternal("Hola!");
        }
    }
}
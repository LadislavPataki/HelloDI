namespace HelloDI.RuntimeDependencies
{
    public class GermanSalutation : SalutationBase
    {
        public GermanSalutation(IMessageWriter writer) : base(writer)
        {
        }

        public override void Exclaim()
        {
            ExclaimInternal("Halo!");
        }
    }
}
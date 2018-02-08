namespace HelloDI.RuntimeDependencies
{
    public interface ISalutationProvider
    {
        SalutationBase GetSalutation(Language language);
    }
}
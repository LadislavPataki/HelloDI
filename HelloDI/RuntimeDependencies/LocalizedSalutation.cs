using System;

namespace HelloDI.RuntimeDependencies
{
    public class LocalizedSalutation
    {
        private readonly ISalutationProvider _salutation;

        public LocalizedSalutation(ISalutationProvider salutationProvider)
        {
            _salutation = salutationProvider ?? throw new ArgumentNullException(nameof(salutationProvider));
        }

        public void Exclaim(Language language)
        {
            var salutation = _salutation.GetSalutation(language);

            salutation.Exclaim();
        }
    }
}
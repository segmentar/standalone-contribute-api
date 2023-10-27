using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class ContributeIntentionalShortMethod : Attribute
    {
        public ContributeIntentionalShortMethod()
        {
            return;
        }

        ~ContributeIntentionalShortMethod()
        {
            return;
        }
    }
}

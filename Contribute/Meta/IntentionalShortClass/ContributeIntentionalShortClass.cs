using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class ContributeIntentionalShortClass : Attribute
    {
        public ContributeIntentionalShortClass()
        {
            return;
        }

        ~ContributeIntentionalShortClass()
        {
            return;
        }
    }
}

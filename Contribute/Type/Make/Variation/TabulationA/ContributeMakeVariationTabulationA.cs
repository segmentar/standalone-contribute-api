using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeVariationTabulationA()
        {
            Contribute contributeResult = default;

            Contribute contribute;

            contribute = Contribute.MakeContributeDefaultSurface(ContributeCode.TabulationType.TabulationA);

            contributeResult = contribute;

            return contributeResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeDefaultSurface(ContributeCode.TabulationType TabulationType__ITEM)
        {
            Contribute contributeResult = default;

            contributeResult = MakeContributeDefault(TabulationType__ITEM, ContributePolicy.ContributeDebugPolicy);

            return contributeResult;
        }
    }
}

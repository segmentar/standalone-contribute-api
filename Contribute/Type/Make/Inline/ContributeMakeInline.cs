using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeInline(ContributeCode.TabulationType TabulationType__ITEM, String[] Split_ARRAY)
        {
            Contribute contributeResult = default;

            Contribute contribute;

            contribute = MakeContributeDefaultSurface(TabulationType__ITEM);

            switch (TabulationType__ITEM)
            {
                case ContributeCode.TabulationType.TabulationA:
                    contribute.TabulationA(Split_ARRAY);
                    break;

                case ContributeCode.TabulationType.TabulationB:
                    contribute.TabulationB(Split_ARRAY);
                    break;

                case ContributeCode.TabulationType.TabulationC:
                    contribute.TabulationC(Split_ARRAY);
                    break;

                case ContributeCode.TabulationType.TabulationD:
                    contribute.TabulationD(Split_ARRAY);
                    break;

                default:
                    break;
            }

            contributeResult = contribute;

            return contributeResult;
        }
    }
}

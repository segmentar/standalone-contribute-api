using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Contribute MakeContributeDefault(ContributeCode.TabulationType TabulationType__ITEM, Boolean answer_DEBUG_is)
        {
            Contribute contributeResult = default;

            var result = new ContributeSequence(TabulationType__ITEM, answer_DEBUG_is).Result;

            ContributePolicy.ContributeArrayList.Add(result);

            contributeResult = result;

            return contributeResult;
        }
    }
}

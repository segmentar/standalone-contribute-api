using Core;

namespace Core
{
    using System;

    public partial class ContributeSequence
    {
        public Contribute Result { get; set; } = default;

        public ContributeSequence(ContributeCode.TabulationType TabulationType__ITEM, Boolean answer_DEBUG_is)
        {
            Debug(TabulationType__ITEM, answer_DEBUG_is);

            Contribute contribute;

            contribute = new Contribute(TabulationType__ITEM, answer_DEBUG_is);

            this.Result = contribute;

            return;
        }

        ~ContributeSequence()
        {
            return;
        }
    }
}

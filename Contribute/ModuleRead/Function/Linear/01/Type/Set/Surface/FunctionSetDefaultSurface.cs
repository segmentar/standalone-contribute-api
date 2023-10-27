using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleRead
    {
        public partial class FunctionFirst
        {
            public static Contribute[] FunctionDefaultSetSurface(Contribute[] ContributeA__ARRAY, Contribute[] ContributeB__ARRAY, Contribute[] ContributeC__ARRAY, Contribute[] ContributeD__ARRAY)
            {
                Contribute[] arrayResult = default;

                var list = FunctionDefaultSet(ContributeA__ARRAY, ContributeB__ARRAY, ContributeC__ARRAY, ContributeD__ARRAY);

                var array = new Contribute[list.Count];

                list.CopyTo(array, ContributePolicy.ContributeIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

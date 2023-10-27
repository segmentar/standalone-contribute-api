using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleRead
    {
        public static ContributeModuleRead FunctionOne(ContributeModuleRead module, Contribute[] ContributeA__ARRAY, Contribute[] ContributeB__ARRAY, Contribute[] ContributeC__ARRAY, Contribute[] ContributeD__ARRAY)
        {
            var array = FunctionFirst.FunctionDefaultSetSurface(ContributeA__ARRAY, ContributeB__ARRAY, ContributeC__ARRAY, ContributeD__ARRAY);

            FunctionFirst first;

            first = new FunctionFirst(array);

            module.First = first;

            return module;
        }
    }
}

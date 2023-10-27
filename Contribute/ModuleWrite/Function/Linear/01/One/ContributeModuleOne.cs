using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteLinear
    {
        public static ContributeModuleWrite ContributeModuleOne(ContributeModuleWrite module, Contribute[] array_CONTRIBUTE)
        {
            var array = ContributeModuleFunctionTen.ContributeOrderContainerSurface<Tuple<Int32, Contribute>>(array_CONTRIBUTE);

            var function = new ContributeModuleFunctionTen(array);

            ContributeModuleFirst first;

            first = new ContributeModuleFirst(function);

            module.First = first;

            return module;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteLinear
    {
        public static ContributeModuleWrite ContributeModuleTwo(ContributeModuleWrite module, Tuple<Int32, Contribute>[] array_TUPLE)
        {
            var array = ContributeModuleFunctionTwenty.FunctionRegionContainerSurface<Tuple<Int32, Int32, Int32, Contribute>>(array_TUPLE);

            var function = new ContributeModuleFunctionTwenty(array);

            ContributeModuleSecond second;

            second = new ContributeModuleSecond(function);

            module.Second = second;

            return module;
        }
    }
}

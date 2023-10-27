using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        public static ContributeModuleWrite ModuleWrite(ContributeModuleWrite module, Contribute[] array_CONTRIBUTE)
        {
            var function = new FunctionWrite(array_CONTRIBUTE);

            module.FunctionWrite = function;

            return module;
        }
    }
}

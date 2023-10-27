using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWrite
    {
        public static ContributeModuleWrite ContributeModuleDefault(Contribute[] array_CONTRIBUTE)
        {
            ContributeModuleWrite module;

            module = new ContributeModuleWrite();

            try
            {
                module = ContributeModuleWriteCycle.ModuleWrite(module, array_CONTRIBUTE);

                module = ContributeModuleWriteLinear.ContributeModuleOne(module, module.FunctionWrite.ContributeArray);

                module = ContributeModuleWriteLinear.ContributeModuleTwo(module, module.First.Function.TupleArray);

                module = ContributeModuleWriteLinear.ContributeModuleThreeThird(module, module.Second.Function.TupleArray);

                module = ContributeModuleWriteCycle.ModuleHeader(module);

                module = ContributeModuleWriteCycle.ModuleA(module, module.FunctionA.TupleArray, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteCycle.ModuleB(module, module.FunctionB.TupleArray, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteCycle.ModuleC(module, module.FunctionC.TupleArray, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteCycle.ModuleD(module, module.FunctionD.TupleArray, module.FunctionHeader.ObjectIdentityTableAddress);
                
                module = ContributeModuleWriteLone.ModuleContributeObjectIdentityMemoryStream(module);

                module = ContributeModuleWriteLone.ModuleContributeHeaderMemoryStream(module);       
                
                module = ContributeModuleWriteLone.ModuleContributeMemoryStream(module);
            }
            catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}

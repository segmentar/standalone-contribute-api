using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleRead
    {
        public static ContributeModuleRead ContributeModuleDefault(FileStream item__FILE_STREAM)
        {
            ContributeModuleRead module;

            module = new ContributeModuleRead();

            try
            {
                module = ContributeModuleReadIO.ModuleRead(module, item__FILE_STREAM);

                item__FILE_STREAM.Seek(0, SeekOrigin.Begin);

                module = ContributeModuleReadIO.ModuleHeader(module, item__FILE_STREAM);

                module = ContributeModuleReadIO.ModuleA(module,module.FunctionHeader.TabulationTableAddressA);

                module = ContributeModuleReadIO.ModuleAA(module, module.FunctionArrayA);

                module = FunctionOne(module, module.FunctionAA.ContributeArray, new Contribute[0], new Contribute[0], new Contribute[0]);

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}

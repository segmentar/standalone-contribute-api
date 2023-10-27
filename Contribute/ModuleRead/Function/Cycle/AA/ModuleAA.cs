using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleReadIO
    {
        public static ContributeModuleRead ModuleAA(ContributeModuleRead module, FunctionA[] array_FUNCTION)
        {
            var list = new ArrayList();

            foreach (FunctionA item_FUNCTION in array_FUNCTION)
            {
                Contribute contribute;

                contribute = Contribute.MakeContributeVariationTabulationA();

                contribute.Indexer = ContributeStringSafe.Simple(item_FUNCTION.Indexer);

                contribute.Ordinal = item_FUNCTION.Ordinal;

                contribute.Type = ContributeStringSafe.Simple(item_FUNCTION.Type);

                contribute.Name = ContributeStringSafe.Simple(item_FUNCTION.Name);

                contribute.Value = ContributeStringSafe.Simple(item_FUNCTION.Value);

                contribute.ObjectIdentity = item_FUNCTION.ObjectIdentity;

                contribute.ByteArray = item_FUNCTION.ByteArray;

                list.Add(contribute);

                continue;
            }

            var reflect = (Contribute[])(list.ToArray(typeof(Contribute)) as Array);

            var function = new FunctionAA(reflect);

            module.FunctionAA = function;

            return module;
        }
    }
}

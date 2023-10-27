using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleWriteLinear
    {
        public partial class ContributeModuleFunctionTen
        {
            public static ArrayList ContributeOrderContainer(Contribute[] array_CONTRIBUTE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var ordinal = 1;

                foreach (Contribute item_CONTRIBUTE in array_CONTRIBUTE)
                {
                    Tuple<Int32, Contribute> tuple;

                    tuple = new Tuple<Int32, Contribute>(ordinal, item_CONTRIBUTE);

                    listResult.Add(tuple);

                    ordinal = ordinal + 1;

                    continue;
                }

                return listResult;
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleWriteLinear
    {
        public static ContributeModuleWrite ContributeModuleThreeThird(ContributeModuleWrite module, Tuple<Int32, Int32, Int32, Contribute>[] array_TUPLE)
        {
            var TabulationTableA___ARRAY_LIST = new ArrayList();

            var TabulationTableB___ARRAY_LIST = new ArrayList();

            var TabulationTableC___ARRAY_LIST = new ArrayList();

            var TabulationTableD___ARRAY_LIST = new ArrayList();

            foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in array_TUPLE)
            {
                ContributeCode.TabulationType tabulationType;

                tabulationType = item_TUPLE.Item4.TabulationType;

                switch (tabulationType)
                {
                    case ContributeCode.TabulationType.TabulationA:
                        TabulationTableA___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationB:
                        TabulationTableB___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationC:
                        TabulationTableC___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    case ContributeCode.TabulationType.TabulationD:
                        TabulationTableD___ARRAY_LIST.Add(item_TUPLE);
                        break;

                    default:
                        break;
                }

                continue;
            }

            var reflect__TABULATION_TABLE_A = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableA___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_B = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableB___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_C = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableC___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            var reflect__TABULATION_TABLE_D = (Tuple<Int32, Int32, Int32, Contribute>[])(TabulationTableD___ARRAY_LIST.ToArray(typeof(Tuple<Int32, Int32, Int32, Contribute>)) as Array);

            module.FunctionA = new ContributeModuleWriteCycle.FunctionA(reflect__TABULATION_TABLE_A);

            module.FunctionB = new ContributeModuleWriteCycle.FunctionB(reflect__TABULATION_TABLE_B);

            module.FunctionC = new ContributeModuleWriteCycle.FunctionC(reflect__TABULATION_TABLE_C);

            module.FunctionD = new ContributeModuleWriteCycle.FunctionD(reflect__TABULATION_TABLE_D);

            return module;
        }
    }
}

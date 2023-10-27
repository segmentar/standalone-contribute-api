using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ContributeModuleWriteLinear
    {
        public partial class ContributeModuleFunctionTwenty
        {
            public static ArrayList FunctionRegionContainer(Tuple<Int32, Contribute>[] array_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var position = 0;

                foreach (Tuple<Int32, Contribute> item_TUPLE in array_TUPLE)
                {
                    var Order_ITEM = item_TUPLE.Item1;

                    var Contribute_ITEM = item_TUPLE.Item2;

                    var RegionAddressStart___ITEM = position;

                    position = position + Contribute_ITEM.ByteArray.Length;

                    var RegionAddressEnd___ITEM = position;

                    Tuple<Int32, Int32, Int32, Contribute> tuple;

                    tuple = new Tuple<Int32, Int32, Int32, Contribute>(Order_ITEM, RegionAddressStart___ITEM, RegionAddressEnd___ITEM, Contribute_ITEM);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}

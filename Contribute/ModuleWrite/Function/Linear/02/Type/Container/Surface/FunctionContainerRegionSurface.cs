using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial struct ContributeModuleWriteLinear
    {
        public partial class ContributeModuleFunctionTwenty
        {
            public static T[] FunctionRegionContainerSurface<T>(Tuple<Int32, Contribute>[] array_TUPLE)
            {
                T[] arrayResult = default;

                var list = FunctionRegionContainer(array_TUPLE);

                IEnumerable enumerable;

                enumerable = list.OfType<T>().Cast<T>().ToArray();

                var reflect = (T[])(enumerable as Array);

                T[] array;

                array = reflect;

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}

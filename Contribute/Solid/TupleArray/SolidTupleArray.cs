using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static String SolidTupleArray<T>(T[] array_TUPLE)
        {
            String stringResult = default;

            var result = String.Empty;

            result = result + $"<{array_TUPLE.Length}>";

            result = result + '\n';

            foreach (T item_TYPE in array_TUPLE)
            {
                result = result + item_TYPE.GetType().Name;

                result = result + '\n';

                result = result + SolidTuple<T>(item_TYPE);

                continue;
            }

            stringResult = result;
            
            return stringResult;
        }
    }
}

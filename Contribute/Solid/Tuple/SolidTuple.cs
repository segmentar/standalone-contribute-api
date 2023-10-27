using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Reflection;

    public partial class Contribute
    {
        public static String SolidTuple<T>(T item_TYPE)
        {
            String stringResult = default;

            var result = String.Empty;

            var type = item_TYPE.GetType();

            PropertyInfo[] propertyInfoArray;

            propertyInfoArray = type.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfoArray)
            {
                var name = propertyInfo.Name;

                var value = propertyInfo.GetValue(item_TYPE);

                Boolean isArrayContagentCheck;

                isArrayContagentCheck = (value is Array) is true;
                
                if (isArrayContagentCheck)
                {
                    var array = (Array)(value as Object);

                    var list = new ArrayList(array);

                    var descriptor = String.Empty;

                    descriptor = descriptor + name + ':' + ' ' + ". . ." + ' ' + $"<{list.Count}>" + ':';

                    descriptor = descriptor + '\n';

                    descriptor = descriptor + String.Join('\n'.ToString(), list.ToArray());

                    result = result + descriptor;
                }
                else
                {
                    var descriptor = String.Empty;

                    descriptor = descriptor + name + ':';

                    descriptor = descriptor + '\n';

                    descriptor = descriptor + value;

                    result = result + descriptor;
                }

                result = result + '\n';

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}

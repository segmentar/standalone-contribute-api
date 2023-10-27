using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static String SolidRenderFileName(String[] Split_ARRAY, Int32 item_ORDINAL)
        {
            String stringResult = default;

            var aoth = Split_ARRAY.Length;

            var roth = (aoth - 1);

            var eoth = Split_ARRAY[roth];

            var format = String.Format("{0} {1}", eoth, item_ORDINAL);

            var path_NAME_file = format; 

            var result = path_NAME_file;

            stringResult = result;

            return stringResult;
        }
    }
}

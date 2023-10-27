using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static String[] SolidRenderSplit(String Path_ITEM)
        {
            String[] arrayResult = default;

            var Entity_UNDERSCORE = Convert.ToChar(95);

            var separator = new Char[] { Entity_UNDERSCORE };

            var split = Path_ITEM.Split(separator, StringSplitOptions.None);

            var array = split;

            arrayResult = array;

            return arrayResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static String RenderSpecialName(String Path_ITEM)
        {
            String stringResult = default;

            var Entity_DASH = Convert.ToChar(45);

            var Entity_UNDERSCORE = Convert.ToChar(95);

            var separator = new Char[] { Entity_DASH, Entity_UNDERSCORE };

            var split = Path_ITEM.Split(separator, StringSplitOptions.None);

            var join = String.Join(Entity_UNDERSCORE.ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}

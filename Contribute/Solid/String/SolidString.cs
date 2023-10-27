using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static String SolidString(String item_STRING)
        {
            String stringResult = default;

            Char[] characterArray;

            characterArray = item_STRING.ToCharArray();

            var array = SolidCharacterArray(characterArray);

            var result = new String(array);

            stringResult = result;

            return stringResult;
        }
    }
}

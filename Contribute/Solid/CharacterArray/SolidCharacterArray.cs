using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Char[] SolidCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            var indexer = 0;

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = array_CHARACTER.Length.Equals(indexer) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Char character;

                character = array_CHARACTER[indexer];

                array_CHARACTER[indexer] = SolidCharacter(character);

                indexer = indexer + 1;

                continue;

            } while (true);

            arrayResult = array_CHARACTER;

            return arrayResult;
        }
    }
}

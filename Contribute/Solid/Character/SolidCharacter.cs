using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static Char SolidCharacter(Char item_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(item_CHARACTER))
            {
                var Entity_WHITE_SPACE = Convert.ToChar(32);

                character = Entity_WHITE_SPACE;
            }
            else
            {
                character = item_CHARACTER;
            }

            characterResult = character;

            return characterResult;
        }
    }
}

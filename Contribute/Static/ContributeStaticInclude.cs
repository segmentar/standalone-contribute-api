using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static void Include(Contribute[] array_CONTRIBUTE)
        {
            foreach (Contribute item_CONTRIBUTE in array_CONTRIBUTE)
            {
                ContributeArrayList.Add(item_CONTRIBUTE);

                continue;
            }

            return;
        }
    }
}

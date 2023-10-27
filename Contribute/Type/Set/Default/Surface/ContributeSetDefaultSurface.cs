using Core;

namespace Core
{
    using System;


    public partial class Contribute
    {
        public static Contribute[] ContributeDefaultSetSurface(String[] array_STRING)
        {
            Contribute[] arrayResult = default;

            var list = ContributeDefaultSet(array_STRING);

            var array = new Contribute[list.Count];

            list.CopyTo(array, ContributePolicy.ContributeIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}

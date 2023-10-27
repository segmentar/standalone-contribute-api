using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct ContributeModuleRead
    {
        public partial class FunctionFirst
        {
            public static IList<Contribute> FunctionDefaultSet(Contribute[] ContributeA__ARRAY, Contribute[] ContributeB__ARRAY, Contribute[] ContributeC__ARRAY, Contribute[] ContributeD__ARRAY)
            {
                ICollection<Contribute> collectionResult = default;

                collectionResult = new Collection<Contribute>();

                foreach (Contribute contribute in ContributeA__ARRAY)
                {
                    collectionResult.Add(contribute);

                    continue;
                }

                foreach (Contribute contribute in ContributeB__ARRAY)
                {
                    collectionResult.Add(contribute);

                    continue;
                }

                foreach (Contribute contribute in ContributeC__ARRAY)
                {
                    collectionResult.Add(contribute);

                    continue;
                }

                foreach (Contribute contribute in ContributeD__ARRAY)
                {
                    collectionResult.Add(contribute);

                    continue;
                }

                return new List<Contribute>(collectionResult);
            }
        }
    }
}

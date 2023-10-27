using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Contribute
    {
        public static IList<Contribute> ContributeDefaultSet(String[] array_STRING)
        {
            ICollection<Contribute> collectionResult = default;

            collectionResult = new Collection<Contribute>();

            Stack stack;

            stack = new Stack(array_STRING);

            stack = new Stack(stack);

            do
            {
                Boolean shouldBreakCheck;

                shouldBreakCheck = stack.Count.Equals(0) is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var reflect = (String)(stack.Pop() as Object);

                var entity__WHITE_SPACE = Convert.ToChar(32);

                var split = reflect.Split(new String[] { entity__WHITE_SPACE.ToString() }, StringSplitOptions.None);

                var oth = split[0];

                var lower = oth.ToLower();

                ContributeCode.TabulationType tabulationType;

                switch (oth)
                {
                    case ContributeConstant.TabulationA:
                        tabulationType = ContributeCode.TabulationType.TabulationA;
                        break;

                    case ContributeConstant.TabulationB:
                        tabulationType = ContributeCode.TabulationType.TabulationB;
                        break;

                    case ContributeConstant.TabulationC:
                        tabulationType = ContributeCode.TabulationType.TabulationC;
                        break;

                    case ContributeConstant.TabulationD:
                        tabulationType = ContributeCode.TabulationType.TabulationD;
                        break;

                    default:
                        tabulationType = ContributeCode.TabulationType.Unset;
                        break;
                };

                Contribute contribute;

                contribute = MakeContributeInline(tabulationType, split);

                collectionResult.Add(contribute);

                continue;

            } while (true);

            return new List<Contribute>(collectionResult);
        }
    }
}

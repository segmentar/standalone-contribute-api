using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionB
        {
            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArray;

            public FunctionB(Tuple<Int32, Int32, Int32, Contribute>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~FunctionB()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleWriteCycle) + ' ' + "::" + ' ' + nameof(FunctionB) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Contribute>>(TupleArray)
                });
            }
        }
    }
}

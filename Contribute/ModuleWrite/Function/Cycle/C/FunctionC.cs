using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionC
        {
            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArray;

            public FunctionC(Tuple<Int32, Int32, Int32, Contribute>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~FunctionC()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleWriteCycle) + ' ' + "::" + ' ' + nameof(FunctionC) + ' ' + '{',
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

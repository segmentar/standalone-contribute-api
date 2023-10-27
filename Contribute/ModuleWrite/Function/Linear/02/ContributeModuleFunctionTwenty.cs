using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteLinear
    {
        [ContributeIntentionalShortClass]
        public partial class ContributeModuleFunctionTwenty
        {
            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArray;

            public ContributeModuleFunctionTwenty(Tuple<Int32, Int32, Int32, Contribute>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~ContributeModuleFunctionTwenty()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleFunctionTwenty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Contribute>>(TupleArray)
                });
            }
        }
    }
}

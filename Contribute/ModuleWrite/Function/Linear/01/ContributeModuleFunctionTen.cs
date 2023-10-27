using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteLinear
    {
        [ContributeIntentionalShortClass]
        public partial class ContributeModuleFunctionTen
        {
            public Tuple<Int32, Contribute>[] TupleArray;

            public ContributeModuleFunctionTen(Tuple<Int32, Contribute>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~ContributeModuleFunctionTen()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleFunctionTen) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Contribute>>(TupleArray)
                });
            }
        }
    }
}

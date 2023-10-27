using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleReadIO
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionAA
        {
            public Contribute[] ContributeArray;

            public FunctionAA(Contribute[] contributeArray)
            {
                this.ContributeArray = contributeArray;

                return;
            }

            ~FunctionAA()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleReadIO) + ' ' + "::" + ' ' + nameof(FunctionAA) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ContributeArray) + ':' + ' ' + ". . ." + ' ' + $"<{ContributeArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ContributeArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), (Object[])(ContributeArray as Array))
                });
            }
        }
    }
}

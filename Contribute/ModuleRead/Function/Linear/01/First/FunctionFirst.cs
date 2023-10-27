using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleRead
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionFirst
        {
            public Contribute[] ContributeArray;

            public FunctionFirst(Contribute[] contributeArray)
            {
                this.ContributeArray = contributeArray;

                return;
            }

            ~FunctionFirst()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleRead) + ' ' + "::" + ' ' + nameof(FunctionFirst) + ' ' + '{',
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

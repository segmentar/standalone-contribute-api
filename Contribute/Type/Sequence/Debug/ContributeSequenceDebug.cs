using Core;

namespace Core
{
    using System;

    public partial class ContributeSequence
    {
        [ContributeIntentionalShortMethod]
        public static void Debug(ContributeCode.TabulationType TabulationType_ITEM, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Contribute) + ' ' + "::" + ' ' + nameof(ContributeSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TabulationType_ITEM) + ':' + ' ' + TabulationType_ITEM,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}'
            }));

            return;
        }
    }
}

using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWrite
    {
        public static ContributeModuleWrite ContributeModuleAction(Contribute[] array_CONTRIBUTE, Boolean answer_POLICY_is)
        {
            ContributeModuleWrite module;

            module = ContributeModuleDefault(array_CONTRIBUTE);

            try
            {
                if (answer_POLICY_is is true)
                {
                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}100", module.FunctionWrite);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteLinear)}10", module.First.Function);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteLinear)}20", module.Second.Function);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}400", module.FunctionA);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}500", module.FunctionB);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}600", module.FunctionC);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}700", module.FunctionD);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionWrite-{nameof(ContributeModuleWriteCycle)}200", module.FunctionHeader);
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}

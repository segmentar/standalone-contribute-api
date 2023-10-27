using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleRead
    {
        public static ContributeModuleRead ContributeModuleAction(FileStream item__FILE_STREAM, Boolean answer_POLICY_is)
        {
            ContributeModuleRead module;

            module = ContributeModuleDefault(item__FILE_STREAM);

            try
            {
                if (answer_POLICY_is is true)
                {
                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionRead-{nameof(ContributeModuleReadIO)}100", module.FunctionRead);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionRead-{nameof(ContributeModuleReadIO)}200", module.FunctionHeader);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionRead-{nameof(ContributeModuleReadIO)}300", String.Join('\n'.ToString(), module.FunctionArrayA));

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionRead-{nameof(ContributeModuleReadIO)}400", module.FunctionAA);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(Contribute)}ActionRead-{nameof(ContributeModuleRead)}10", module.First);
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

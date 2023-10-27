using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public Contribute(ContributeCode.TabulationType tabulationType, Boolean debug)
        {
            this.TabulationType = tabulationType;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}

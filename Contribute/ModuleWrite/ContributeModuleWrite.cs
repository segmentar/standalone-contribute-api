using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWrite
    {
        public ContributeModuleWriteCycle.FunctionWrite FunctionWrite;

        public ContributeModuleWriteLinear.ContributeModuleFirst First;

        public ContributeModuleWriteLinear.ContributeModuleSecond Second;

        public ContributeModuleWriteCycle.FunctionA FunctionA;

        public ContributeModuleWriteCycle.FunctionB FunctionB;

        public ContributeModuleWriteCycle.FunctionC FunctionC;

        public ContributeModuleWriteCycle.FunctionD FunctionD;

        public MemoryStream TabulationMemoryStreamA;

        public MemoryStream TabulationMemoryStreamB;

        public MemoryStream TabulationMemoryStreamC;

        public MemoryStream TabulationMemoryStreamD;

        public ContributeModuleWriteCycle.FunctionHeader FunctionHeader;

        public MemoryStream HeaderMemoryStream;

        public MemoryStream ObjectIdentityMemoryStream;

        public MemoryStream MemoryStream;
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleReadIO
    {
        public static ContributeModuleRead ModuleRead(ContributeModuleRead module, FileStream item__FILE_STREAM)
        {
            Byte[] byteArray;

            byteArray = new Byte[item__FILE_STREAM.Length];

            var read = item__FILE_STREAM.Read(byteArray, 0, byteArray.Length);

            var function = new FunctionRead(item__FILE_STREAM, byteArray, read);

            module.FunctionRead = function;

            return module;
        }
    }
}

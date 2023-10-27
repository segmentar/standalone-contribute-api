using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteCycle
    {
        public static ContributeModuleWrite ModuleD(ContributeModuleWrite module, Tuple<Int32, Int32, Int32, Contribute>[] array_TUPLE, Int32 Address_ITEM)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            using (binaryWriter)
            {
                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.TabulationMemoryStreamD = memoryStream;

            return module;
        }
    }
}

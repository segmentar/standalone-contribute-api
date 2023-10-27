using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleContributeObjectIdentityMemoryStream(ContributeModuleWrite module)
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

            module.ObjectIdentityMemoryStream = memoryStream;

            return module;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleContributeHeaderMemoryStream(ContributeModuleWrite module)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            using (binaryWriter)
            {
                binaryWriter.Write(module.FunctionHeader.HeaderSize);

                binaryWriter.Write(module.FunctionHeader.ObjectIdentityTableLength);

                binaryWriter.Write(module.FunctionHeader.ObjectIdentityTableAddress);

                binaryWriter.Write(module.FunctionHeader.TabulationTableLengthA);

                binaryWriter.Write(module.FunctionHeader.TabulationTableAddressA);

                binaryWriter.Write(module.FunctionHeader.TabulationTableLengthB);

                binaryWriter.Write(module.FunctionHeader.TabulationTableAddressB);

                binaryWriter.Write(module.FunctionHeader.TabulationTableLengthC);

                binaryWriter.Write(module.FunctionHeader.TabulationTableAddressC);

                binaryWriter.Write(module.FunctionHeader.TabulationTableLengthD);

                binaryWriter.Write(module.FunctionHeader.TabulationTableAddressD);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }
                
            module.HeaderMemoryStream = memoryStream;
            
            return module;
        }
    }
}

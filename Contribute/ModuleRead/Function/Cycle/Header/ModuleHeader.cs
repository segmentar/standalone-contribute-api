using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleReadIO
    {
        public static ContributeModuleRead ModuleHeader(ContributeModuleRead module, FileStream item__FILE_STREAM)
        {
            BinaryReader binaryReader;

            binaryReader = new BinaryReader(item__FILE_STREAM, Contribute.ReaderEncoding, true);

            FunctionHeader functionReadHeader;

            functionReadHeader = new FunctionHeader();

            using (binaryReader)
            {
                functionReadHeader.HeaderSize = binaryReader.ReadInt32();

                functionReadHeader.ObjectIdentityTableLength = binaryReader.ReadInt32();

                functionReadHeader.ObjectIdentityTableAddress = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableLengthA = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableAddressA = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableLengthB = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableAddressB = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableLengthC = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableAddressC = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableLengthD = binaryReader.ReadInt32();

                functionReadHeader.TabulationTableAddressD = binaryReader.ReadInt32();

                binaryReader.Close();

                binaryReader.Dispose();
            }

            module.FunctionHeader = functionReadHeader;

            return module;
        }
    }
}

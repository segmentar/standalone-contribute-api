using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteCycle
    {
        public static ContributeModuleWrite ModuleA(ContributeModuleWrite module, Tuple<Int32, Int32, Int32, Contribute>[] array_TUPLE, Int32 Address_ITEM)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            using (binaryWriter)
            {
                foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in array_TUPLE)
                {
                    var position = binaryWriter.BaseStream.Position;

                    var Order_ITEM = item_TUPLE.Item1;

                    var RegionRelativeAddressStart___ITEM = item_TUPLE.Item2;

                    var RegionRelativeAddressEnd___ITEM = item_TUPLE.Item3;

                    var RegionAbsoluteAddressStart___ITEM = (Address_ITEM + RegionRelativeAddressStart___ITEM);

                    var RegionAbsoluteAddressEnd___ITEM = (Address_ITEM + RegionRelativeAddressEnd___ITEM);

                    var Contribute_ITEM = item_TUPLE.Item4;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Order_ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(RegionAbsoluteAddressStart___ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(RegionAbsoluteAddressEnd___ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Indexer.StringValue);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Ordinal);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Type.StringValue);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Name.StringValue);

                    position = position + Contribute.BoundarySize;

                    continue;
                }

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.TabulationMemoryStreamA = memoryStream;

            return module;
        }
    }
}

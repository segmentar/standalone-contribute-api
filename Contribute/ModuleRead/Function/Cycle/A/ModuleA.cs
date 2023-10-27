using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct ContributeModuleReadIO
    {
        public static ContributeModuleRead ModuleA(ContributeModuleRead module, Int32 TabulationTableAddressA____ITEM)
        {
            var list = new ArrayList();

            BinaryReader binaryReader;

            binaryReader = new BinaryReader(module.FunctionRead.FileStream, Contribute.ReaderEncoding, true);

            var position = TabulationTableAddressA____ITEM;

            using (binaryReader)
            {
                var array = new Byte[0];

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var Order_ITEM = binaryReader.ReadInt32();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var RegionStart__ITEM = binaryReader.ReadInt32();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var RegionEnd__ITEM = binaryReader.ReadInt32();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);                

                var Indexer_ITEM = binaryReader.ReadString();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var Ordinal_ITEM = binaryReader.ReadInt32();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var Type_ITEM = binaryReader.ReadString();

                position = position + Contribute.BoundarySize;

                binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                var Name_ITEM = binaryReader.ReadString();

                position = position + Contribute.BoundarySize;

                var Value_ITEM = binaryReader.ReadString();

                var function = new FunctionA();

                function.Order = Order_ITEM;

                function.RegionStart = RegionStart__ITEM;

                function.RegionEnd = RegionEnd__ITEM;

                function.Indexer = Indexer_ITEM;

                function.Ordinal = Ordinal_ITEM;

                function.Type = Type_ITEM;

                function.Name = Name_ITEM;

                function.Value = Value_ITEM;

                function.ByteArray = array;

                var start = RegionStart__ITEM;

                var difference = (function.RegionEnd - start);

                Array.Resize(ref array, difference);

                Array.Copy(module.FunctionRead.ByteArray, start, array, 0, difference);

                list.Add(function);

                binaryReader.Close();

                binaryReader.Dispose();
            }

            var reflect = (FunctionA[])(list.ToArray(typeof(FunctionA)) as Array);

            module.FunctionArrayA = reflect;

            return module;
        }
    }
}

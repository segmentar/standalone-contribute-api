using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        public static ContributeModuleWrite ModuleHeader(ContributeModuleWrite module)
        {
            var HeaderSize__ITEM = 0;

            HeaderSize__ITEM = HeaderSize__ITEM + (sizeof(Int32) * 4);

            HeaderSize__ITEM = HeaderSize__ITEM + (sizeof(Int32) * 4);

            var TabulationTableLengthA____ITEM = module.FunctionA.TupleArray.Length;

            var TabulationTableLengthB____ITEM = module.FunctionB.TupleArray.Length;

            var TabulationTableLengthC____ITEM = module.FunctionC.TupleArray.Length;

            var TabulationTableLengthD____ITEM = module.FunctionD.TupleArray.Length;

            var TabulationTableAddressA____ITEM = 0;

            TabulationTableAddressA____ITEM = TabulationTableAddressA____ITEM + Contribute.BoundaryStart;

            var TabulationTableAddressB___ITEM = 0;

            TabulationTableAddressB___ITEM = TabulationTableAddressB___ITEM + Contribute.BoundaryStart;

            TabulationTableAddressB___ITEM = TabulationTableAddressB___ITEM + (Contribute.BoundarySize * TabulationTableLengthA____ITEM);

            var TabulationTableAddressC____ITEM = 0;

            TabulationTableAddressC____ITEM = TabulationTableAddressC____ITEM + Contribute.BoundaryStart;

            TabulationTableAddressC____ITEM = TabulationTableAddressC____ITEM + (Contribute.BoundarySize * TabulationTableLengthA____ITEM);

            TabulationTableAddressC____ITEM = TabulationTableAddressC____ITEM + (Contribute.BoundarySize * TabulationTableLengthB____ITEM);

            var TabulationTableAddressD____ITEM = 0;

            TabulationTableAddressD____ITEM = TabulationTableAddressD____ITEM + Contribute.BoundaryStart;

            TabulationTableAddressD____ITEM = TabulationTableAddressD____ITEM + (Contribute.BoundarySize * TabulationTableLengthA____ITEM);

            TabulationTableAddressD____ITEM = TabulationTableAddressD____ITEM + (Contribute.BoundarySize * TabulationTableLengthB____ITEM);

            TabulationTableAddressD____ITEM = TabulationTableAddressD____ITEM + (Contribute.BoundarySize * TabulationTableLengthC____ITEM);

            var ObjectIdentityTableAddress____ITEM = 0;

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + Contribute.BoundaryStart;

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + (Contribute.BoundarySize * TabulationTableLengthA____ITEM);

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + (Contribute.BoundarySize * TabulationTableLengthB____ITEM);

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + (Contribute.BoundarySize * TabulationTableLengthC____ITEM);

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + (Contribute.BoundarySize * TabulationTableLengthD____ITEM);

            var ObjectIdentityTableLength____ITEM = module.FunctionWrite.ContributeArray.Length;

            var function = new FunctionHeader();

            function.HeaderSize = HeaderSize__ITEM;

            function.ObjectIdentityTableLength = ObjectIdentityTableLength____ITEM;

            function.ObjectIdentityTableAddress = ObjectIdentityTableAddress____ITEM;

            function.TabulationTableLengthA = TabulationTableLengthA____ITEM;

            function.TabulationTableLengthB = TabulationTableLengthB____ITEM;

            function.TabulationTableLengthC = TabulationTableLengthC____ITEM;

            function.TabulationTableLengthD = TabulationTableLengthD____ITEM;

            function.TabulationTableAddressA = TabulationTableAddressA____ITEM;

            function.TabulationTableAddressB = TabulationTableAddressB___ITEM;

            function.TabulationTableAddressC = TabulationTableAddressC____ITEM;

            function.TabulationTableAddressD = TabulationTableAddressD____ITEM;

            module.FunctionHeader = function;

            return module;
        }
    }
}

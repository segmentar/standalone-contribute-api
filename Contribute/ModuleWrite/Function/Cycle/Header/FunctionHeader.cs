using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        [ContributeIntentionalShortClass]
        public partial struct FunctionHeader
        {
            public Int32 HeaderSize;

            public Int32 ObjectIdentityTableLength;

            public Int32 ObjectIdentityTableAddress;

            public Int32 TabulationTableLengthA;

            public Int32 TabulationTableLengthB;

            public Int32 TabulationTableLengthC;

            public Int32 TabulationTableLengthD;

            public Int32 TabulationTableAddressA;

            public Int32 TabulationTableAddressB;

            public Int32 TabulationTableAddressC;

            public Int32 TabulationTableAddressD;


            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(ContributeModuleWriteCycle) + ' ' + "::" + ' ' + nameof(FunctionHeader) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderSize) + ':' + ' ' + HeaderSize,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(ObjectIdentityTableLength) + ':' + ' ' + ObjectIdentityTableLength,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(ObjectIdentityTableAddress) + ':' + ' ' + ObjectIdentityTableAddress,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(TabulationTableLengthA) + ':' + ' ' + TabulationTableLengthA,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(TabulationTableLengthB) + ':' + ' ' + TabulationTableLengthB,
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(TabulationTableLengthC) + ':' + ' ' + TabulationTableLengthC,
                    String.Empty + '\t' + '~' + "07" + ' ' + nameof(TabulationTableLengthD) + ':' + ' ' + TabulationTableLengthD,
                    String.Empty + '\t' + '~' + "08" + ' ' + nameof(TabulationTableAddressA) + ':' + ' ' + TabulationTableAddressA,
                    String.Empty + '\t' + '~' + "09" + ' ' + nameof(TabulationTableAddressB) + ':' + ' ' + TabulationTableAddressB,
                    String.Empty + '\t' + '~' + "10" + ' ' + nameof(TabulationTableAddressC) + ':' + ' ' + TabulationTableAddressC,
                    String.Empty + '\t' + '~' + "11" + ' ' + nameof(TabulationTableAddressD) + ':' + ' ' + TabulationTableAddressD,
                    String.Empty + '}'
                });
            }
        }
    }
}

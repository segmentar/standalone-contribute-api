using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleReadIO
    {
        [ContributeIntentionalShortClass]
        public partial struct FunctionA
        {
            public Int32 Order;

            public Int32 RegionStart;

            public Int32 RegionEnd;

            public String Indexer;

            public Int32 Ordinal;

            public String Type;

            public String Name;

            public String Value;

            public Byte[] ByteArray;

            public Object ObjectIdentity;


            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(ContributeModuleReadIO) + ' ' + "::" + ' ' + nameof(FunctionA) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Order) + ':' + ' ' + Order,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(RegionStart) + ':' + ' ' + RegionStart,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(RegionEnd) + ':' + ' ' + RegionEnd,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(Indexer) + ':' + ' ' + Indexer,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(Order) + ':' + ' ' + Order,
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(Type) + ':' + ' ' + Type,
                    String.Empty + '\t' + '~' + "07" + ' ' + nameof(Name) + ':' + ' ' + Name,
                    String.Empty + '\t' + '~' + "08" + ' ' + nameof(Value) + ':' + ' ' + Value,
                    String.Empty + '\t' + '~' + "09" + ' ' + nameof(ByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ByteArray.Length}>",
                    String.Empty + '\t' + '~' + "10" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ByteArray) + ':',
                    String.Empty + BitConverter.ToString((ByteArray == default) ? new Byte[0] : ByteArray),
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(ObjectIdentity) + ':',
                    String.Empty + ObjectIdentity
                });
            }
        }
    }
}

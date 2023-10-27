using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        [ContributeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Contribute) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(TabulationType) + ':' + ' ' + TabulationType,
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Indexer) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Indexer) + ':' + ' ' + $"<safe><<{Indexer.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Ordinal) + ':' + ' ' + Ordinal,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Type) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Type) + ':' + ' ' + $"<safe><<{Type.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Name) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(Name) + ':' + ' ' + $"<safe><<{Name.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(Value) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Value) + ':' + ' ' + $"<safe><<{Value.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(ByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ByteArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ByteArray) + ':',
                String.Empty + BitConverter.ToString((ByteArray == default) ? new Byte[0] : ByteArray)
            });
        }
    }
}

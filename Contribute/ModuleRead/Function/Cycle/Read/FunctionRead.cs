using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleReadIO
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionRead
        {
            public FileStream FileStream;

            public Byte[] ByteArray;

            public Int32 Read;

            public FunctionRead(FileStream fileStream, Byte[] byteArray, Int32 read)
            {
                this.FileStream = fileStream;

                this.ByteArray = byteArray;

                this.Read = read;

                return;
            }

            ~FunctionRead()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionRead) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(ByteArray) + ':' + ' ' + ". . . . ." + ' ' + $"<{ByteArray.Length}>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(Read) + ':' + ' ' + Read,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "01" + ' ' + nameof(FileStream) + ':',
                    String.Empty + FileStream,
                    String.Empty,
                    String.Empty + '~' + "02" + ' ' + nameof(ByteArray) + ':',
                    String.Empty + BitConverter.ToString(ByteArray)
                });
            }
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.Text;

    using System.Collections;

    public partial class Contribute
    {
        public static Encoding WriterEncoding = Encoding.Default;

        public static Encoding ReaderEncoding = Encoding.Default;

        public static Int32 BoundaryStart = 3000;

        public static Int32 BoundarySize = 300;

        public static ArrayList ContributeArrayList = new ArrayList();

        public Contribute()
        {
            return;
        }

        ~Contribute()
        {
            return;
        }
    }
}

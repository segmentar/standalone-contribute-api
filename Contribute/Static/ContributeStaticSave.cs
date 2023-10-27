using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Linq;

    using System.Collections;

    public partial class Contribute
    {
        public static void Save(String item_PATH)
        {
            if (File.Exists(item_PATH) is true)
            {
                File.Delete(item_PATH);
            }
            else
                "false".ToString();

            IEnumerable enumerable;

            enumerable = ContributeArrayList.OfType<Contribute>().Cast<Contribute>().ToArray();

            var reflect = (Contribute[])(enumerable as Array);

            Contribute[] contributeArray;

            contributeArray = reflect;

            ContributeModuleWrite contributeModuleWrite = ContributeModuleWrite.ContributeModuleAction(contributeArray, true);

            FileStream fileStream;

            fileStream = File.Create(item_PATH);

            using (fileStream)
            {
                Byte[] byteArray;

                byteArray = contributeModuleWrite.MemoryStream.ToArray();

                fileStream.Write(byteArray, 0, byteArray.Length);

                fileStream.Flush();

                fileStream.Close();

                fileStream.Dispose();
            }

            return;
        }
    }
}

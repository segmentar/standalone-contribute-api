using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Contribute
    {
        public static Contribute[] Load(String Path_ITEM)
        {
            Contribute[] arrayResult = default;

            if (File.Exists(Path_ITEM) is false)
            {
                return arrayResult;
            }
            else
                "false".ToString();

            FileStream fileStream;

            fileStream = File.OpenRead(Path_ITEM);

            using (fileStream)
            {
                ContributeModuleRead contributeModuleRead = ContributeModuleRead.ContributeModuleAction(fileStream, true);

                arrayResult = new Contribute[0];

                fileStream.Close();

                fileStream.Dispose();
            }

            return arrayResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Contribute
    {
        public static String SolidRenderBuildName(String[] Split_ARRAY, Boolean answer_CREATE_should)
        {
            String stringResult = default;

            var path = String.Empty;

            foreach (String Split_ITEM in Split_ARRAY)
            {
                path = Path.Combine(path, Split_ITEM);

                continue;
            }

            var path_DIRECTORY_full_name = path;

            var boolean_CREATE_should = true;

            boolean_CREATE_should = boolean_CREATE_should && answer_CREATE_should is true;

            boolean_CREATE_should = boolean_CREATE_should && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean shouldCreateCheck;

            shouldCreateCheck = boolean_CREATE_should is true;

            if (shouldCreateCheck is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}

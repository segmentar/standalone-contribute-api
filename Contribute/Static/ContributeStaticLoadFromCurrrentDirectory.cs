using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Contribute
    {
        public static Contribute[] LoadFromCurrentDirectory(String Name_ITEM)
        {
            Contribute[] arrayResult = default;

            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(CurrentDirectory__PATH, Name_ITEM);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ContributeDefault.ContributeExtension);

            arrayResult = Load(path_FILE_filename_with_extension);

            return arrayResult;
        }
    }
}

using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Contribute
    {
        public static void SaveToCurrentDirectory(String item_NAME)
        {
            var path__CURRENT_DIRECTORY = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(path__CURRENT_DIRECTORY, item_NAME);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, ContributeDefault.ContributeExtension);

            Save(path_FILE_filename_with_extension);

            return;
        }
    }
}

using System;
using System.IO;

namespace HotelSOL
{
    public static class FilePaths
    {
        private static readonly string BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),"Hotel", "Mapping");

        public static string GetFilePath(string fileName)
        {
            return Path.Combine(BasePath, fileName);
        }
    }
}

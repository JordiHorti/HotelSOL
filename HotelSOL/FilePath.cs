using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HotelSOL
{
    public static class FilePaths
    {
        private static readonly string BasePath = Path.Combine("C:", "Users", Environment.UserName, "source", "repos", "HotelSOL", "HotelSOL", "Mapping");

        public static string GetFilePath(string fileName)
        {
            return Path.Combine(BasePath, fileName);
        }
    }
}

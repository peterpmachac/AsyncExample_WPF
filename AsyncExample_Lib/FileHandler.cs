using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncExample_Lib
{
    public class FileHandler
    {

        public static List<string> GetUrls(string url_file_path)
        {
            var urls = File.ReadAllLines(url_file_path);
            return urls.Where(s => !s.StartsWith("'")).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp
{
    public class Copy
    {
        string sourcePath = "";
        string targetPath = "";
        public void FlagParser(List<string> flags, List<string> paths)
        {
            if (flags.Count > 1)
            {
                if (flags[0] == "-")
                {
                    Console.WriteLine("Something something file flag");
                }
            }
            else
            {
                sourcePath = Convert.ToString(paths[0]);
                targetPath = Convert.ToString(paths[1]);
                FileMover(sourcePath, targetPath);
            }
        }
        public void FileMover(string sourcePath, string targetPath)
        {
            if (Directory.Exists(sourcePath) & Directory.Exists(targetPath)) 
            {
                Console.WriteLine(sourcePath);
                Console.WriteLine(targetPath);
            }
            else if (!Directory.Exists(sourcePath))
            {
                Console.WriteLine("Source path doesn't exist");
            }
            else if (!Directory.Exists(targetPath))
            {
                Console.WriteLine("Target path doesn't exist");
            }
        }
    }
}

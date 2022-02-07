using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp
{
    public class Copy
    {
        private string sourcePath = "";
        private string targetPath = "";
        private bool overwritePerm = false;
        List<string> lastStringOfPath = new List<string>();
        public void FlagParser(List<string> flags, List<string> paths)
        {
            if (flags.Count > 1)
            {
                if (flags[0] == "-o")
                {
                    Console.WriteLine("Overwrite file = true");
                    overwritePerm = true;
                }
            }
            else
            {
                sourcePath = Convert.ToString(paths[0]);
                targetPath = Convert.ToString(paths[1]);
                int indexOfBackslash = sourcePath.LastIndexOf('\\');
                lastStringOfPath.Add(sourcePath.Substring(indexOfBackslash + 1, sourcePath.Length - indexOfBackslash - 1));
                foreach(string path in lastStringOfPath)
                {
                    Console.WriteLine(path);
                    targetPath += path;
                }
                FileMover(sourcePath, targetPath, overwritePerm);
            }
        }

        public void FileMover(string sourcePath, string targetPath, bool overwritePerm)
        {
            if (File.Exists(sourcePath) & !File.Exists(targetPath)) 
            {
                Console.WriteLine(sourcePath);
                Console.WriteLine(targetPath);
                File.Copy(sourcePath, targetPath, overwritePerm);
            }
        }
    }
}

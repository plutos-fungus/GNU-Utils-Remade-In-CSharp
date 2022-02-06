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
                overwritePerm = false;
                sourcePath = Convert.ToString(paths[0]);
                targetPath = Convert.ToString(paths[1]);
                int indexOfBackslash = sourcePath.LastIndexOf('\\');
                foreach(char s in sourcePath)
                {
                    if (sourcePath.Length != indexOfBackslash)
                    {
                        Console.WriteLine("!=");
                    }
                    else
                    {
                        Console.WriteLine(s);
                    }
                }
                //FileMover(sourcePath, targetPath, perm);
                //FileMover(@"C:\Users\Rasmus\Desktop\folder_1\New Text Document.txt", @"C:\Users\Rasmus\Desktop\New Text Document.txt", overwritePerm);
            }
        }

        public void FileMover(string sourcePath, string targetPath, bool perm)
        {
            if (File.Exists(sourcePath) & !File.Exists(targetPath)) 
            {
                Console.WriteLine(sourcePath);
                Console.WriteLine(targetPath);
                //File.Copy(sourcePath, targetPath, perm);
            }
        }
    }
}

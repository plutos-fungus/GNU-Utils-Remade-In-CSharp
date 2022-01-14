using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ls
{
    public class Lister
    {
        public void FileList(string x)
        {
            DirectoryInfo info = new DirectoryInfo(x);
            
            string[] files = Directory.GetFileSystemEntries(x);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            
        }
        public void DirectoryList(string x)
        {
            string[] dirs = Directory.GetDirectories(x, "*", SearchOption.TopDirectoryOnly);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
        }
        public void FlagParser(string x)
        {
            Console.WriteLine("hej");
        }
    }
}

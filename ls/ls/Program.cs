using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ls
{
    class ls
    {
        static void Main(string[] args)
        {
            int fileFlag = 0;
            string fileName;
            Lister lister = new Lister();
            foreach (string str in args)
            {
                if (str.StartsWith('-'))
                {
                    // Do things;
                    //flagParser(str)???
                    //Console.WriteLine("hej");
                    foreach(string str2 in str.Split('-'))
                    {
                        fileFlag++;
                        Console.WriteLine(fileFlag);
                    }
                }
                else
                {
                    fileName = str;
                    Console.WriteLine(str);
                    //fileFlag++;
                    Console.WriteLine("=============================================");
                    lister.FileList(str);
                    Console.WriteLine("=============================================");
                    lister.DirectoryList(str);
                    
                }
                //if (fileFlag > 1)
                //{
                //    Console.WriteLine("Only one directory at a time");
                //}
            }
        }
    }
}
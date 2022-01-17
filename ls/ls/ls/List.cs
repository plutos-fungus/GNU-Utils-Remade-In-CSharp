﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ls
{
    public class Lister
    {
        // Parse and manage all the flags
        public void FlagParser(List<string> x, string y)
        {
            if(x.Count > 1)
            {
                if (x[0] == "-d" & x[1] == "-a")
                {
                    Console.WriteLine("Sorry, the flag combination {0} {1} is not possible", x[0], x[1]);
                }
                else if (x[0] == "-d" & x[1] == "-b")
                {
                    Console.WriteLine("Sorry, the flag combination {0} {1} is not possible", x[0], x[1]);
                }
                else if (x[0] == "-a" & x[1] == "-t")
                {
                    FileTime(y);
                }
                else if (x[0] == "-d" & x[1] == "-t")
                {
                    DirectoryTime(y);
                }
            }
            else if (x[0] == "-d")
            {
                DirectoryList(y);
            }
            
            else if (x[0] == "-a")
            {
                FileList(y);
            }
            else if (x[0] == "-h")
            {
                GetHelp();
            }
        }

        // List ALL entries in the directory \\
        public void FileList(string x)
        {
            string[] files = Directory.GetFileSystemEntries(x);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
        }
        // List only the directories
        public void DirectoryList(string x)
        {
            string[] dirs = Directory.GetDirectories(x, "*", SearchOption.TopDirectoryOnly);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
        }
        public void FileTime(string x)
        {
            FileInfo info = new FileInfo(x);
            DateTime time = info.CreationTime;
            Console.WriteLine(time);
        }
        public void DirectoryTime(string x)
        {
            DirectoryInfo info = new DirectoryInfo(x);
            DateTime time = info.CreationTime;
            Console.WriteLine(time);
        }
        public void GetHelp()
        {
            Console.WriteLine("-a:          List all enties. Including hidden files.");
            Console.WriteLine("             Used with -t, print the time of creation of a signle" +
                "                           file");
            Console.WriteLine("");
            Console.WriteLine("-d:          List all directories. Including hidden directories.");
            Console.WriteLine("             Used with -t, print the time of creation of a signle" +
                "                           directory");
            Console.WriteLine("");
        }
    }
}

﻿using System;
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
            List<string> flagList = new List<string>();
            foreach (string str in args)
            {
                if (str.StartsWith('-'))
                {
                    fileFlag++;
                    flagList.Add(str);
                }
                else
                {
                    fileName = str;
                    lister.FlagParser(flagList, fileName);
                }
                //if (fileFlag > 1)
                //{
                //    Console.WriteLine("Only one directory at a time");
                //}
            }
        }
    }
}
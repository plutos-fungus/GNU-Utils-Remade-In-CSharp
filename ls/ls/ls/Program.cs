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
            string filePath;
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


                    filePath = str;
                    lister.FlagParser(flagList, filePath);
                }
            }
        }
    }
}
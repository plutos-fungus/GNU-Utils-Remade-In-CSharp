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
        public void FlagParser(List<string> x, List<string> y)
        {
            if (x.Count > 1)
            {
                if (x[0] == "-")
                {
                    Console.WriteLine("Something something file flag");
                }
            }
            else
            {
                sourcePath = Convert.ToString(y[0]);
                targetPath = Convert.ToString(y[1]);
                Console.WriteLine(sourcePath);
                Console.WriteLine(targetPath);
            }
        }
    }
}

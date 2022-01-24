namespace cp
{
    class cp
    {
        static void Main(string[] args)
        {
            Copy copy = new Copy();
            List<string> pathList = new List<string>();
            List<string> flagList = new List<string>();
            foreach (string str in args)
            {
                if (str.StartsWith('-'))
                {
                    flagList.Add(str);
                }
                else if (!str.StartsWith('-'))
                {
                    Console.WriteLine(str);
                    pathList.Add(str);
                }
            }
            copy.FlagParser(flagList, pathList);
        }
    }
}
using System;
using System.IO;
class OddLines
{
    static void Main(string[] args)
    {
        bool odd = true;
        StreamReader fileContent = new StreamReader("../../FileForEverything.txt");
        using (fileContent)
        {
            string line;
            while ((line = fileContent.ReadLine()) != null)
            {
                odd = !odd;
                if (odd)
                {
                    
                    continue;
                }
                Console.WriteLine(line);
            }
        }
    }
}


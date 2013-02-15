using System;
using System.Collections.Generic;
using System.IO;

class RemovingOddLines
{
    static void Main(string[] args)
    {
        string fileInputPath = "../../file.txt";
        StreamReader readFile = new StreamReader(fileInputPath);
        List<string> oddLines = new List<string>();
        using (readFile)
        {
            bool odd = true;
            string line;
            while ((line = readFile.ReadLine()) != null)
            {
                odd = !odd;
                if (!odd)
                {
                    continue;
                }
                oddLines.Add(line);
            }
        }
        StreamWriter resultFile = new StreamWriter(fileInputPath);
        using (resultFile)
        {
            foreach (string line in oddLines)
            {
                resultFile.WriteLine(line);
            }
        }
    }
}

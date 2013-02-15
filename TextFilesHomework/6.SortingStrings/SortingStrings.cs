using System;
using System.Collections.Generic;
using System.IO;

class SortingStrings
{
    static void Main(string[] args)
    {
        string inputFilePath = "../../strings.txt";
        string outputFilePath = "../../result.txt";
        StreamReader file = new StreamReader(inputFilePath);
        using (file)
        {
            StreamWriter outputFile = new StreamWriter(outputFilePath);
            using (outputFile)
            {
                string line;
                List<string> lines = new List<string>();
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.Sort();
                for (int i = 0; i < lines.Count; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
            }
        }
    }
}


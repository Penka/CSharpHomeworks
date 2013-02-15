using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWords
{
    static void Main(string[] args)
    {
        string inputFilePath = "../../file.txt";
        string outputFilePath = "../../output.txt";
        StreamReader input = new StreamReader(inputFilePath);
        using (input)
        {
            StreamWriter output = new StreamWriter(outputFilePath);
            using (output)
            {
                string line;
                while((line = input.ReadLine()) != null)
                {
                    string outputLine = Regex.Replace(line, @"\btest\w*\b", String.Empty);
                    output.WriteLine(outputLine);
                }
            }
        }
    }
}


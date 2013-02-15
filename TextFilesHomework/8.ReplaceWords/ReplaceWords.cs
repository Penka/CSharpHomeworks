using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWords
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
                while ((line = input.ReadLine()) != null)
                {
                    string result = Regex.Replace(line, @"\bstart\b", "finish");
                    output.WriteLine(result);
                }
            }
        }
    }
}

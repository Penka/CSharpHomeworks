using System;
using System.IO;

class ReplaceSubstring
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
                    string result = line.Replace("start", "finish");
                    output.WriteLine(result);
                }
            }
        }
    }
}

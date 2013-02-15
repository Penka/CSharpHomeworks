using System;
using System.IO;
class LineNumbers
{
    static void Main(string[] args)
    {
        string inputFilePath = "../../LineNumbers.cs";
        string outputFilePath = "../../LineNumbers.txt";
        StreamReader inputFile = new StreamReader(inputFilePath);
        using (inputFile)
        {
            StreamWriter outputFile = new StreamWriter(outputFilePath);
            using (outputFile)
            {
                int lineNumber = 1;
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    outputFile.WriteLine(lineNumber + ". " + line);
                    lineNumber++;
                }
            }
        }

    }
}


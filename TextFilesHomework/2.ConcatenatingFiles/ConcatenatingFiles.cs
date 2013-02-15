using System;
using System.IO;
class ConcatenatingFiles
{
    static void Main(string[] args)
    {
        string outputFilePath = "../../outputFile.txt";
        StreamWriter outputFile = new StreamWriter(outputFilePath, true);
        string[] inputFilesPath = new string[] {"../../ConcatenatingFiles.cs", "../../ConcatenatingFiles.cs"};
        using (outputFile)
        {
            foreach (string file in inputFilesPath)
            {
                StreamReader fileInput = new StreamReader(file);
                using (fileInput)
                {
                    string line;
                    while ((line = fileInput.ReadLine()) != null)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
        }

    }
}


using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class DeleteWords
{
    static void Main(string[] args)
    {
        try
        {
            string[] words = File.ReadAllLines("../../WordsToDelete.txt");
            string regularExpression = String.Join("|", words);
            string inputFilePath = "../../DeleteWords.cs";
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
                        string outputLine = Regex.Replace(line, @"\b(" + regularExpression + @")\b", String.Empty);
                        output.WriteLine(outputLine);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory was not found!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The entered file path is too long!");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("The user doesn't have the necessary permissions!");
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}


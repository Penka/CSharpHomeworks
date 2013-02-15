using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;

class CountingWords
{
    static void Main(string[] args)
    {
        try
        {

            string inputFilePath = "../../words.txt";
            string outputFilePath = "../../result.txt";
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string[] testWords = File.ReadAllLines("../../test.txt");
            foreach (var word in testWords)
            {
                wordsCount.Add(word, 0);
            }
            StreamReader input = new StreamReader(inputFilePath);

            using (input)
            {
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    foreach (var word in testWords)
                    {
                        int count = Regex.Matches(line, @"\b" + word + @"\b").Count;
                        wordsCount[word] = wordsCount[word] + count;
                    }
                }
            }
            KeyValuePair<string, int>[] result = wordsCount.ToArray();
            Array.Sort<KeyValuePair<string, int>>(result, (a, b) => a.Value.CompareTo(b.Value));

            StreamWriter output = new StreamWriter(outputFilePath);
            using (output)
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    output.WriteLine("{0} {1}", result[i].Key, result[i].Value);
                    //Console.WriteLine("word {0} count {1}", result[i].Key, result[i].Value);
                }
            }
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

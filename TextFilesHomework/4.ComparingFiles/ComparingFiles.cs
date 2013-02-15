using System;
using System.IO;
class ComparingFiles
{
    static void Main(string[] args)
    {
        string inputFilePath1 = "../../file1.txt";
        string inputFilePath2 = "../../file2.txt";
        StreamReader file1 = new StreamReader(inputFilePath1);
        using (file1)
        {
            StreamReader file2 = new StreamReader(inputFilePath2);
            using (file2)
            {
                int equalLines = 0;
                int differentLines = 0;
                string line1;
                string line2;
                while((line1 = file1.ReadLine()) != null)
                {
                    line2 = file2.ReadLine();
                    if (line1.CompareTo(line2) == 0)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
                Console.WriteLine("The number of equal lines is {0}", equalLines);
                Console.WriteLine("The number of different lines is {0}", differentLines);
            }
        }
    }
}

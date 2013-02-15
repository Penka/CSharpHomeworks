using System;
using System.IO;
using System.Text;

class ExtractText
{
    static void Main(string[] args)
    {
        string inputFilePath = "../../file.xml";
        StreamReader reader = new StreamReader(inputFilePath);
        StringBuilder result = new StringBuilder();
        using (reader)
        {
            int ch;
            while ((ch = reader.Read()) != -1)
            {
                if ((char)ch == '>')
                {
                    while ((ch = reader.Read()) != -1 && (char)ch != '<')
                    {
                        result.Append((char)ch);
                    }
                }
            }
        }
        Console.WriteLine(result.ToString());
    }
}

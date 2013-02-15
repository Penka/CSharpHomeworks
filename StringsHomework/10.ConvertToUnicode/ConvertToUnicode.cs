using System;
using System.Text;

class ConvertToUnicode
{
    static void Main(string[] args)
    {
        string str = "Hi!";
        string s = "\\u";

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            sb.Append(s);
            sb.AppendFormat("{0:X4}", (int)str[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}

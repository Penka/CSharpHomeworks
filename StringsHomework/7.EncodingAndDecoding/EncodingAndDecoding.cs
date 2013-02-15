using System;
using System.Text;

class EncodingAndDecoding
{
    static string Encode(string str, string code)
    {
        int codeLength = code.Length;
        StringBuilder sb = new StringBuilder();
        int stringLength = str.Length;
        for (int i = 0; i < stringLength; i++)
        {
            sb.Append((char)(str[i] ^ code[i % codeLength]));
        }
        return sb.ToString();
    }

    static string Decode(string str, string code)
    {
        return Encode(str, code);
    }

    static void Main(string[] args)
    {
        string code = "veryhardcodingalgorithm";
        string str = "Write a program that encodes and decodes a string using given encryption key (cipher).";
        string encoded = Encode(str, code);
        Console.WriteLine(encoded);

        string decoded = Decode(encoded, code);
        Console.WriteLine(decoded);

        
    }
}


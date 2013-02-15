using System;
class BinaryToHex
{
    static string HexValue(string str)
    {
        string result = "";
        switch (str)
        {
            case "0000": result = "0"; break;
            case "0001": result = "1"; break;
            case "0010": result = "2"; break;
            case "0011": result = "3"; break;
            case "0100": result = "4"; break;
            case "0101": result = "5"; break;
            case "0110": result = "6"; break;
            case "0111": result = "7"; break;
            case "1000": result = "8"; break;
            case "1001": result = "9"; break;
            case "1010": result = "A"; break;
            case "1011": result = "B"; break;
            case "1100": result = "C"; break;
            case "1101": result = "D"; break;
            case "1110": result = "E"; break;
            case "1111": result = "F"; break;
        }
        return result;
    }

    static void Main(string[] args)
    {
        string binary = "101011110001";
        string hex = "";
        for (int i = 0; i < binary.Length; i +=4)
        {
            string h = "";
            for (int j = 0; j < 4; j++)
			{
			    h = h + binary[i + j];
			}
            hex = hex + HexValue(h);
        }
        Console.WriteLine(hex);
    }
}


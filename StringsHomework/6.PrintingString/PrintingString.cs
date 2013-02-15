using System;
class PrintingString
{
    static void Main(string[] args)
    {
        int maxLength = 20;
        string str = Console.ReadLine();
        if (str.Length > 20)
        {
            Console.WriteLine("String too long!");
            return;
        }
        string asterisks = new string('*', maxLength - str.Length);
        str = str + asterisks;
        Console.WriteLine(str);
    }
}

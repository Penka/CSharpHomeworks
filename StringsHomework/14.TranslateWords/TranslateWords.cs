using System;
using System.Collections.Generic;

class TranslateWords
{
    /*.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes
*/
    static void Main(string[] args)
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add(".NET", "platform for applications from Microsoft");
        myDictionary.Add("CLR", "managed execution environment for .NET");
        myDictionary.Add("namespace", "hierarchical organization of classes");

        //string word = Console.ReadLine();
        string word = "CLR";

        string result = myDictionary[word];
        Console.WriteLine("{0} is {1}", word, result);
    }
}

using System;
using System.Collections.Generic;

class Strings
{
    static void Main(string[] args)
    {
        /// string == char[] with some differences
        /// string is immutable object
        /// we can concatenate two (or more) strings using + -> the result is new string
        /// 

        //most important functions:
        string str = "CSharp";
        int n = str.Length; //property

        char[] nums = str.ToCharArray();

        str.ToUpper();
        str.ToLower();

        int index = str.IndexOf("c");
        index = str.IndexOf("r", 2);
        index = str.LastIndexOf("c");

        string substring = str.Substring(2);
        substring = str.Substring(1, 2);

        string removed = str.Remove(0);
        removed = str.Remove(0, 2);

        string trim = str.Trim();

        str = "Hello CSharp";
        string[] words = str.Split(' ');

    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


class PHP
{

    static bool IsInQuotes(string str, int index)
    {
        char firstQuote = '0';
        for (int i = 0; i < index; i++)
        {
            if (str[i] == '\'')
            {
                firstQuote = str[i];
                int endIndex = str.IndexOf(firstQuote.ToString(), i + 1);
                if (endIndex != -1)
                {
                    if (index > i && index < endIndex)
                    {
                        return true;
                    }
                }
            }
            if (str[i] == '"')
            {
                firstQuote = str[i];
                int endIndex = str.IndexOf(firstQuote.ToString(), i + 1);
                if (endIndex != -1)
                {
                    if (index > i && index < endIndex)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        List<string> variables = new List<string>();
        input = Console.ReadLine();
        bool isInComment = false;
        bool isInQuotes = false;
        string pattern = @"([^\\]|^)\$\w+";
        while (input != "?>")
        {
            if (!isInComment)
            {
                int commentIndex = input.IndexOf("#");

                int index = input.IndexOf("//");
                if (index != -1)
                {
                    if (commentIndex != -1)
                    {
                        commentIndex = Math.Min(index, commentIndex);
                    }
                    else
                    {
                        commentIndex = index;
                    }
                }
                index = input.IndexOf("/*");
                if (index != -1)
                {
                    if (!IsInQuotes(input, index))
                    {
                        isInComment = true;
                        if (commentIndex != -1)
                        {
                            commentIndex = Math.Min(index, commentIndex);
                        }
                        else
                        {
                            commentIndex = index;
                        }

                        int endCommentIndex = input.IndexOf("*/");
                        if (endCommentIndex != -1)
                        {
                            isInComment = false;
                            MatchCollection m = Regex.Matches(input.Substring(endCommentIndex), pattern);
                            foreach (Match match in m)
                            {

                                string str = match.ToString();
                                if (str[0] == '$')
                                {
                                    str = str.Substring(1);
                                }
                                else
                                {
                                    str = str.Substring(2);
                                }
                                if (!variables.Contains(str))
                                {
                                    variables.Add(str);
                                }
                            }
                            MatchCollection escaped = Regex.Matches(input.Substring(endCommentIndex), @"\\\\\$\w+");
                            foreach (Match match in escaped)
                            {

                                string str = match.ToString();
                                if (str[0] == '$')
                                {
                                    str = str.Substring(1);
                                }
                                else
                                {
                                    str = str.Substring(3);
                                }
                                if (!variables.Contains(str))
                                {
                                    variables.Add(str);
                                }
                            }
                        }
                    }
                }
                if (commentIndex == -1)
                {
                    commentIndex = input.Length;
                }
                MatchCollection matches = Regex.Matches(input.Substring(0, commentIndex), pattern);
                foreach (Match match in matches)
                {
                    string str = match.ToString();
                    if (str[0] == '$')
                    {
                        str = str.Substring(1);
                    }
                    else
                    {
                        str = str.Substring(2);
                    }
                    if (!variables.Contains(str))
                    {
                        variables.Add(str);
                    }
                }
                MatchCollection matchesEscaped = Regex.Matches(input.Substring(0, commentIndex), @"\\\\\$\w+");
                foreach (Match match in matchesEscaped)
                {
                    string str = match.ToString();
                    if (str[0] == '$')
                    {
                        str = str.Substring(1);
                    }
                    else
                    {
                        str = str.Substring(3);
                    }
                    if (!variables.Contains(str))
                    {
                        variables.Add(str);
                    }
                }
            }
            else
            {
                int endCommentIndex = input.IndexOf("*/");
                if (endCommentIndex != -1)
                {
                    isInComment = false;
                    MatchCollection matches = Regex.Matches(input.Substring(endCommentIndex), pattern);
                    foreach (Match match in matches)
                    {
                        string str = match.ToString();
                        if (str[0] == '$')
                        {
                            str = str.Substring(1);
                        }
                        else
                        {
                            str = str.Substring(2);
                        }
                        if (!variables.Contains(str))
                        {
                            variables.Add(str);
                        }
                    }
                    MatchCollection matchesEscaped = Regex.Matches(input.Substring(endCommentIndex), @"\\\\\$\w+");
                    foreach (Match match in matchesEscaped)
                    {
                        string str = match.ToString();
                        if (str[0] == '$')
                        {
                            str = str.Substring(1);
                        }
                        else
                        {
                            str = str.Substring(3);
                        }
                        if (!variables.Contains(str))
                        {
                            variables.Add(str);
                        }
                    }

                }

            }
            input = Console.ReadLine();
        }

        string[] vars = new string[variables.Count];
        Console.WriteLine(variables.Count);
        for (int i = 0; i < variables.Count; i++)
        {
            vars[i] = variables[i];
        }
        Array.Sort(vars, StringComparer.Ordinal);
        for (int i = 0; i < vars.Length; i++)
        {
            Console.WriteLine(vars[i]);
        }
    }
}


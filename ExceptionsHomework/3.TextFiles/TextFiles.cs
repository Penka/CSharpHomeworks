using System;
using System.IO;
using System.Linq;
using System.Security;

class TextFiles
{
    static void Main(string[] args)
    {
        try
        {
            string inputPath = Console.ReadLine();
            string outputContent = ReadFile(inputPath);
            Console.WriteLine(outputContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The input path is null!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory was not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Ocurred I/O error while trying to open the file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The user doesn't have the necessary permissions!");
        }

        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in invalid format!");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The user doesn't have the necessary permissions!");
        }
    }
    static string ReadFile(string path)
    {
        string fileContent = System.IO.File.ReadAllText(path);
        return fileContent;
    }
}


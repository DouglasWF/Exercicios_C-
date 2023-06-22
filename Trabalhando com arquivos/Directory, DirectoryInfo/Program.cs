using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

public class Course
{
    public static void Main()
    {
        string path = @"c:\tempo\myfolder";

        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            foreach (string s in folders)
            {
                Console.WriteLine(s);
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

            Directory.CreateDirectory(path + "\\newfolder");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}

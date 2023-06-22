using System;
using System.Globalization;
using System.IO;

public class Course
{    
    public static void Main()
    {
        string sourcePath = @"c:\tempo\file1.txt";
        string targetPath = @"c:\tempo\file2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath)) {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}

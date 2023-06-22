﻿using System;
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
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e) 
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}

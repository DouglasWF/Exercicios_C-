﻿using System;
using System.Globalization;
using System.IO;

public class Course
{
    public static void Main()
    {
        string path = @"c:\tempo\file1.txt";
        
        StreamReader sr = null;

        try
        {
            
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error accurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            
        }
    }
}

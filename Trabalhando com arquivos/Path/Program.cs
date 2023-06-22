using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

public class Course
{
    public static void Main()
    {
        string path = @"c:\tempo\myfolder\file1.txt";


        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
        Console.WriteLine("GetTempPath" + Path.GetTempPath());
    }
        
}

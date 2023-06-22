using System;
using System.Globalization;
using System.IO;

public class Course
{
    public static void Main()
    {
        string path = @"c:\tempo\file1.txt";
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);

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
            if (fs != null) fs.Close();
        }
    }
}

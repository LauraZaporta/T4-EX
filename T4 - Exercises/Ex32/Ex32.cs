using System;
using System.IO;
public class EX32
{
    public static void Done()
    {
        string path = @"C:\Users\isard\Source\Repos\T4-EX\T4 - Exercises\Ex32\notes.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
using System;
using System.IO;

namespace 13.Exemplo.06
{
    public class Program
    {
        static void Main(string[] arg)
        {
            string path = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/06/file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryNam(path) );
            Console.WriteLine("GetFileName: " + Path.GetDirectoryName(path) );
            Console.WriteLine("GetExtension: " + Path.GetExtension(path) );
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path) );
            Console.WriteLine("GetFullPath: " + Path.GetFullTime(path) );
            Console.WriteLine("GetTempPath: " + Path.GetTempTime(path) );
        }
    }
}
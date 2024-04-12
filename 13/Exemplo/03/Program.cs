using System;
using System.IO;

namespace 13.Exemplo.03
{
    public class Program
    {
        string path = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/03/File1.txt";
        using (FileStream fs = new FileStream(path, FileMode.Open;) )
        {
            using (StreamReader sr = new StreamReader(fs) )
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
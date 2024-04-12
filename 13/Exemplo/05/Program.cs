using System;
using System.IO;
using System.Collections.Generic;

namespace 13.Exemplo.05
{
    public class Program
    {
        static void Main(string[] arg)
        {
            string path = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/05/myFolder";
            try
            {
                IEnumerable<string> | folder = Directory.EnumarateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Collections.WriteLine(s);
                }

                IEnumerable<string> | files = Directory.EnumarateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Collections.WriteLine(s);
                }

                Directory.CreateDirectory(path, + "\\newfolder");
            
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
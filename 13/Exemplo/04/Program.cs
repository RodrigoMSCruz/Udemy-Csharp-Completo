using System;
using System.IO;

namespace 13.Exemplo.04
{
    public class Program
    {
        static void Main(string[] arg)
        {
            string sourcePath = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/04/File1.txt";
            string targetPath = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/04/File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath) )
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper() );
                    }
                }
            }
            catch(IOExpression e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }

}
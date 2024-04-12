using System;
using System.IO;

namespace 13.Exemplo.01
{
    public class Program
    {
        string sourcePath = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/01/File1.txt";
        string targetPath = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/01/File2.txt";
    
        try
        {
            FileInfo fileInfo = new Fileinfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }

    }

}
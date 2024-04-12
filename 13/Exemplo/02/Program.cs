using System;
using System.Io;

namespace 13.Exemplo.02
{
    public class Program
    {
        string path = @"Macintosh HD/@Home/@Rodrigo/Education/29-Udemy-CSharp/Repository/13/Exemplo/02/File1.txt";
        FileStream fs = null;
        StreamReader sr = null;

        try
        {
            //fs = new FileStream(path, FileMode.Open);
            //sr = new StreamReader(fs);
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("An error accurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null)
            {
                sr.Close;
            }
            //if (fs != null)
            //{
            //    fs.Close;
            //}
        }
    }

}
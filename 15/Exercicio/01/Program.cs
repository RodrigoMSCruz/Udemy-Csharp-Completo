using System;
using System.IO;
using 15.Exercicio.01.Entities;

namespace 15.Exercicio.01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path) );
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.parse(line[1] );

                        set.Add(new LogRecord {Username = name, Instant = instant} );
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
    }

}
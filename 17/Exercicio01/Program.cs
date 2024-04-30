using System;
using 17.Exercicio01.Entities;
using System.IO;
using System.Globalization.
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 17.Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path) )
            {
                while (!sr.EndOfFile)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price) );
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture) );

            var names = list.Where(p = p.price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
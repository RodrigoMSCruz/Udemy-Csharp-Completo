using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 03.Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
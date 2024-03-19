using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 03.Lista02.Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        
        }
    }
}
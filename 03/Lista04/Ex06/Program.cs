using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 03.Lista04.Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    
    }
}
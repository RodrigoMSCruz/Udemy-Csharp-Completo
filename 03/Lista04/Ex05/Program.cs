using System;

namespace 03.Lista04.Ex05
{
   class Program
   {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }

}
using System;

namespace 15.Exemplo.01
{
    public class Program
    {
        public void main(string[] arg)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine() );

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine() );
                printService.Add(x);
            }

            printService.print();

            Console.WriteLine("First: " + prinService.First() );

        }
    }
}
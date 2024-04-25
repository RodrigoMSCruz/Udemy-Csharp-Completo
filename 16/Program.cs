using System;
using 16.Extensions;

namespace 16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime() );

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10) );
        }
    }
}
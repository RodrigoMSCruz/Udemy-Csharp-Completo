using System;
using System.Collections.Generic;

namespace 15.Exemplo.03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sortedset<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectionWith(b);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> Collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
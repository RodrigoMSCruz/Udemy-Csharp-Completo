using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 10.Exercicio.01.Entities;

namespace 10.Exercicio.01
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees:  ")
            int n = int.parse( Console.ReadLine() );

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:")
                Console.Write("Outsorced (y/n)? ")
                char ch = char.Parse( Console.ReadLine() );
                Console.Write("Name: ");
                string name = Console.WriteLine();
                Console.Write("Hours: ")
                int hours = int.Parse( Console.ReadLine() );
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
                    list.Add( new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge) );
                }
                else
                {
                    list.Add( new Employee(name, hours, valuePerHour) );
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture) );
            }
        }
    }
}
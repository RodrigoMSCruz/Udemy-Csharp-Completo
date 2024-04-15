using System;
using System.Globalization;
using 14.Exemplo.Entities;

namespace 14.Exemplo
{
    public class Program
    {
         static void (string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model:");
            string model = console.ReadLine();
            
            Console.WriteLine("Pickup (dd/MM/yy hh:ss): ");
            DateTime start = DateTime.PartseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.PartseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model) );
        }
    }
}
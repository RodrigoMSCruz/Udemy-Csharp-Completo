using System;
using System.Globalization;
using 14.Exemplo.Entities;
using 14.Exemplo.Services;

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

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            CarRental carRental = new CarRental(start, finish, new Vehicle(model) );

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService() );

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
using System;
using 01.Entities;

namespace 11.Exemplo.01
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Room number: ");
            int numeber = int.parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy):");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy):");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after than check-in.");
            }
            else
            {
                Reservation rservation = new Reservation(numeber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime Now;
                if(checkIn < now || checkOut < now)
                {
                    ConsoleWriteLine("Error in reservation: Reservation dates for update must be future date");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservtion: Check-out date must ");
                }
                else
                {
                    reservation.Updates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
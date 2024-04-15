using System;
using 14.Exemplo.Entities;

namespace 14.Exemplo.Services
{
    public class RentalServices
    {
        public double PricePerHour { get; private set;}
        public double PricePerDay { get; private set;}
    
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }


        public void ProcessInvoice (CarRental carRental)
        {
            
        }
    }
}
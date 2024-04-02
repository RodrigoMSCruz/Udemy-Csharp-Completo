using System;
using 11.Exemplo.01.Entities.Exceptions

namespace 11.Exemplo.01.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public ateTime CheckOut { get; set; }
    
    public Reservation()
    {

    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException( "Check-out date must be after check-in" )
        }
        
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int) duration.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime Now;
        if(checkIn < now || checkOut < now)
        {
            throw new DomainException( "Reservation dates for update must be future date" );
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException( "Error in reservation: Check-out date must " );
        }

        CheckIn = checkIn;
        CheckOut = checkOut;

    }
    public override string ToString()
    {
        return "Room "
        + ", check-in: "
        + CheckIn.ToString("dd/MM/yyyy")
        + ", check-out: "
        + CheckOut.ToString("dd/MM/yyyy")
        + ","
        + Duration()
        + " nights"
    }
    
    }
}
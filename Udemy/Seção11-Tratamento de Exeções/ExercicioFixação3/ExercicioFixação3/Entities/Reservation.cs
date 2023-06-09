using System;
using ExercicioFixação3.Entities.Exceptions;

namespace ExercicioFixação3.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must ahead of Check-in date");
            }
        }

        public int Duration()
        {

            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Error in reservation: Reservation dates for update must be future dates");

            }
            if (checkOut <= checkIn)
            {
                throw new DomainException( "Error in reservation: Check-out date must ahead of Check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", CheckIn: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", checkout: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights.";
        }
    }
}


using ExercicioFixação2.Entities;

namespace ExercicioFixação2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date (dd/MM/yyyy: ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date (dd/MM/yyyy: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must ahead of Check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }


        }
    }
}
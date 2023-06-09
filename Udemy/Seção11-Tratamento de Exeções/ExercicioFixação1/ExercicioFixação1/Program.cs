using ExercicioFixação1.Entities;

namespace ExercicioFixação1
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

                DateTime now = DateTime.Now;
                if(checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");

                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must ahead of Check-in date");
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
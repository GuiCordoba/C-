using ExercicioFixação3.Entities;
using ExercicioFixação3.Entities.Exceptions;

namespace ExercicioFixação2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e) 
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }



        }
    }
}
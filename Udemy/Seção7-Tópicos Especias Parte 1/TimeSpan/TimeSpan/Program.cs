using System;

namespace ExTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 2); //hora, minuto e segundo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 2); //dia, hora, minuto e segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 2, 321); //dia, hora, minuto, segundo e milisegundo

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMicroseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine();
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);    
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
        }
    }
}
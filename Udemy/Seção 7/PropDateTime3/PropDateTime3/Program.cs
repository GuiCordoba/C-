using System;

namespace PropDateTime3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2001, 8, 15);
            DateTime d2 = new DateTime(2001, 8, 20);

            DateTime t1 = d1.AddDays(1);
            DateTime t2 = d1.AddYears(3);
            TimeSpan t3 = d2.Subtract(d1);

            Console.WriteLine(t1);
            Console.WriteLine(t2);  
            Console.WriteLine(t3);  
            
        }
    }
}
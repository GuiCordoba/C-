using System;
using System.Globalization;

namespace ExercicioFixação2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() 
        {
        }

        public Individual(string name, double anualImcome,double healthExpenditures) : base (name, anualImcome) 
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualImcome < 20000.00)
            {
                return AnualImcome * 0.15 - (HealthExpenditures * 0.50);
            }
            else
            {
                return AnualImcome * 0.25 - (HealthExpenditures * 0.50);
            }
        }
    }
}

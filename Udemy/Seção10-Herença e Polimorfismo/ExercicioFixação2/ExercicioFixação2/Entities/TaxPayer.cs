

namespace ExercicioFixação2.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public double AnualImcome { get; set; }

        public TaxPayer() 
        {
        }

        public TaxPayer(string name, double anualImcome)
        {
            Name = name;
            AnualImcome = anualImcome;
        }

        public abstract double Tax();
    }
}

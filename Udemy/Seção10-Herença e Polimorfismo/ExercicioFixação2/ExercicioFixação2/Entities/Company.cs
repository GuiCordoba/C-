

namespace ExercicioFixação2.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() 
        {
        }

        public Company(string name, double anualImcome, int numberOfEmployees) : base(name, anualImcome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {

            if (NumberOfEmployees > 10)
            {
                return AnualImcome * 0.14;
            }
            else
            {
                return AnualImcome * 0.16;
            }
        }
    }
}

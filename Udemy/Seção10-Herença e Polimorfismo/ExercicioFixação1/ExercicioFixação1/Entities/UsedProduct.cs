using System;
using System.Globalization;


namespace ExercicioFixação1.Entities
{
    internal class UsedProduct : Products
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct() 
        {
        }

        public UsedProduct(string name, double price, DateOnly manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name 
                + "(Used)"
                + " - " 
                + " $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + " (" + "Manufacture Date: " 
                + ManufactureDate.ToString("dd/MM/yyyy") 
                + ")";
        }

    }
}

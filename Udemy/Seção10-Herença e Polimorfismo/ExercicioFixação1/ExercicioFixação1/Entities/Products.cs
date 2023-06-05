using System;
using System.Collections.Generic;

namespace ExercicioFixação1.Entities
{
    internal class Products
    {
        public string Name { get; set; }
       public double Price { get; protected set; }

        public Products()
        { 
        }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public virtual string PriceTag()
        {
            return Name + " - " + " $" + Price;
        }
    }
}

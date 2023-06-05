using System.Text;
using System.Globalization;

namespace Exercicio_3.Entities
{
    internal class OrderItem
    {
        public int QuantityProd { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { 
        }

        public OrderItem(int quantityProd, double price, Product product)
        {
            QuantityProd = quantityProd;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * QuantityProd;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                +", Quantity: "
                + QuantityProd
                + ", SubTotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

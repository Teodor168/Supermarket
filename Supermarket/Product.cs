using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Product
    {
        private static double sum = 0;
        public Product(string name,double price, double quantity )
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        private string name;

        private double price;

        private double quantity;

        private double quantityPrice;

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public double Quantity { get { return quantity; } set { quantity = value; } }
        public double QuantityPrice { get { return quantityPrice; } set {  quantityPrice = value; } }
        public static double Sum {  get { return sum; } set {  sum = value; } }

        public void Pechat()
        {
            Console.WriteLine($"{this.Name}: ${this.Price:F2} * {this.Quantity} = ${this.QuantityPrice:F2}");
        }
    }
}

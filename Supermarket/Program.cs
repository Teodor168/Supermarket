namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string duma = null;
            do
            {
                Console.Write("Iskash li da vavejdash product (da/stocked): ");
                duma = Console.ReadLine();
                if (duma == "stocked")
                {

                }
                else
                {
                    Console.Write("ime: ");
                    string name = Console.ReadLine();
                    Console.Write("cena: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("kolichestvo: ");
                    double quantity = double.Parse(Console.ReadLine());
                    Product product1 = new Product(name, price, quantity);
                    product1.QuantityPrice = product1.Quantity * product1.Price;
                    Product.Sum += product1.QuantityPrice;
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name==name)
                        {
                            products.RemoveAt(i);
                           
                        }
                    }                   
                    products.Add(product1);
                }

            } while (duma != "stocked");

            //PECHAT
            for (int i = 0;i < products.Count;i++)
            {
                products[i].Pechat();  
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: { Product.Sum:F2}");
        }
    }
}

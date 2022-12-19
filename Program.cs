using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingCart
{
    static class Program
    {
        public delegate ShoppingCart sort(ShoppingCart cart);
        
        
        static void Main(string[] args)
        {
            sort name = new sort(ShoppingCart.SortByName);
            sort price = new sort(ShoppingCart.SortByPrice);
            sort quantity = new sort(ShoppingCart.SortByQuantity);

            

            ShoppingCart cart = new ShoppingCart();
            cart.AddtoCart(new Product("b",12.99,1));
            cart.AddtoCart(new Product("a", 12.99, 1));
            cart.AddtoCart(new Product("c", 12.99, 1));


            /*List<dynamic> anony = new List<dynamic>();

            anony.Add(new { Name = "pepsi", Price = 12.99, Quantity = 1 });
            anony.Add(new { Name = "coke", Price = 10.99, Quantity = 2 });

            for (int i = 0; i < anony.Count; i++)
            {
                Console.WriteLine(anony[i].ToString());
            }*/


            Console.WriteLine("By which criteria do you want to sort?\n1.Name\n2.Price\n3.Quantity");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine(choice);
            cart = choice == 1 ? ShoppingCart.SortProductsinCart(name, cart) : choice == 2 ? ShoppingCart.SortProductsinCart(price, cart) : ShoppingCart.SortProductsinCart(quantity, cart);

            cart.DisplayCart();
        }

        public static bool CompareCart(this ShoppingCart cart1, ShoppingCart cart2)
        { 
            if( cart1.Products.Count != cart2.Products.Count)
            {
                return false;
            }

            for (int i = 0; i < cart1.Products.Count; i++)
            {
                if (!cart1.Products.Contains(cart2.Products[i]))
                {
                    return false;
                }
            }
            return true;
        }





    }
}
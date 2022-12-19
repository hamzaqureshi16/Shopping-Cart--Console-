using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ShoppingCart.Program;

namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<Product> _products = new List<Product>();
        
        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public ShoppingCart()
        {
        }

        public void AddtoCart(Product p)
        {
            Products.Add(p);
        }

        public static bool operator ==(ShoppingCart cart1, ShoppingCart cart2)
        {
            return cart1.CompareCart(cart2);
        }



        public static bool operator !=(ShoppingCart cart1, ShoppingCart cart2)
        {
            return !cart1.Equals(cart2);
        }

        public static ShoppingCart operator +(ShoppingCart cart1, ShoppingCart cart2)
        {
            ShoppingCart cart3 = new ShoppingCart();
            cart3.Products = cart1.Products.Concat(cart2.Products).ToList();
            return cart3;
        }

        public static ShoppingCart operator ++(ShoppingCart cart1)
        {
            foreach (Product p in cart1.Products)
            {
                p.Quantity++;
            }
            return cart1;
        }

        public static ShoppingCart SortByPrice(ShoppingCart cart)
        {
            for (int i = 0; i < cart.Products.Count; i++)
            {
                for (int j = i + 1; j < cart.Products.Count; j++)
                {
                    if (cart.Products[i].Price > cart.Products[j].Price)
                    {
                        Product temp = cart.Products[i];
                        cart.Products[i] = cart.Products[j];
                        cart.Products[j] = temp;
                    }
                }
            }
            return cart;
        }

        public static ShoppingCart SortByQuantity(ShoppingCart cart)
        {
            for (int i = 0; i < cart.Products.Count; i++)
            {
                for (int j = i + 1; j < cart.Products.Count; j++)
                {
                    if (cart.Products[i].Price > cart.Products[j].Price)
                    {
                        Product temp = cart.Products[i];
                        cart.Products[i] = cart.Products[j];
                        cart.Products[j] = temp;
                    }
                }
            }
            return cart;

        }

        public static ShoppingCart SortByName(ShoppingCart cart)
        {


            for (int i = 0; i < cart.Products.Count; i++)
            {
                for (int j = i + 1; j < cart.Products.Count; j++)
                {
                    if (cart.Products[i].Name.CompareTo(cart.Products[j].Name) > 0)
                    {
                        Product temp = cart.Products[i];
                        cart.Products[i] = cart.Products[j];
                        cart.Products[j] = temp;
                    }
                }
            }

            return cart;
        }



        public static ShoppingCart SortProductsinCart(sort r, ShoppingCart cart)
        {
            return r(cart);
        }
        
        public void DisplayCart()
        {
            foreach (Product p in Products)
            {
                Console.WriteLine(p.ToString());
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart { 

    class Product
    {
        public string Name { get; set; }
        public double Price { get; init; }
        public int Quantity { get; set; }


        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product()
        {
        }

        
        public static bool operator ==(Product p,Product product)
        {
            if (p.Name == product.Name)
            {
                if (p.Price == product.Price)
                {
                    if (p.Quantity == product.Quantity)
                    {
                        return true;
                    }
                }
            }
           
           

            return false;
        }
        public static bool operator !=(Product p, Product product)
        {
            return !(p == product);
        }
        public override string ToString()
        {
            string s = "";
            s += this.Name + "\n" + this.Price + "\n" + this.Quantity + "\n\n";

            return s;
        }





    }
}

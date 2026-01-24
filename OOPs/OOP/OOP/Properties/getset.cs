using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Properties
{
    internal class getset
    {
        class ProductClass
        {
            private string Name;
            private int Price;
            private int Stock;

            public ProductClass(string name , int price , int stock) //parameterized constructor
            {
                if (name != "")
                {
                    Name = name;
                }
                if (price >= 0)
                {
                    Price = price;
                }
                if (stock >= 0)
                {
                    Stock = stock;
                }
            }

            public void DisplayProduct()
            {
                Console.WriteLine($"ProductName : {Name}, ProductPrice : {Price}, Stock :{Stock}");
            }
        }
        public static void Main(string[] args)
        {
            ProductClass p1 = new ProductClass("Controller",100,23);
            p1.DisplayProduct();


        }
    }
}

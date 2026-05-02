using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace last_task
{

    class product
    {
        private string name;
        private double price;
        private int stock;
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { if (Price >= 0) { price = value; } } }
        public int Stock { get { return stock; } set { if (Stock >= 0) { stock = value; } } }

        public void Sell(int quantity)
        {
            if (quantity < stock)
            { stock = stock - quantity; }

        }

        public void Restock(int quantity)
        {

            stock = stock + quantity;

        }


        public void display_product_details()
        {


            Console.WriteLine($"Product Name :{name} ");
            Console.WriteLine($"Product Price :{price} ");
            Console.WriteLine($"Product Stock :{stock} ");


        }



    }



    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Products =
            { "Name: Laptop, Price: 800, Stock: 10",
              "Name: Ipad, Price: 400, Stock: 20",
              "Name: Mobile, Price: 600, Stock: 30",
              "Name: Charger, Price: 100, Stock: 60",
              "Name: Airpods, Price: 360, Stock: 50",
            };

            File.WriteAllLines("Products.txt", Products);

            string[] ProductsToRead = File.ReadAllLines("Products.txt");


            foreach (string Product in ProductsToRead)
            {

                Console.WriteLine(Product);
            }


            product Obj1=new product();
            Obj1.Name = "A1";
            Obj1.Price = 800;
            Obj1.Stock = 10;
           

            product Obj2 = new product();
            Obj2.Name = "A2";
            Obj2.Price = 400;
            Obj2.Stock = 20;
            product Obj3 = new product();
            Obj3.Name = "A3";
            Obj3.Price = 600;
            Obj3.Stock = 30;
             
           
            Obj1.Sell(11);
            Obj1.display_product_details();
            Obj1.Restock(20);
            Obj1.display_product_details();
            Obj1.Sell(11);
            Obj1.display_product_details();



            Obj2.Sell(11);
            Obj2.display_product_details();
            Obj2.Restock(3);
            Obj2.display_product_details();

            Obj3.Sell(30);
            Obj3.display_product_details();
            Obj3.Restock(30);
            Obj3.display_product_details();


        }
    }
}

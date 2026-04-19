using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("your name is : "+ name);

            int age = 22;
            double price = 99.99;
            char grade = 'A';
            bool isLoggedIn=false;
            string Address = "irbid";
            double tempretaure = 22;
         
            Console.WriteLine("your age is : " + age);
         
            Console.WriteLine("your price is : " + price);
         
            Console.WriteLine("your grade is : " + grade);
          
            Console.WriteLine("isLoggedIn : " + isLoggedIn);
          
            Console.WriteLine("your Address is : " + Address);
           
            Console.WriteLine("the tempretaure is : " + tempretaure);
        }
    }
}

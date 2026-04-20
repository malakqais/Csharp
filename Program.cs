using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            {
                string[] fruits = { " apple", " bannana", " coconut", " peach", " mango", " berry" };
                for (int i = 0; i < fruits.Length; i++)
                {

                    Console.WriteLine("Fruits at indix" + i + " : " + fruits[i]);


                }
            }

            Console.WriteLine(" ");

            //2
            {
                int[] numbers = new int[5];
                for (int i = 0; i < numbers.Length; i++)
                {

                    Console.WriteLine("input nubers into the array : ");
                    Console.Write("number at indix " + i + " : ");
                    numbers[i] = int.Parse(Console.ReadLine());

                }

                Console.Write("Original array ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Array.Reverse(numbers);
                Console.WriteLine();

                Console.Write("Reseved array ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
              
                //int[] Reversenumbers = new int[5];
                //int length_= Reversenumbers.Length;
                //for (int i = 0; i < Reversenumbers.Length; i++)
                //{
                //    Reversenumbers[i] = numbers[length_- i+1];


                //}

                //Console.Write("Reseved array ");
                //for (int i = 0; i < Reversenumbers.Length; i++)
                //{
                //    Console.Write(Reversenumbers[i] + " ");
                //}

            }


            Console.WriteLine(" ");
            //3
            {
                Console.WriteLine(" ");
                Console.Write("enter number of colors: ");
                int n = int.Parse(Console.ReadLine());
                string[] colors = new string[n];

                Console.Write(" input colors into the array : ");
                for (int i = 0; i < n; i++)
                {
                    colors[i] = Console.ReadLine();
                    if (i != n - 1)
                    {
                        Console.Write(" , ");
                    }

                }

                int count = 0;

                Console.Write("Colors starting with 'R': ");

                for (int i = 0; i < n; i++)
                {
                    if (colors[i].StartsWith("R") || colors[i].StartsWith("r"))
                    {
                        Console.Write(colors[i] + " ");
                        count++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Total count: " + count);

            }


            Console.WriteLine(" ");
            //4


            int[] NUMs = new int[6];
            Console.WriteLine(" input 6 numbers into the array : ");
            for (int i = 0; i < NUMs.Length; i++)
            {
                NUMs[i]=int.Parse(Console.ReadLine());

            }

            Console.WriteLine(" ");

            for (int i = 0; i < NUMs.Length; i++)
            {
                Console.WriteLine("Number at index  "+i+": " + NUMs[i]);
               

            }


            Console.WriteLine("Sum of elements :  "+NUMs.Sum());
            double avg = (double)(NUMs.Sum()) / NUMs.Length;
            Console.WriteLine("Average of elements :  " + avg);
            Console.WriteLine("MIN of elements :  " + NUMs.Min());
            Console.WriteLine("MAX of elements :  " + NUMs.Max());

            Array.Sort(NUMs);
            Console.Write("SORTED ARRAY");
            for (int i = 0; i < NUMs.Length; i++)
            {

                Console.WriteLine( NUMs[i]);
                if (i != NUMs.Length - 1)
                {
                    Console.Write(" , ");
                }

            }






        }

    }
}

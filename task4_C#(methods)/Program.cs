using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_C__methods_
{
    class test
    {

        //1
        public void iseven(int num)
        {
            if(num%2==0) 
            {
                Console.WriteLine($"The number {num} is even");
            }

            else 
            {
                Console.WriteLine($"The number {num} is odd");
            }
            

        }


        //2

        public void second_smallest(int[] nums,int size)
         {

            Array.Sort(nums);
            //int first = nums[0];
            //int second = nums[1];
            //for (int i = 0; i < size-1; i++)
            //{

            //    for (int j = i+1; i < size; i++)
            //    {
            //        if (nums[j]<first)
            //            first = nums[j];
            //        else if (nums[j]<second) second = nums[j];

            //    }
            //}

            Console.WriteLine($"Output:{nums[1]}");
        }


        //3


        public int factorial(int number)
        {
            int fact = 1;
            for (int i = 0; i < number; i++)
            {

               fact *= (number-i);


            }
        return fact;
        }


        //5
        public int find_largest(int[] nums, int size)
        {

            int largest=nums[0];
            foreach (int i in nums)
            {
                if (i > largest)
                { largest = i; }


            }
          return largest;

        }


        //6
        public void print(int n)
        {
            int number = 1;

            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine();
            }

        }






    }

    internal class Program
    {
        static void Main(string[] args)
        {

           
            test t=new test();
            //2
            int[] nums = { 4, -3, 7, 2, 0 };
            t.second_smallest(nums,nums.Length);


            //3
            Console.WriteLine("input a number to calculate the factorial");
           int number=int.Parse( Console.ReadLine());
            int fact=t.factorial(number);
            Console.WriteLine($"Output: {fact} ({number} × {number-1} ×{number - 2} × {number - 3} × 1 = {fact})");


            //5
            int[] nums1 = { 3, 1, 4, 1, 5, 9 };
            int largest=t.find_largest(nums1,nums1.Length);
            Console.WriteLine($" Output:{largest}");


                //6
                t.print(5);














        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            List<string> student_names = new List<string>();

            Console.WriteLine("enter 5 student names");

            for (int i = 0; i < student_names.Count + 1; i++)
            {
                if (i < 5)
                {
                    Console.Write($"Enter student {i + 1} name: ");
                    string name = Console.ReadLine().Trim().ToUpper();
                    student_names.Add(name);
                    Console.WriteLine(name);
                }
                else
                    break;
            }

            //2

            Console.WriteLine("enter a student name to search");
            string name_to_search = Console.ReadLine().Trim().ToUpper();

            if (student_names.Contains(name_to_search))
            {
                Console.WriteLine("Student Found");
            }
            else
            {
                Console.WriteLine("Student Not Found");

            }


            //3
            Console.WriteLine("enter a student name to remove");
            string name_to_remove = Console.ReadLine().Trim().ToUpper();

            if (student_names.Contains(name_to_remove))
            {
                student_names.Remove(name_to_remove);
            }
            else
            {
                Console.WriteLine("Student Not exist");

            }


            //4

            student_names.Sort();

            // Print sorted list
            Console.WriteLine("Sorted Student Names:");

            foreach (string name in student_names)
            {
                Console.WriteLine(name);
            }

            //5

            Console.WriteLine("Enter skills (comma separated):");
            string input = Console.ReadLine();
            string[] skills = input.Split(',');
            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }



            //6

            int[,] grades = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine($" student {i + 1} ->  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"  subject {j + 1} grade is  :  ");
                    grades[i, j] = int.Parse(Console.ReadLine());

                }


            }

            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine($" student {i + 1} ->  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"  subject {j + 1} grade is  : {grades[i, j]}  ");

                }


            }


            grades[1, 1] = 13;



            //7

            int[][] exams = new int[3][];


            exams[0] = new int[] { 1, 2 };
            exams[1] = new int[] { 3, 4, 5 };
            exams[2] = new int[] { 6 };


            for (int i = 0; i < exams.Length; i++)
            {

                for (int j = 0; j < exams[i].Length; j++)
                {

                    Console.WriteLine($" student {i+1} exam\'s {j + 1} grade is : {exams[i][ j]} ");



                }


            }



            //8

            Console.WriteLine("Enter admin password:");
            string password = Console.ReadLine();
            if (password == "ADMIN123")
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }



















        }



    }
    }


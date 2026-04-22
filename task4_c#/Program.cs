using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_c_
{

    class student
    {
        string name;
        int age;
        double grade;
        const string universityName = "Yarmouk University";
        public static int studentCount;


       public student()
        {  studentCount ++; }
       public void DisplayInfo()
        {
            Console.WriteLine($" student name :{name}");
            Console.WriteLine($" student name :{age}");
            Console.WriteLine($" student name :{grade}");
            Console.WriteLine($" student name :{universityName}");
        
        }

        public void UpdateGrade(double newGrade)
        {

            grade = newGrade;
        }
        public bool IsPassed()
        {
            if (grade >= 50)
            { return true; }
        
            return false;
        
        }


        public void set(string n, int a, double g)
        { 
        name=n; age=a; grade = g; 
        
        
        }








    }







    internal class Program
    {
        static void Main(string[] args)
        {

            student S1=new student();
            student S2 = new student();
            student S3 = new student();

            S1.set("malak", 22, 100);
            S2.set("haya", 23, 90);
            S3.set("rayan", 24, 80);

            S1.DisplayInfo();
            S2.DisplayInfo();
            S3.DisplayInfo();

            S1.UpdateGrade(90);
            S2.UpdateGrade(80);
            S3.UpdateGrade(70);


            Console.WriteLine($"is student 1 passed? {S1.IsPassed()} ");
            Console.WriteLine($"is student 2 passed? {S2.IsPassed()} ");
            Console.WriteLine($"is student 3 passed? {S3.IsPassed()} ");
            Console.WriteLine($"total number of student is  {student.studentCount} ");




            /*
             
             What is a class : defining a new data type to use it in the program later insted of creating the fields every time when you need to use it 
             What is an object : is an instant of the class 
             Example from their code : class->student & object->S1/S2/S3
             
             */


















        }
    }

}

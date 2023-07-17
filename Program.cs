using MethodsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    public class OurClass //accessSpecifier(public,private,protected) class className
    {
        //public void Display()
        //{
        //    Console.WriteLine("Welcome to Methods");
        //}  //instance method-> return type void and parameters= no

        //static method
        //public static void Welcome()
        //{
        //    Console.WriteLine("Static Method welcomes you!!");

        //}

        //Method return void and take 2 parameters
        public void FullName(string fname, string lname)
        {
            Console.WriteLine("Full Name: " + fname + " " + lname);
        }
        //Method return double and take 2 parameters
        public double Add(double n1, double n2)
        {
            double result;
            result = n1 + n2;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accessing method with object

            //OurClass obj= new OurClass();
            //obj.Display();
            //Console.WriteLine("\n");
            //OurClass.Welcome();
            //Console.ReadKey();

            OurClass ourClass = new OurClass();
            double num1, num2;
            Console.WriteLine("Input 1st no: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd no: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Result after addition: " + ourClass.Add(num1, num2));
            Console.ReadKey();
        }
    }
}
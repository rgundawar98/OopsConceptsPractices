using System;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concepts");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Class And object");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //Object created for  ClassAndObject Class as classAndObject
                    ClassAndObject classAndObject = new ClassAndObject();
                    classAndObject.Demo();
                    break;
            }
        }
    }
}

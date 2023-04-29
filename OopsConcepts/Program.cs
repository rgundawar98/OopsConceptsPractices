using System;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concepts");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Class And object\n2.Inheritance");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //Object created for  ClassAndObject Class as classAndObject
                    ClassAndObject classAndObject = new ClassAndObject();
                    classAndObject.Demo();
                    break;
                case 2:
                    Mustang mustang = new Mustang();  //Parent Class
                    mustang.Car(); //It call its own method using reference object
                    Gear gear = new Gear(); //Child class or inherited class
                    //Child class can call its method and parent class method too
                    gear.Gear_System();
                    gear.Car();
                    break;
            }
        }
    }
}

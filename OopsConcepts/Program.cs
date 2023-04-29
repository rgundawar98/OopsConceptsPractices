using System;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concepts");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Class And object\n2.Inheritance\n3.Overloading\n4.Overriding");
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
                case 3:
                    Overloading overloading = new Overloading();
                    overloading.Test(45, 45);
                    overloading.Test(12, 12, 12.4);
                    overloading.Test("Ronny", 121);
                    overloading.Test("Riya", 456);
                    break;
                case 4:
                    Bike bike = new Bike(); //Parent class
                    //When we used virtual keyword in parent class method then parent class can only its method
                    bike.Type_Bike();
                    Vechicle vechicle = new Vechicle();//Child class
                    //When we use virtual keyword in parent class method then you have to use new keyword to
                    //access methods from child class object
                    //child class can access both methods of parent and child class
                    vechicle.Bike();
                    vechicle.Type_Bike();
                    break;
            }
        }
    }
}

﻿using System;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concepts");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Class And object\n2.Inheritance\n3.Overloading\n4.Overriding\n5.Encapsulation\n6.Abstraction" +
                "\n7.Types Of Variables\n8.Types Of Methods");
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
                case 5:
                    Encapsulation encapsulation = new Encapsulation();
                    encapsulation.Name = "Neha Singh";
                    encapsulation.Id = 146;
                    Console.WriteLine("Name:"+ encapsulation.Name);
                    Console.WriteLine("Id:"+encapsulation.Id);
                    break;
                case 6:
                    Square square = new Square(6);
                    Console.WriteLine("Area="+square.Test_Area());
                    break;
                case 7:
                    TypesOfVariables typesOfVariables = new TypesOfVariables();
                    typesOfVariables.Test();
                    TypesOfVariables.Demo(); //Static Method does not have need to call with refernce object
                    Console.WriteLine("Instance variable:"+typesOfVariables.Id);//Instance variables
                    break;
                case 8:
                    TypesOfMethods typesOfMethods = new TypesOfMethods();
                    typesOfMethods.Demo1(); //Non-Static Method
                    TypesOfMethods.Demo();//Static Method
                    break;
            }
        }
    }
}

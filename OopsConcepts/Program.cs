using OopsConcepts.TypesOfInheritance;
using System;

namespace OopsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Oops Concepts");
            Console.WriteLine("Choose the option from below");
            Console.WriteLine("1.Class And object\n2.Inheritance\n3.Overloading\n4.Overriding\n5.Encapsulation\n6.Abstraction" +
                "\n7.Types Of Variables\n8.Types Of Methods\n9.Value Type\n10.Reference Type\n11.Single Inheritance\n12.Multilevel" +
                "Inheritance\n13.Hierarchical Inheritance");
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
                case 9:
                    ValueType valueType = new ValueType();
                    valueType.Value_Type_Test();
                    break;
                case 10:
                    ReferenceType referenceType = new ReferenceType();
                    int value = 12;
                    referenceType.Test(value);
                    break;
                case 11:
                    Console.WriteLine("Single Inheritance");
                    Elephant elephant = new Elephant(); //Parent Class
                    elephant.Place();
                    Tiger tiger = new Tiger(); //Child Class
                    tiger.Eat(); //Child class method
                    tiger.Place(); //Parent class method
                    break;
                case 12:
                    Console.WriteLine("MultiLevel Inheritance");
                    BMW bMW = new BMW();
                    bMW.Color(); //Parent class method
                    Mercedez mercedez= new Mercedez();
                    mercedez.Gear_System();
                    mercedez.Color(); //Parent method or inherited class method
                    Ferrari ferrari = new Ferrari();
                    ferrari.Car_Type();
                    ferrari.Gear_System();//Inherited class method
                    ferrari.Color(); //Inherited class's inherited method
                    break;
                case 13:
                    Console.WriteLine("Hierarchical Inheritance");
                    Fruit fruit = new Fruit();
                    fruit.Test(); //Parent class method
                    Banana banana = new Banana();
                    banana.Taste(); //Child class method
                    banana.Test();//Inherited class method
                    Pineapple pineapple = new Pineapple();
                    pineapple.Fruit_Type(); //Own class method
                    pineapple.Test();//Inherited class method
                    break;
            }
        }
    }
}

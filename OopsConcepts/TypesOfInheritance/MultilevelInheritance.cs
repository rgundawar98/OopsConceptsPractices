using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.TypesOfInheritance
{
    //Multilevel Inheritance - In this type a parent class inherits from child class and then the same parent class acts as
    //as a child class for another class
    public class BMW
    {
        public void Color()
        {
            Console.WriteLine("This car is in VentaBlack Color");
        }
    }

    class Mercedez:BMW
    {
        public void Gear_System()
        {
            Console.WriteLine("This Car has Automatic Gear system");
        }
    }

    class Ferrari:Mercedez
    {
        public void Car_Type()
        {
            Console.WriteLine("This is Sports Car");
        }
    }
}

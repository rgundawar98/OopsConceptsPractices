using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Overriding -It means having same class name but different implementation
    public class Bike
    {
        public virtual void Type_Bike()
        {
            Console.WriteLine("This is a BMW Bike");
        }
    }
    public class Vechicle:Bike
    {
        public new void Bike()
        {
            Console.WriteLine("Having 6 Gears");
        }
    }
}

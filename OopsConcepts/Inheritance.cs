using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Inheritance means one class can acquire all properties and methods of another class
    public class Mustang  
    {
        public void Car()
        {
            Console.WriteLine("This is Expensive Car");
        }
    }
     
    class Gear: Mustang   //Gear class is inherited with Mustang class
    {
        public void Gear_System()
        {
            Console.WriteLine("Mustang having Automatic Gear System");
        }
    }
}

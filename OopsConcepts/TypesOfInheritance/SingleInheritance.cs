using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.TypesOfInheritance
{
    //Single Inheritance - Single inheritance is having one parent class and one child class
    //One class is inherited with another
    public class Elephant  //Parent Class
    {
        public void Place()
        {
            Console.WriteLine("Lives in jungle");
        }
    }
    
    class Tiger:Elephant //Child Class inherited with parent class
    {
        public void Eat()
        {
            Console.WriteLine("Tiger eats meat");
        }
    }
}

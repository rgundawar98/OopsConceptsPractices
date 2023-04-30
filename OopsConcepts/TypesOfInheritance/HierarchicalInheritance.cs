using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.TypesOfInheritance
{
    //Hierarchical Inheritance - One parent class and multiple child class 
    public class Fruit
    {
        public void Test()
        {
            Console.WriteLine("Eat One Apple Daily");
        }
    }
    class Banana:Fruit
    {
        public void Taste()
        {
            Console.WriteLine("Having Sweet in Taste");
        }
    }

    class Pineapple:Fruit
    {
        public void Fruit_Type()
        {
            Console.WriteLine("The Pineapple is a tropical Plant with an edible fruit");
        }
    }
}

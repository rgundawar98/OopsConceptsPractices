using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class TypesOfMethods
    {
        //Two types of methods
        //Static Method =No need of reference object is necessary to call these methods
        //Non-Static Method = Need of reference object is necessary to call these methods 
        public static void Demo()
        {
            Console.WriteLine("This is static method");
        }
        public void Demo1()
        {
            Console.WriteLine("This is non static method");
        }
    }
}

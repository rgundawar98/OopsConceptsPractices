using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Class is a blueprint of program
    //Class contains methods,variables,constructors etc.
    public class ClassAndObject 
    {
        int id = 10; //Instance variables
        public void Demo()  //Method is entity of class 
        {
            Console.WriteLine("This is a non Parametrized method");
        }
        public ClassAndObject()
        {
            Console.WriteLine("It is default constructor");
        }
    }
}

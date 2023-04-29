using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Types Of Variables
    //1.Local variable = Declared inside the method
    //2.Instance variable = Declared inside the class outside the method
    //3.Static variable = Static variables are variables declared static keyword with variables
    public class TypesOfVariables
    {
        public int Id = 122; //Instance variable
        public void Test()
        {
            string Name = "Nitesh";
            int Id = 1234;
            Console.WriteLine("Name is:"+Name);
            Console.WriteLine("Id is:"+Id);
        }
        public static void Demo() //Static method
        {
            int Emp_Id = 78932;
            Console.WriteLine("Employee Id:"+Emp_Id);
        }
    }
}

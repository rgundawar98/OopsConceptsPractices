using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //In value Type there are two types 1)built in type 2)user defined type
    //Built-in = int,float,long,double,byte,decimal,short,char ,bool
    //User-defined = struct and enum 
    //It will store in a stack memory
    //ValueType and Refernce Type we also called boxing and unboxing
    public class ValueType
    {
        public void Value_Type_Test()
        {
            int Num1 = 111;
            int Num2 = Num1+1;
            Console.WriteLine("Num2 will be:"+Num2);
            Console.WriteLine(Num1);
        }
    }
}

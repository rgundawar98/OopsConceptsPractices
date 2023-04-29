using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Polymorphism - It means one task can perform in many ways
    //Having two types
    //1.RunTime Polymorphism - Method Overriding
    //2.CompileTime Polymorphism - Method Overloading
    //Method overloading means having same method name but different parameters
    public class Overloading
    {
        //By three ways we can achieve method overloading
        //1.By Changing number of parameters
        //2.By changing datatypes of parameters
        //3.By interchanging parameters position
        public void Test(int value1 , int value2)
        {
            int Addition = value1 + value2;
            Console.WriteLine("Addition will be:"+Addition);
        }
        public void Test(int Num1 , int Num2 , double Num3)
        {
            double Mul = Num1*Num2*Num3;
            Console.WriteLine("Multiplication will be:" + Mul);
        }
        public void Test(string Name , int Id)
        {
            Console.WriteLine("Name:{0} and Id:{1}",Name,Id);
        }
        public void Test(int Id, string Name)
        {
            Console.WriteLine("Id:{0} and Name:{1} ",Id,Name);
        }
    }
}

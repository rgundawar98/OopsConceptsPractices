using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //It will show the essential feature and hide complex data from user
    //It will achive withe help of abstract class and abstract methods
    abstract class Area
    {
        //Use abstract keyword to create abstract method
        //We cannot cretae the object for the abstract class
        //Abstract and non abstract methods are present in abstract class
        abstract public int Test_Area();
    }
    class Square:Area
    {
       int side = 0;
        public Square(int num)
        {
            side = num;
        }
        public override int Test_Area()
        {
            return side*side;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //Encapsulation it means -
    //It will hide sensitive data from the user
    //Declare field or variable should be private
    //Property-get:Is read-only  and  Property-set:It is used to set data
    public class Encapsulation
    {
        private string StudentName;
        private int StudentId;

        public string Name
        {
            get {
                return StudentName;
                }
            set
            {
                StudentName = value;
            }
        }
        public int Id
        {
            get
            {
                return StudentId;
            }
            set
            {
                StudentId = value;
            }
        }
    }
}

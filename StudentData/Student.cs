using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Student
    {
        int id;
        string name;
        internal Student()
        {
            id = 1;
            name = "ABC";
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student id is:" + id);
            Console.WriteLine("Student name is:" + name);
            
        }
    }
}

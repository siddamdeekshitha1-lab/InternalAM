using StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAM
{
    /*
     * 
     * Internal AccessModifier=it can be accessed throughout the project
     * 
     */
    class MyClass
    {
        int a;
        internal MyClass()
        {
            a = 10;
        }
        public void Display()
        {
            Console.WriteLine("value of A is  :" + a);
        }
    }
    class NewClass
    {
       

        public void Method()
        {
            NewClass obj= new NewClass();
            Console.WriteLine(obj.a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Display();
            NewClass obj2= new NewClass();
            obj2.Method();
                Student std=new Student();
            std.DisplayDetails();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class SampleClass
    {
        //
        public static void myMethod()
        {
            string[] name = { "odai", "ashraf", "mo'men", "qais", "hassan" };
            for (int i = 0; i <= name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }


        }
    }
}

namespace MyProgram
{
    public class MyClass
    {
        public static void Main()
        {
            MyNamespace.SampleClass.myMethod();
        }
    }
}
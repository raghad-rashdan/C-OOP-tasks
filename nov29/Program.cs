using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nov29
{
     class Employee
    {

        public string emp_name { get; set; }
        public int emp_id { get; set; }
        public int  birth_date  { get; set; }

        public Employee()
        {
        }

        //constructor Employee
        public Employee(string name ,int id , int BDate)
        {
            emp_name=name;
            emp_id=id;
            birth_date = BDate;

        }
        //age method
        public void print(int age)
        {
            birth_date = 2022 - age;
        Console.WriteLine($"TheEmployee name : {birth_date} ");
         

        }



        // method to print full information 
        public void print()
        {
            Console.WriteLine($"TheEmployee name : {emp_name} ");
            Console.WriteLine($"the Employee ID : {emp_id}");
            //Console.WriteLine($" the birth date  : {birth_date} ");
        
        }
        //inhertance class
        class Manager: Employee
        {
        }

        internal class Test
        {


            static void Main(string[] args)
            {
            

                Console.WriteLine("Enter the employee name : ");
                string emp_name = Console.ReadLine();

                Console.WriteLine("Enter the Employee ID : ");
                int emp_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the birth date (year)");
                int birth_date = Convert.ToInt32(Console.ReadLine());

                Employee employee= new Employee(emp_name, emp_id, birth_date);
                employee.print();
                employee.print(birth_date);


            }
        }
    }
}

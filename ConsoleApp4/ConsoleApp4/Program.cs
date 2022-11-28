using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public string cars_made;
        public int year;
        public string type;
        public int price;
        public string model;
        public int pallet_no;
        public string color;

        // Create a class constructor for the Car class
        public Car()
        {
            cars_made = "metal";
            year = 2019;
            type = "ford";
            price = 24000;
            model = "Mustang";
            pallet_no = 10;
            color = "black";
        }

        static void MyMethod()
        {
            Car Ford = new Car();
            Console.WriteLine("cars_made is :" + Ford.cars_made);
            Console.WriteLine("year is :" + Ford.year);
            Console.WriteLine("type is :" + Ford.type);
            Console.WriteLine("price is :" + Ford.price);
            Console.WriteLine("model is :" + Ford.model);
            Console.WriteLine("pallet_no is :" + Ford.pallet_no);
            Console.WriteLine("color is :" + Ford.color);
        }
        static void Main(string[] args)
        {
            MyMethod();
            Car Ford = new Car();
        }
    }
}

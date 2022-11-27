//// See https://aka.ms/new-console-template for more information

//using System.Runtime.CompilerServices;

//static double add(double x, double y)
//{
//    return x + y;
//}
//Console.WriteLine(add(5.5, 3.7));

//static double sub(double x, double y)
//{
//    return x - y;
//}
//Console.WriteLine(sub(5.5, 3.7));

//static int mult(int x, int y)
//{
//    return x * y;
//}
//Console.WriteLine(mult(5,7));

//static double divi(int x, int y)
//{
//    return x / y;
//}
//Console.WriteLine(divi(15, 7));

//static string hi(string name)
//{
//    return "hello"+" " + name;
//}

//static string by(string name)
//{
//    return "goodbye" + " " + name;
//}
//string name;
//name = Console.ReadLine();
//Console.WriteLine(hi(name));
//Console.WriteLine(by(name));

//Console.WriteLine("------------------------------------------");
class car
{
    string color = "red";
    string price = "6000$";
    int model = 2005;


    static void Main(string[] args)
    {
        car ford = new car();
        Console.WriteLine("color : " + ford.color);
        Console.WriteLine("price : " + ford.price);
        car kia = new car();
        Console.WriteLine("color : " + kia.color);
        Console.WriteLine("model : " + kia.model);
    }
}



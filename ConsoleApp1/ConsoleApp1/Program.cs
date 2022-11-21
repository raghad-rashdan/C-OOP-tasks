// See https://aka.ms/new-console-template for more information

//Write a C# program that accept two integers and display the smaller. 
int num1, num2;
Console.WriteLine("Input the values for Number1  : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the values for Number2  : ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("the smaller :" + num2);
}

else
{
    Console.WriteLine("the smaller :" + num1);
}

Console.WriteLine("-----------------------------------------------");
// Write a C# conditional statement to find the sign  of input  number. Display sign. Go 
int x;
Console.WriteLine("Input the values for Number1  : ");
x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine(x + " is sign number");
}
else
{
    Console.WriteLine(x + " is positive number");

}

Console.WriteLine("-----------------------------------------------");
//Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
int a = 4;
int b = 2;
int c = 3;
if (a > b && a > c)
{
    if (b > c)
    {
        Console.WriteLine(a + ", " + b + ", " + c);
    }
    else
    {
        Console.WriteLine(a + ", " + c + ", " + b);
    }
}
else if (b > a && b > c)
{
    if (a > c)
    {
        Console.WriteLine(b + ", " + a + ", " + c);
    }
    else
    {
        Console.WriteLine(b + ", " + c + ", " + a);
    }
}
else if (c > a && c > b)
{
    if (a > b)
    {
        Console.WriteLine(c + ", " + a + ", " + b);
    }
    else
    {
        Console.WriteLine(c + ", " + b + ", " + a);
    }
}

Console.WriteLine("-----------------------------------------------");
//Write a C# conditional statement to find the max of five numbers. Use console to display the result.
int aa = -5;
int bb = -2;
int cc = -6;
int dd = 0;
int ee = -1;
if ((aa >= bb) && (aa >= cc) && (aa >= dd) && (aa >= ee))
{
    Console.WriteLine("The biggest number is: {0}", aa);
    return;
}
if ((bb >= aa) && (bb >= cc) && (bb >= dd) && (bb >= cc))
{
    Console.WriteLine("The biggest number is: {0}", bb);
    return;
}
if ((cc >= aa) && (cc >= bb) && (cc >= dd) && (cc >= ee))
{
    Console.WriteLine("The biggest number is: {0}", cc);
    return;
}
if ((dd >= aa) && (dd >= bb) && (dd >= cc) && (dd >= ee))
{
    Console.WriteLine("The biggest number is: {0}", dd);
    return;
}
if ((ee >= aa) && (ee >= bb) && (ee >= cc) && (ee >= dd))
{
    Console.WriteLine("The biggest number is: {0}", ee);
    return;
}

Console.WriteLine("-----------------------------------------------");
// Write a C# program that converts kilometers per hour to miles per hour.  
Console.WriteLine("Please enter kilometers:");
double kilometers = Convert.ToDouble(Console.ReadLine());
double miles = kilometers / 1.6;
Console.WriteLine(miles + " Miles");

Console.WriteLine("-----------------------------------------------");
//Write a C# program that takes hours and minutes as input and calculates the total number of minutes.
Console.WriteLine("Please enter hours:");
double hours = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter minutes:");
double minutes = Convert.ToDouble(Console.ReadLine());
double total = hours * 60 + minutes;
Console.WriteLine(total);

Console.WriteLine("-----------------------------------------------");
//Write a program in C# that takes minutes as input and display the total number of hours and minutes. 
Console.WriteLine("Please enter minutes:");
int minutess = Convert.ToInt32(Console.ReadLine());
int hourss = minutess / 60;
minutess = minutess % 60;
Console.WriteLine("Hours : " + hourss);
Console.WriteLine("minutes :" + minutess);

Console.WriteLine("-----------------------------------------------");
//Create string of array that contains 5 element of different sentence with different length .
//Print all elements with fixed length for each sentence.
string[] array = { "raghad", "mohammad", "hazeem", "ahmad", "alrashdan" };
Console.WriteLine("the length of (raghad) is :" + array[0].Substring(0, 3));
Console.WriteLine("the length of (mohammad) is :" + array[1].Substring(0, 3));
Console.WriteLine("the length of (hazeem) is :" + array[2].Substring(0, 3));
Console.WriteLine("the length of (ahmad) is :" + array[3].Substring(0, 3));
Console.WriteLine("the length of (alrashdan) is :" + array[4].Substring(0, 3));


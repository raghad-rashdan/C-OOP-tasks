// See https://aka.ms/new-console-template for more information
//task1
using System.Runtime.Intrinsics.X86;


static void MyMethod()
{
    float sum = 0;
    float avg = 0;
    for (int i = 1; i <= 10; i++)
    {
         sum = sum + i;
         avg = sum / i;
    }

    Console.WriteLine(" the sum of nnmber is :" + sum);
    Console.WriteLine(" the sum of nnmber is :" + avg);

}
MyMethod();
Console.WriteLine("--------------------------------");

//task2



//task3




//task4


//task5
string chickens;
chickens= Convert.ToInt32(Console.ReadLine());

// See https://aka.ms/new-console-template for more information


//task 1 :Create console application that read string from user and print the same string
string yourName;
yourName = Console.ReadLine();

Console.WriteLine("My name is : " + yourName);

Console.WriteLine("------------------------------------------");

// task 2 : Define variables with kind of (string / int/char/double/bool)
const string name = "Raghad";
int age = 25;
char First_char = 'R';
double weight = 55.5;
bool ror=true;
 Console.WriteLine("My name is : " + name);
Console.WriteLine("age  : " + age);
Console.WriteLine("first char of name is : " + First_char);
Console.WriteLine("weight : " + weight);
Console.WriteLine("bool : " +  ror);

Console.WriteLine("------------------------------------------");

//task 3 : Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

Console.WriteLine("------------------------------------------");

// task 4 : Write a program in C that reads a first ename, surname and year of birth and display the names and the year one after another sequentially. Go to the editor
Console.Write("Input your firstname: ");
string firstName;
firstName = Console.ReadLine();
Console.WriteLine();
Console.Write("Input your lastname: ");
string lastname;
lastname = Console.ReadLine();
Console.WriteLine();
Console.Write("Input your year of birth: ");
string birth;
birth = Console.ReadLine();

Console.WriteLine(firstName + lastname + birth);


Console.WriteLine("------------------------------------------");
// task 5 : Write a program in C # to store elements in an array and print it. 
string[] num = new string[10];

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine("Enter a number ");
    num[i] = Console.ReadLine();
}

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");

}

Console.ReadLine();


Console.WriteLine("------------------------------------------");
// task 6: Write a program in C# to find the sum of all elements of the array.
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];

}
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i] + " ");

}
Console.WriteLine("the sum  of  number is : " + sum);
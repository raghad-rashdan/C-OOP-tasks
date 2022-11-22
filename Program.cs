//// See https://aka.ms/new-console-template for more information

////task1: Correct the syntax error:
////string[] ARR = [1, 7  9  45, ]
////string[] ARR = {1, 7, 9, 45};

////int arr2 =["Str" "alex","moh"
////int[] arr2 ={"Str" ,"alex", "moh"};

////string arr3= 'the','fox' 'over' lazy, 'dog',]
////string[] arr3= { "the","fox", "over","lazy", "dog"};


//// task 2: What the index of "Banana","Tomato"?
////String [ ] fruits =["Tomato", "Banana", "Watermelon"]
////correct : String [] fruits ={"Tomato", "Banana", "Watermelon"};
////index of "Banana" = 1
////index of "Tomato"=0

////task3: Create an multiple arrays that represents your:
//using System.ComponentModel;

//string[] food = { "Pizza", "Ice Cream", "Fried Chicken", "Hamburgers", "Bacon" };
//string[] Sport = { "Tennis", "Football", "Soccer" };
//string[] Movie = { "Peter Pan", "Lilo & Stitch", "Wreck-It-Ralph", "Frozen" };

//for (int x = 0; x < food.Length; x++)
//{
//    Console.WriteLine(food[x]);
//}
//Console.WriteLine("..................................");

//foreach (string y in food)
//{
//    Console.WriteLine(y);
//}
//Console.WriteLine("..................................");

//for (int z = 0; z < Sport.Length; z++)
//{
//    Console.WriteLine(Sport[z]);
//}
//Console.WriteLine("..................................");
//foreach (string w in Sport)
//{
//    Console.WriteLine(w);
//}
//Console.WriteLine("..................................");
//for (int q = 0; q < Movie.Length; q++)
//{
//    Console.WriteLine(Movie[q]);
//}
//Console.WriteLine("..................................");

//foreach (string e in Movie)
//{
//    Console.WriteLine(e);
//}


//Console.WriteLine("----------------------------------------------------------");
////task4 : Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
//Console.WriteLine("Enter three numbers seperated by comma ");

//string num = Console.ReadLine();

//string[] nums = num.Split('/');

//int suum = 0;

//foreach (string p in nums)
//{
//    suum += Convert.ToInt32(p);
//}

//Console.WriteLine("sum:" + suum);


Console.WriteLine("----------------------------------------------------------");
//task 5 : Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
int i, n, summ = 0;
Console.WriteLine("Input number of terms : ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The odd numbers are :");
for (i = 1; i <= n; i++)
{
    Console.Write("{0} ", 2 * i - 1);
    summ += 2 * i - 1;
}
Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1} ", n, summ);

Console.WriteLine("----------------------------------------------------------");
//task6:Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
int b = 3;
for (int d = 1; d <= 4; d++)
{
    for (int m = b; m >= 1; m--)
    {
        Console.Write(" ");

    }
    for (int k = 1; k <= d; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    b--;
}

Console.WriteLine("----------------------------------------------------------");
//task7:  Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
int o = 3;
for (int l = 1; l <= 4; l++)
{
    for (int v = o; v >= 1; v--)
    {
        Console.Write(" ");

    }
    for (int k = 1; k <= l; k++)
    {
        Console.Write(k+" ");
    }
    Console.WriteLine();
    o--;
}


Console.WriteLine("----------------------------------------------------------");
//Write a program in C# to calculate the AVG of unlimited numbers that are not redundant

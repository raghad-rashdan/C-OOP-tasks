// See https://aka.ms/new-console-template for more information

using System.Numerics;

class person
{
    private int age;
    public string gender="female";
    public string name;
    public string email;
    public int id;
    public string phone;


    //constructor age
   public person(int agee)
    {
        if(agee>=18 && agee <= 60)
        {
            age = agee;
            Console.WriteLine("my age is :" + agee);

        }
        else
        {
            Console.WriteLine(" age not available");

        }
    }
    // method phone
   public void check_phone(string p)
        {
        phone = p;

        if (p[0] == '0' && p[1] == '7' && p[2] == '7')
        {
            Console.WriteLine(p+" phone number is valid");
            
        }
       else if (p[0] == '0' && p[1] == '7' && p[2] == '8')
        {
            Console.WriteLine(p + " phone number is valid");

        }
      else  if (p[0] == '0' && p[1] == '7' && p[2] == '9')
        {
            Console.WriteLine(p + " phone number is valid");

        }
        else
        {
            Console.WriteLine( " phone number is not valid");
        }

    }

 //class main
    static void Main(string[] args)
    {
        person per1 = new person(100);
        per1.name = "raghad";
        per1.email = "raghad@gmail.com";
        per1.id = 27;

        Console.WriteLine("my name is :" +per1.name);

        Console.WriteLine("gender :" + per1.gender);
        Console.WriteLine("my ID is :" + per1.id);
        Console.WriteLine("my email is :" + per1.email);
       
        per1.check_phone("07952568545");






    }



}

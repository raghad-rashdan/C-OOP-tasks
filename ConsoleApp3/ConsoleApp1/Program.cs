using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using other_name_space;

namespace name_space
{
    public class Program
    {
        static void Main(string[] args)
        {


            other_name_space.nameclass myobj = new other_name_space.nameclass();

            Console.WriteLine("group name : "+myobj.name);
            Console.WriteLine("group id : " + myobj.id);

        }
    }

}

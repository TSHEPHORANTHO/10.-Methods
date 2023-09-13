using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            Console.WriteLine(AddNumbers());


            //read
            Console.ReadLine();
        }



        static void SayHi()
        {
            Console.WriteLine("Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
        static int AddNumbers()
        {
            Console.WriteLine("Enter Birth Year");
            int Birthyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current year");
            int Currentyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age");
            return  Currentyear -Birthyear;




        }
    }
}


 

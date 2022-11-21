using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = 2.555;
            string str = "Ashraf";
            char cha = 'A';
            bool boo = false;
            int x = 55;
            const int zz= 66;
            Console.WriteLine("number:" + y);
            Console.WriteLine("string:" + str);
            Console.WriteLine("char:" + cha);
            Console.WriteLine("bool:" + boo);
            Console.WriteLine("int:" + x);
            Console.WriteLine("number:" + y);
            Console.WriteLine("const:" + zz);

            // Task 2

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //Task 3


            Console.WriteLine("enter your firstname :");
            string firstname = Console.ReadLine();


            Console.WriteLine("enter your lastname :");
            string lastname = Console.ReadLine();

            Console.WriteLine("enter your year of birth :");
            string birth = Console.ReadLine();

           Console.WriteLine(  firstname , lastname , birth);

            // Task 4
            int[] num = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);


            // task5 
            int[] elemant = { 2, 5, 8 };

            Console.WriteLine(elemant[0] + elemant[1] + elemant[2]);
            

            







        }
    }
}

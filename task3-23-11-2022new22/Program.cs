using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task3_23_11_2022new22
{
    internal class Program
    {
        static void task1()

        {

            Console.WriteLine("please enter 10 number");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int y = Int32.Parse(Console.ReadLine());
                Console.WriteLine("number" + i + "= " + y);
                sum += y;
            }
            Console.WriteLine("sum =" + sum);
            Console.WriteLine("avg =" + sum / 10);

        }
        static void task2()
        {
            Console.WriteLine("please enter number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number is :" + y + "and the cube is :" + y * y * y);


        }
        static void task3(int[] array)
        {
            foreach (int x in array)

            {
                if (x > 1950) Console.WriteLine(" the year " + x + "is greater than 1950");
            }
        }
        static int task4(int x)
        {
            Console.WriteLine("the age is :" + x);
            return x * 365;

        }

        static int task5(int x, int y, int z)
        {
            int legs = x * 2 + y * 4 + z * 4;
            return legs;
        }

        static void task6()
        {
            string[] userName = { "ashraf", "shwayat" };
            string[] passWord = { "123456", "78910" };
            Console.WriteLine("please enter your username ");
            string user = Console.ReadLine();
            Console.WriteLine("please enter your password ");
            string pass = Console.ReadLine();
            if ((user == userName[0] && pass == passWord[0]) || (user == userName[1] && pass == passWord[1]))
            {
                Console.WriteLine("log in pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }


        static void task7()
        {
            Console.WriteLine("please enter your number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is : " + y + "and the power is " + y * y);

        }

        static void task8()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year <= 2024 && Year >= 1900)
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
                else Console.WriteLine("{0} is not a Leap Year.", Year);
            }
        }

        static void task9()
        {
            Console.WriteLine("please enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");



            }
        }
        static int numberOfChar(string words)
        {
            int counter = 1;
            string wordAfterTrim = words.Trim();
            foreach (char i in wordAfterTrim)
            {

                if (i == ' ')
                {
                    counter++;
                }

            }
            return counter;
        }


        static void Main(string[] args)
        {
            task1();
            task2();


            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            task3(years);




            Console.WriteLine("please enter age");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age in days =  " + task4(y));

            Console.WriteLine("please enter of chickens");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter of cows");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter of pigs");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of legs in farm = " + task5(chickens, cows, pigs));

            task6();

            task7();

            task8();
            task9();


            Console.Write("enter sentence to know how many words in it: ");
            string wordToCheck = Console.ReadLine();
            int counterForChar = numberOfChar(wordToCheck);
            Console.WriteLine($"the number of Words in sentence are: {counterForChar}");

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_21_11
{
    internal class task1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first num:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter secand num:");
            //int num2 = Convert.ToInt32(Console.ReadLine());



            //if (num2 > num1)
            //{
            //    Console.WriteLine("the smaller number :" +num1);
            //}
            //else
            //{
            //    Console.WriteLine("the smaller number :" +num2);
            //}




            //Task 2 --------------------------------------------------------------------------

            //Console.WriteLine("Enter your num:");
            //int number = Convert.ToInt32(Console.ReadLine());

            // if (number<0)
            // {
            //    Console.WriteLine("the number is  minus:" + number);
            // }
            // else
            // {
            //    Console.WriteLine("the numer is positive :" + number);
            // }


            // task 3 *******************************************************************************************

            // Console.WriteLine("Enter your num1:");
            // int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your num1:");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your num1:");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //if (number2 > number1 && number2 > number3)

            //{
            //    if (number1 > number3)
            //    {
            //        Console.WriteLine(number2 + " " + number1 + " " + number3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(number2 + " " + number3 + " " + number1);

            //    }
            //}
            //else if (number1 > number2 && number1 > number3)

            //{
            //    if (number2 > number3)
            //    {
            //        Console.WriteLine(number1 + " " + number2 + " " + number3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(number1 + " " + number3 + " " + number2);

            //    }


            //}
            //else if (number3 > number1 && number3 > number2)

            //{
            //    if (number1 > number2)
            //    {
            //        Console.WriteLine(number3 + " " + number1 + " " + number2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(number3 + " " + number2 + " " + number1);

            //    }

            //}



            //task4 *************************************************************************************************************


            
            int a = -5;
            int b = -2;
            int c = -6;
            int d = 0;
            int e = -1;

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("the max number is :" + a);
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("the max number is :" + b);
            }

            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("the max number is :" + c);
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("the max number is :" + d);

            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("the max number is :" + d);
            }

            //task5 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("Enter number in kilometers");
            double t5num = Convert.ToDouble(Console.ReadLine());
            t5num = t5num * 0.62137119;
            Console.WriteLine($"Number in miles  {t5num}");

            //Task 6*******************************************************************************


            Console.WriteLine("Enter the number of hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hours * 60 + minutes);

            //Task 7*****************************************************************

            Console.WriteLine("Enter number of minutes");
            int t7min = Convert.ToInt32(Console.ReadLine());
            int temp = t7min % 60;
            Console.WriteLine(t7min / 60 + " Hours " + temp + " Minutes ");


            //Task 8*****************************************************************************************
            string[] strings = { "ashraf", "shwayat", "allli", "suiiii", "vbvfhv" };
            Console.WriteLine(strings[0].Substring(0, 1));
            Console.WriteLine(strings[1].Substring(0, 1));
            Console.WriteLine(strings[2].Substring(0, 1));
            Console.WriteLine(strings[3].Substring(0, 1));
            Console.WriteLine(strings[4].Substring(0, 1));


        }
    }
}

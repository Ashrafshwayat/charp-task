using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1 ==================================================================================================

            int[] ARR = { 1, 7, 9, 45 };

            string[] arr2 = { "Str", "alex", "moh" };

            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };



           // task2 ==========================================================================================

           String[] fruits ={ "Tomato", "Banana", "Watermelon"};
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));

           // task3 ==========================================================================================


           String[] Food = { "Tomato", "Banana", "Watermelon","mansaf","mansaf1"};

            foreach (string i in Food)
            {
                Console.WriteLine(i);
            }

            String[] Sport = { "football", "tenes", "basketball" };
            for (int x = 0; x < Sport.Length; x++)
            {
                Console.WriteLine(Sport[x]);
            }


            String[] Movie = { "preson-braek", "ashraf", "iss" };

            foreach (string i in Movie)
            {
                Console.WriteLine(i);
            }


            //task4=====================================================================================================


            int num1, num2, num3;

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            int totalNum = num1 + num2 + num3;
            Console.WriteLine(totalNum);

           // task5 =========================================================================================================
           int totalnum1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {

                    totalnum1 += i;

                }

            }

            Console.WriteLine(totalnum1);

            //task6======================================================================================================================

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4-i; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");

                }

                Console.WriteLine();
               
            }

            // task7==============================================================================================================
            int f = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4-i; j >0; j--)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j <= i; j++)
                {  

                    Console.Write(f + " ");
                    f++;
                }

                Console.WriteLine();
                
            }


            int k = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x <= i; x++)
                {

                    Console.WriteLine(k);
                    k++;
                }

            }
            Console.WriteLine();
        }

    }
}

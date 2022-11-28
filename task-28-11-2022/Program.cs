using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace task_28_11_2022
{
    class car
    {
        public int year;
        public int Price;
        public string Type;
        public string model;
        public string Pallet;
        public string color;
        public int letter;

        public car() { }
        public car(int year1, int Price1, string Type1, string model1, string Pallet1, string color1,int letter1)
        {
            year = year1;
            Price = Price1;
            Type = Type1;
            model = model1;
            Pallet = Pallet1;
            color = color1;
            letter = letter1;

    }
        public void start()
        {
            Console.WriteLine("engine start");
        }
        public void stop()
        {
            Console.WriteLine("engine stop");
        }

        public void kmPerLetter()
        {
            Console.WriteLine(letter * 18);
        }

    }

    class car2 : car
    {
        public car2(int year1, int Price1, string Type1, string model1, string Pallet1, string color1 , int letter1) 
        {
            year = year1;
            Price = Price1;
            Type = Type1;
            model = model1;
            Pallet = Pallet1;
            color = color1;
            letter = letter1;
        }
    }

    internal class Program
       
    {
        static void Main(string[] args)
        {
            car2 mycar = new car2(2002, 5000, "bmw", "5s", "64561-02","red" ,25);
            Console.WriteLine("the car year" + mycar.year);
            Console.WriteLine("the car Price" + mycar.Price);
            Console.WriteLine("the car Type" + mycar.Type);
            Console.WriteLine("the car model" + mycar.model);
            Console.WriteLine("the car Pallet" + mycar.Pallet);
            Console.WriteLine("the car color" + mycar.color);
            mycar.start();
            mycar.kmPerLetter();

            

        }
    }
}

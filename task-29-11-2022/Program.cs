using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_29_11_2022;

namespace task_29_11_2022
{
    class  employee
    {

        public string name;
        public int  birth ;
        public int ID;

        public employee() { }
        public  employee(string name1 , int birth1, int ID1)
        {
            name = name1;
            birth = birth1;
            ID = ID1;


        }
     

        public virtual void age()
        {
            Console.WriteLine(birth);
        }

    }

      class employee2 : employee
    {
        public employee2(string name1, int birth1, int ID1)
        {
            name = name1;
            birth = birth1;
            ID = ID1;


        }
        public override void age()
        {
            Console.WriteLine(2022 - birth);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            employee2 employeeNam = new employee2("Ashraf",1998,998106565);
            Console.WriteLine("thethe Employee’s name " +"   " +employeeNam.name);
            Console.WriteLine("birth of date is" +"  " +employeeNam.birth);
            Console.WriteLine("Employee ID is" +"  "+ employeeNam.ID);

            employeeNam.age();



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_27_11_2022_new
{
    internal class Program
    {
        class personal
        {
            private int age;
            private string gender;
            private string name;
            private string email;
            private string id;
            private string phone;

            public personal(int myAge, string myGender, string myName, string myEmail, string myId, string myPhone)
            {

                if (myAge <= 18 || myAge >= 60)
                {
                    Console.WriteLine("Your age is outside the allowed range");
                }

                else
                {
                    age = myAge;
                }

                gender = myGender;
                name = myName;
                email = myEmail;
                id = myId;
                phone = myPhone;

                string keyNum = myPhone.Substring(0, 3);
                if (keyNum != "077" || keyNum != "078" || keyNum != "079")
                {
                    Console.WriteLine("The phone number is wrong");
                }
                else
                {
                    phone = myPhone;
                }
            }

            public void PersonalInfo()
            {
                Console.WriteLine("Age : " + age);
                Console.WriteLine("Gender : " + gender);
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Email : " + email);
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Phone : " + phone);
            }
        }
        static void Main(string[] args)
        {
            personal myInfo = new personal(23, "Male", "ashraf", "ashrafshwayat16@gmail.com", "123456", "0772222222");
            myInfo.PersonalInfo();
        }
    }
}

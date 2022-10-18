using System;
using System.Xml.Linq;

namespace adnanCryptologyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.Write("Name enter: ");//muhmammedadnanalahmed@gmail.com
            Name = Console.ReadLine();

            string Surname;
            Console.Write("Surname Enter: ");
            Surname = Console.ReadLine();
            Console.WriteLine("****************************************** ");
            Console.WriteLine("As The Name is Entered :\n Name : {0}\nSurname : {1}\n****************************************** ", Name, Surname);
            Console.WriteLine("Lowercase Name :\n Name : {0}\nSurname : {1}\n******************************************", Name.ToLower(), Surname.ToLower());
            Console.WriteLine("Capital Letter Name :\n Name : {0}\nSurname : {1}\n******************************************", Name.ToUpper(), Surname.ToUpper());

            concat(Name, Surname);
        }

        static void concat(string Name, string Surname)
        {
            Int32[] Rastgelesifre = new Int32[5];
            Random num = new Random();
            for (int a = 0; a < 5; a++)
            {
                Rastgelesifre[a] = num.Next(0, 10000);
            }

            Console.WriteLine("encrypted Name Surname: " + string.Concat(Rastgelesifre[0], Name.ToUpper(),Rastgelesifre[1],
                Rastgelesifre[2] + Surname.ToUpper() + Rastgelesifre[3]) + "\n******************************************");
            Console.ReadKey();
        }

    }
}
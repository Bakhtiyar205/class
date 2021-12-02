using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string mail = "salam@gmail.com";
            string password = "12345";
            if (mail == "cavid@gmail.com " && password == "12345")
            {
                Console.WriteLine("Girish olundu");
            }
            else
            {
                Console.WriteLine("Mail ve ya password sehvdir");
            }
        }


    }
}

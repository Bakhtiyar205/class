using System;

namespace class_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Saleh";
            st1.surname = "Agayev";
            st1.age = 24;
            st1.address = "Nizami rayonu";
            Console.WriteLine(st1.FullData());
        }
    }
}

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial ftr = new Factorial();
            var c = ftr.Multiple(5);
            if (c > 0)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("The number is minus or zero");
            }

            
        }
    }
}

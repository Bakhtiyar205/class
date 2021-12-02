using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class Factorial
    {
        
        
        public int Multiple(int n)
        {
            var multiple = 1;
            for (int i = n; i > 0; i--)
            {
                multiple *= i;
            }
            return multiple;
        }
    }
}

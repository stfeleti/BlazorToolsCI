using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToolsCI.Tools
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        

        public int Div(int a, int b)
        {
            if (b == 0)
                return -20108330;
            return a / b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return 1;
        }
    }
}

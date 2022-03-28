using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebProject
{
    public class SimpleClass
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

        }

        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Multiply(int num1, int num3)
        {
            int result = num1 * num3;
            return result;
        }
    }
}

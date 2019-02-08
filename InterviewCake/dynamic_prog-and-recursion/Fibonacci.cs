using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.dynamic_prog_and_recursion
{
    class Fibonacci
    {
        public int Calculate(int n)
        {
            return GetFibonacci(n);
        }

        private int GetFibonacci(int n)
        {
            if (n < 0)
                return 0;

            if (n == 1)
                return 1;

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}

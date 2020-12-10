using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> o = (p, n, r) => p * n * r / 100;

            Func<int, int, bool> o1 = (a, b) => a > b;

            Func<Employee, decimal> o3 = emp => emp.Basic;

            Predicate<int> o4 = x => x % 2 == 0;

            Predicate<Employee> o5 = emp => emp.Basic > 10000;
        }
    }
}

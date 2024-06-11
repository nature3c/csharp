using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calc {
    internal class Program {
        static void Main(string[] args) {
            int a, b;
            int result;

            a = 100;
            b = 50;

            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result);

            result = a - b;
            Console.WriteLine(a + "-" + b + "=" + result);

            result = a * b;
            Console.WriteLine(a + "*" + b + "=" + result);

            result = a / b;
            Console.WriteLine(a + "/" + b + "=" + result);
        }
    }
}

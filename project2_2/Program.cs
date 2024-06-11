using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project2_2 {
    internal class Program {
        static void Main(string[] args) {
            int a, b;
            int result;

            string str;

            Console.Write("Please input the first number: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Please input the second number: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

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

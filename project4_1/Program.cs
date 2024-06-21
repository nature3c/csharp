using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //project4_1
            //int num;
            //int v1 = 5, v2 = 3;

            //num = v1 + v2;
            //Console.WriteLine("{0:D} + {1:D} = {2:D}", v1, v2, num);

            //num = v1 - v2;
            //Console.WriteLine("{0:D} - {1:D} = {2:D}", v1, v2, num);

            //num = v1 * v2;
            //Console.WriteLine("{0:D} * {1:D} = {2:D}", v1, v2, num);

            //num = v1 / v2;
            //Console.WriteLine("{0:D} / {1:D} = {2:D}", v1, v2, num);

            //num = v1 % v2;
            //Console.WriteLine("{0:D} % {1:D} = {2:D}", v1, v2, num);

            //project4_3
            //string s1 = "100", s2 = "100.23";
            //Console.WriteLine(int.Parse(s1) + float.Parse(s2)); //convert string to int and double respectively

            //int n1 = 100;
            //float n2 = 100.123f;
            //Console.WriteLine(n1.ToString() + n2.ToString()); //convert both into a string and print side by side

            //exercise1
            //int money;
            //int c500, c100, c50, c10;

            //Console.Write("Please input the money value: ");
            //money = int.Parse(Console.ReadLine());

            //c500 = money / 500;
            //money = money % 500;

            //c100 = money / 100;
            //money %= 100;

            //c50 = money / 50;
            //money %= 50;

            //c10 = money / 10;
            //money %= 10;

            //Console.WriteLine("\n500 won coins: " + c500 + " coin(s)");
            //Console.WriteLine("\n100 won coins: " + c100 + " coin(s)");
            //Console.WriteLine("\n50 won coins: " + c50 + " coin(s)");
            //Console.WriteLine("\n10 won coins: " + c10 + " coin(s)");
            //Console.WriteLine("\nLeftover money: " + money + " won\n");

            //project4_15
            int n = 10;
            Console.WriteLine((n >> 1) + "," + (n >> 2) + "," + (n >> 3) + "," + (n >> 4));
        }
    }
}

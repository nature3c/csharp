using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int i;
            //    for(i=0;i<3;i++)
            //    {
            //        Console.WriteLine("Hello?");
            //        Console.WriteLine("##Hello Again?##");
            //    }

            //    Console.WriteLine();

            //    for (i=0;i<3;i++)
            //    {
            //        Console.WriteLine("Hello?");
            //        Console.WriteLine("##Hello Again?##");
            //    }

            //int hap;
            //hap = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
            //Console.WriteLine("Sum 1-10: {0:D}", hap);

            int hap = 0;
            for (int i = 0; i < 11; i++) {
                hap += i;
            }
            Console.WriteLine("Sum 1-10: {0:D}", hap);
        }
    }
}

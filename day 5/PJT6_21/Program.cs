using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT6_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //gave up naming the projects w the class

            //proj1
            //int hap = 0;

            //for (int i = 501; i <= 1000; i += 2)
            //{
            //    hap += i;
            //}

            //Console.WriteLine("Sum of even numbers from 500-1000: {0}", hap);

            //proj2
            //int hap = 0;
            //int num;

            //Console.Write("Insert a number: ");
            //num = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= num; i++)
            //{
            //    hap += i;
            //}
            //Console.WriteLine("The sum of the numbers between 1-{0} = {1}", num, hap);

            //proj3
            //int sum = 0;
            //int start, end, increment;

            //Console.Write("Start value: ");
            //start = int.Parse(Console.ReadLine());
            //Console.Write("End value: ");
            //end = int.Parse(Console.ReadLine());
            //Console.Write("Increment: ");
            //increment = int.Parse(Console.ReadLine());

            //for(int i = 0;i <= end; i += increment)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Sum of {0} to {1} with an increment of {2}: {3}", start, end, increment, sum);


            //proj3
            //int num;

            //Console.Write("Input a number: ");
            //num = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2,2:D}", num, i, num * i);
            //}

            //string guguLine = "";

            //for (int i = 2; i < 10; i++)
            //{
            //    guguLine = guguLine + (" #" + i + "#   ");
            //}
            //Console.WriteLine(guguLine);

            //for (int i = 2; i < 10; i++)
            //{
            //    guguLine = ""; 

            //    for (int j = 2; j < 10; j++)
            //    {
            //        guguLine = guguLine + String.Format("{0}x{1}={2,2:D} ", j, i, j * i);
            //    }
            //    Console.WriteLine(guguLine);
            //}

            //proj4
            //int hap = 0;
            //int i;

            //i = 1;
            //while(i <= 10)
            //{
            //    hap += 1;
            //    i++;
            //}

            //Console.WriteLine("Sum of numbers 1 - 10: {0}", hap);

            //proj5
            //int num1, num2;
            //while (true)
            //{
            //    Console.Write("Input a number: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Input another number: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            //}

            //proj6 FIX THIS IT DOESNT WORK
            //double max = double.MaxValue;
            //double min = double.MinValue;
            //double sum = 0;

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.Write("Height in cm: ");
            //    double h;
            //    while (!double.TryParse(Console.ReadLine(), out h)) ;

            //    if (h > max) max = h;
            //    if (h < min) min = h;
            //    sum += h;
            //}

            //double average = sum / 5;
            //Console.WriteLine($"Average: {average}cm, Max: {max}cm, Min: {min}cm");

            //proj7
            //int num;
            //int i;

            //Console.Write("Input a number: ");
            //num = int.Parse(Console.ReadLine());

            //for(i = 2; i < num; i++)
            //{
            //    if(num % i == 0) 
            //    {
            //    Console.WriteLine("{0} is a multiple", i);
            //    }
            //}

            //if (i == num)
            //{
            //    Console.WriteLine("{0} is a multiple", i);
            //}

            //proj8
            //int index;
            //int primes = 0;

            //for(int i = 2; i < 1000; i++)
            //{
            //    for(index = 2; index < i; index++)
            //    {
            //        if (i % index == 0)
            //            break;
            //    }
            //    if(index == i)
            //    {
            //        primes++;
            //        Console.Write("{0, 5}{1}", i, primes % 15 == 0 ? "\n" : "");
            //    }
            //}
            //Console.WriteLine("\nNumber of prime numbers from 2 to 1000: {0}", primes);

            //int num1, num2;
            //while (true)
            //{
            //    Console.Write("Input a number: ");
            //    num1 = int.Parse(Console.ReadLine());

            //    if (num1 == 0)
            //        break;

            //    Console.Write("Input another number: ");
            //    num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            //}
            //Console.WriteLine("Escaped sequence because input 0");

            //★
            int i, j;

            i = 0;
            while (i < 0)
            {
                if(i < 5)
                {
                    j = 0;
                    while ( j < 4 - i)
                    {
                        Console.Write(" ");
                        j += 1;
                    }
                    j = 0;
                    while (j < i * 2 + 1)
                    {
                        Console.Write('\u2605');
                        j += 1;
                    }
                } 
                else
                {
                    j = 0;
                    while(j < i - 4)
                    {
                        Console.Write(" ");
                        j += 1;
                    }
                    j = 0;
                    while(j < (9 - i) * 2 - 1)
                    {
                        Console.Write('\u2605');
                        j += 1;
                    }
                }
                Console.WriteLine();
                i += 1;
            }


        }
    }
}

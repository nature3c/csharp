using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7_1
            //int a, b, c, d;
            //int hap;

            //Console.Write("Input a number: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Input the second number: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Input the third number: ");
            //c = int.Parse(Console.ReadLine());
            //Console.Write("Input the fourth number: ");
            //d = int.Parse(Console.ReadLine());

            //hap = a + b + c + d;
            //Console.WriteLine("Sum ==> {0}", hap);


            //7_2
            //int[] aa = new int[4];
            //int hap;

            //Console.Write("Input a number: ");
            //aa[0] = int.Parse(Console.ReadLine());
            //Console.Write("Input the second number: ");
            //aa[1] = int.Parse(Console.ReadLine());
            //Console.Write("Input the third number: ");
            //aa[2] = int.Parse(Console.ReadLine());
            //Console.Write("Input the fourth number: ");
            //aa[3] = int.Parse(Console.ReadLine());

            //hap = aa[0] + aa[1] + aa[2] + aa[3];
            //Console.WriteLine("Sum ==> {0}", hap);

            //7_3
            //Console.Write("Size of array: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] aa = new int[size];
            //int hap = 0;
            //int i = 0; //for while loop

            ////for (int i = 0; i <= size-1; i++)
            ////{
            ////    Console.Write("{0}st/nd/th number: ", i + 1);
            ////    aa[i] = int.Parse(Console.ReadLine());
            ////}

            ////for (int i = 0; i < size; i++)
            ////{
            ////    hap += aa[i];
            ////}

            //while(i <= size - 1)
            //{
            //    Console.Write("{0}st/nd/th number: ", i + 1);
            //    aa[i] = int.Parse(Console.ReadLine());
            //    i++;
            //}
            //i = 0;
            //while ( i < size )
            //{
            //    hap += aa[i];
            //    i++;
            //}


            //Console.WriteLine("The sum is {0}", hap);

            //7_4
            //int[] aa = { 100, 200, 300, 400 };
            //int[] bb = new int[] { 100, 200, 300 };
            //int[] cc;
            //cc = new int[] { 100, 200 };
            //int[] dd = new int[1];
            //dd[0] = 100;

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("aa[{0}] ==> [1] \t", i, aa[i]);
            //}
            //Console.WriteLine();

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("bb{0} ==> {1}\t", i, aa[i]);
            //    Console.WriteLine();
            //}

            //exercise 1-
            //int[] aa = new int[100];
            //int[] bb = new int[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    aa[i] = i * 2;
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    bb[i] = aa[99 - i];
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(aa[i] + " ");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(bb[i] + " ");
            //}

            //exercise 2 FIX THIS IT DOESNT WORK
            //int[] aa = new int[50];
            //int[] bb = new int[50];

            //for(int i = 0; i < 50; i++)
            //{
            //    aa[i] = i * 3;
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    if( i >= 48)
            //        bb[i] = aa[i - 48];
            //    else
            //        bb[i] = aa[i + 2];
            //}

            //for (int i = 0; i < 50; i++)
            //{
            //    Console.Write(aa[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.Write(bb[i] + " ");
            //}
            //Console.WriteLine();

            //7_6
            //double[] aa = { 10, 20, 30, 40, 50 };
            //double[] aa = new double[5]; //both give a size value of 5
            //int count, size;

            //count = aa.Length;
            //size = count * sizeof(double);

            //Console.WriteLine("The number of values in aa is {0}", count);
            //Console.WriteLine("The memory size of aa is {0}", size);

            //7_7
            //int[] aa = { 10, 20, 30 };

            //Console.WriteLine("Size of array => {0}", aa.Length);
            //Console.Write("Contents of array => ");
            //for(int i = 0; i < aa.Length; i++)
            //{
            //    Console.Write("{0, 3:D}", aa[i]);
            //}
            //Console.WriteLine();

            //Array.Resize(ref aa, 5); //changes contents, changes array size to 5

            //Console.WriteLine("New array size => {0}", aa.Length);
            //Console.Write("New array content => ");
            //for(int i = 0;i < aa.Length;i++)
            //{
            //    Console.Write("{0, 3:D}", aa[i]);
            //}
            //Console.WriteLine();

            //used to print all the data in an array
            //int[] aa = {10,20,30};
            //foreach (int data in aa)
            //    Console.WriteLine(data);

            //int[] a = new int[0];
            //int sum = 0;
            //double average = 0;

            //while(true)
            //{
            //    Console.Write("Input a number: ");
            //    int input = int.Parse(Console.ReadLine());

            //    if (input == 0)
            //    {
            //        break;
            //    } else
            //    {
            //        Array.Resize(ref a, a.Length + 1);
            //        a[a.Length - 1] = input;
            //    }
            //}

            //foreach (int data in a)
            //{
            //    sum += data;
            //}

            //average = (double) sum / a.Length;

            //Console.WriteLine("Sum: {0}", sum);
            //Console.WriteLine("Average: {0}", average);

            //manual
            //int[,] ary = new int[3, 4];

            //ary[0,0] = 1; ary[0,1] = 2; ary[0,2] = 3; ary[0,3] = 4;
            //ary[1,0] = 5; ary[1,1] = 6; ary[1,2] = 7; ary[1,3] = 8;
            //ary[2, 0] = 9; ary[2,1] = 10; ary[2,2] = 11; ary[2,3] = 12;

            //Console.WriteLine("Output of ary[0,0] to ary[3,4]");

            //Console.WriteLine("{0,3:D} {1,3:D} {2,3:D} {3,3:D}", ary[0, 0], ary[0, 1], ary[0, 2],  ary[0,3]);
            //Console.WriteLine("{0,3:D} {1,3:D} {2,3:D} {3,3:D}", ary[1, 0], ary[1, 1], ary[1, 2], ary[1, 3]);
            //Console.WriteLine("{0,3:D} {1,3:D} {2,3:D} {3,3:D}", ary[2, 0], ary[2, 1], ary[2, 2], ary[2, 3]);

            //loops
            //int[,] ary = new int[3, 4];
            //int value = 1;

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        ary[i, j] = value;
            //        value++;
            //    }
            //}

            //Console.WriteLine("Output of ary[0,0] to ary[3,4]");
            //for(int i = 0; i < 3; ++i)
            //{
            //    for(int j = 0; j < 4; ++j)
            //    {
            //        Console.Write(ary[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //exercise
            //int[,] ary = new int[4, 5];
            //int value = 1;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        ary[i, j] = value;
            //        value += 2;
            //    }
            //}

            //Console.WriteLine("Output of ary[0,0] to ary[3,4]");
            //for (int i = 0; i < 4; ++i)
            //{
            //    for (int j = 0; j < 5; ++j)
            //    {
            //        Console.Write(ary[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 3; i >= 0; i--)
            //{
            //    for (int j = 4; j >= 0; j--)
            //    {
            //        Console.Write(ary[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //exercise
            //int[,] ary = new int[4, 5];
            //int value = 1;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        ary[i, j] = value;
            //        value += 2;
            //    }
            //}

            //Console.Write("Row: ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Column: ");
            //int col = int.Parse(Console.ReadLine());

            //int result = ary[row, col];

            //Console.WriteLine("The value there is: {0}", result);

            //exercise
            //Console.Write("Row: ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Column: ");
            //int col = int.Parse(Console.ReadLine());

            //int[,] ary = new int[row, col];
            //int value = 1;

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        ary[i, j] = value;
            //        value += 2;
            //    }
            //}

            //Console.WriteLine("Output");
            //for (int i = 0; i < row; ++i)
            //{
            //    for (int j = 0; j < col; ++j)
            //    {
            //        Console.Write(ary[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //exercise
            //int[,] a = new int[3, 4];
            //int value = 1;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        a[i, j] = value;
            //        value ++;
            //    }
            //}

            //int[,,] b = new int[2, 3, 4];
            //value = 1;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0;j < 3; j++)
            //    {
            //        for(int k = 0; k < 4; k++)
            //        {
            //            b[i, j, k] = value;
            //            value++;
            //        }
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 4; k++)
            //        {
            //            Console.Write(b[i, j, k] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            int[,,] apt = new int[5, 10, 6];

            while (true)
            {
                Console.Write("Building Floor Room: ");
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = input[0] - 1;
                int b = input[1] - 1;
                int c = input[2] - 1;

                if (apt[a,b,c] == 0)
                {
                    Console.WriteLine("Moved in");
                    apt[a, b, c] = 1;
                } else
                {
                    Console.WriteLine("Cannot move in");
                }
            }


        }
    }
}

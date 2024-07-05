using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl; //for files
//3 spaces represent a change in the problem
namespace PJT10
{
    internal class Program
    {
        //static void Func1(int a)
        //{
        //    a = a + 1;
        //    Console.WriteLine("Func1 a --> " + a);
        //}

        //static void Func2(ref int a)
        //{
        //    a = a + 1;
        //    Console.WriteLine("Func2 a --> " + a);
        //}



        //static void Swap1(int p, int g)
        //{
        //    int temp = p;
        //    p = g;
        //    g = temp;

        //    Console.WriteLine("Swap1 p = " + p + " g = " + g);
        //}

        //static void Swap2(ref int p, ref int g)
        //{
        //    int temp = p;
        //    p = g;
        //    g = temp;
        //    Console.WriteLine("Swap 2 p = " + p + " g = " + g);

        //}



        //static void Add1(int[] ary)
        //{
        //    for(int i = 0;i<ary.Length;i++)
        //    {
        //        ary[i] = ary[i] + 1;
        //    }
        //}



        //static void Largest(int[] input)
        //{
        //    int largest = input[0];
        //    for(int i = 0; i < input.Length; i++)
        //    {
        //        if(largest < input[i])
        //            largest = input[i];
        //    }
        //    Console.WriteLine("The largest is " + largest);
        //}

        //static void Smallest(int[] input)
        //{
        //    int smallest = input[0];
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (smallest > input[i])
        //            smallest = input[i];
        //    }
        //    Console.WriteLine("The smallest is " + smallest);
        //}



        //static int Counting(int[] ary, int value)
        //{
        //    int count = 0;
        //    for (int i = 0; i < ary.Length; i++)
        //    {
        //        if (ary[i] == value) count++;
        //    }
        //    return count;
        //}



        //static int Counting(int[] ary, int value)
        //{
        //    int count = 0;
        //    for(int i =0;i<ary.Length;i++)
        //    {
        //        if (ary[i] == value) count++;
        //    }
        //    return count;
        //}



        //static void Flip(int[] basket, int start, int end)
        //{
        //    // start = 1, end = 4
        //    // 1 <-> 4, 2 <-> 3 

        //    // start = 2, end = 4
        //    // 2 <-> 4, 3 <-> 3
        //    for (int i = start; i <= (start + end) / 2; i++)
        //    {
        //        int temp = basket[i];
        //        basket[i] = basket[end - i + start];
        //        basket[end - i + start] = temp;
        //    }
        //}

        static void Main(string[] args)
        {
            //int a = 10;
            //Func1(a);
            //Console.WriteLine("Main a --> " + a);
            //Func2(ref a);
            //Console.WriteLine("Main a --> " + a);

            //int p = 10, g = 20;
            //int temp = p;
            //p = g;
            //g = temp;
            //Console.WriteLine("Main p = " + p + " g = " + g);
            ////1) Call by Value
            //Swap1(p, g);
            ////2) Call by reference
            //Swap2(ref p, ref g);



            //int[] ary = { 10, 20, 30 };
            //Console.Write("Main: ");
            //for(int i =0;i<ary.Length;i++)
            //{
            //    Console.Write(ary[i] + " ");
            //}
            //Console.WriteLine();

            //Add1(ary);
            //Console.Write("Main: ");
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    Console.Write(ary[i] + " ");
            //}
            //Console.WriteLine();

            //Console.Write("Insert numbers: ");
            //int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //Largest(input);
            //Smallest(input);

            //Console.WriteLine();



            /*input 1: array size
            input 2: array elementgs
            input 3: number to count*/
            //Console.Write("Size: ");
            //int N = int.Parse(Console.ReadLine());
            //Console.Write("Elements: ");
            //int[] ary = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //Console.Write("Tracked number: ");
            //int v = int.Parse(Console.ReadLine());

            //Console.Write("That number showed up {0} times", Counting(ary,v));
            //Console.WriteLine();



            //Console.Write("Numbers: ");
            //int[] ary = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int[] rem = new int[ary.Length];
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    rem[i] = ary[i] % 42;
            //}
            //// 39 40 41 0 1 2 40 41 0 1

            //int count = 0;
            //for (int i = 0; i < 42; i++)
            //{
            //    if (Counting(rem, i) > 0) count++;
            //}
            //Console.Write("Unique numbers: ");
            //Console.WriteLine(count);



            //number of nums, number of flipped times
            //int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int n = input[0]; // 바구니의 개수
            //int m = input[1]; // 뒤집는 횟수

            //int[] basket = new int[n + 1]; // 0 1 2 3 4 5
            //for (int i = 1; i <= n; i++)
            //{
            //    basket[i] = i;
            //}
            //for (int i = 0; i < m; i++)
            //{
            //    input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //    int start = input[0];
            //    int end = input[1];
            //    Flip(basket, start, end);
            //}
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(basket[i] + " ");
            //}



            //9x9 arry find the number
            //int[,] arr = new int[9, 9];

            //Random rnd = new Random();

            //for (int i = 0;  i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rnd.Next(1, 99);
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("What number would you like the index of? >>> ");
            //int num = Console.Read();

            //for(int i  = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (num == arr[i,j])
            //        {
            //            Console.WriteLine("The number is at {0} {1}", i+1, j+1);
            //        }
            //    }
            //}



            //StreamReader inFp;
            //for methods 1 and 2
            //string inStr;
            //inFp = new StreamReader("D:\\andrew_C#\\PJT10\\data.txt");

            //first method
            //inStr = inFp.ReadLine(); //reads line
            //Console.WriteLine(inStr); //prints line

            //inStr = inFp.ReadLine();
            //Console.WriteLine(inStr);

            //inStr = inFp.ReadLine();
            //Console.WriteLine(inStr);

            //int count = 1;

            //second method
            //while (true) 
            //{
            //    Console.Write("{0}: ", count);
            //    inStr = inFp.ReadLine();
            //    if (inStr == null) break;
            //    Console.WriteLine(inStr);
            //    count++;
            //}

            //third method
            //string[] inStrAry = File.ReadAllLines("D:\\andrew_C#\\PJT10\\data.txt");

            //foreach(string inStr in inStrAry)
            //{
            //    Console.WriteLine(inStr);
            //}

            //inFp.Close(); //for methods 1 and 2

            //Console.WriteLine("Enter the full path of the file you want to read:");
            //string filePath = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine($"Contents of the file '{Path.GetFileName(filePath)}':");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine(File.ReadAllText(filePath));

            //diff file read exercise
            //Console.Write("File path: ");
            //string filename = Console.ReadLine();

            //if (File.Exists(filename))
            //{
            //    string[] inStrAry = File.ReadAllLines(filename);

            //    int count = 1;
            //    foreach (string line in inStrAry)
            //    {
            //        Console.WriteLine($"{count}/{inStrAry.Length} 행: {line}");
            //        count++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{filename} does not exist");
            //}

            StreamWriter outFp;
            string outStr;
            string fName;

            outFp = new StreamWriter("D:\\andrew_C#\\PJT10\\data2.txt");

            while (true)
            {
                Console.Write("Input data: ");
                outStr = Console.ReadLine();

                if (outStr != "")
                    outFp.WriteLine(outStr);
                else
                    break;
            }

            outFp.Close();
            Console.WriteLine("All done");
        }
    }
}

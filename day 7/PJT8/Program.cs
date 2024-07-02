using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[0]; //infinite array
            ////int[] number = new int[20]; //finite array
            //int top = 0;
            //int outNum;

            //while (true)
            //{
            //    Console.Write("Push(0), pop(1), view(2): ");
            //    int mode;
            //    if (!int.TryParse(Console.ReadLine(), out mode))
            //    {
            //        Console.WriteLine("Invalid Input");
            //        continue;
            //    }

            //    if (mode == 0)
            //    {
            //        //finite array
            //        //if (top < 20) //check if stack is not full
            //        //{
            //        //    Console.Write("Input a number to push: ");
            //        //    int input;
            //        //    if (int.TryParse(Console.ReadLine(), out input))
            //        //    {
            //        //        number[top] = input;
            //        //        Console.WriteLine("Push: " + number[top]);
            //        //        top++;
            //        //    }
            //        //    else
            //        //    {
            //        //        Console.WriteLine("Invalid Input");
            //        //    }
            //        //}
            //        //else
            //        //{
            //        //    Console.WriteLine("Stack overflow! Cannot push more elements.");
            //        //}

            //        //infinite array
            //        Array.Resize(ref number, number.Length + 1);
            //        Console.Write("Input a number to push: ");
            //        int input = int.Parse(Console.ReadLine());
            //        number[top] = input;
            //        Console.WriteLine("Push: " + number[top]);
            //        top++;
            //    }
            //    else if (mode == 1)
            //    {
            //        if (top > 0) //check if stack is not empty
            //        {
            //            top--;
            //            outNum = number[top];
            //            Console.WriteLine("Pop: " + outNum);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Stack underflow! Cannot pop from an empty stack.");
            //        }
            //    }
            //    else if (mode == 2)
            //    {
            //        foreach (int i in number)
            //        {
            //            Console.Write("{0}, ", i);
            //            Console.WriteLine();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input");
            //    }
            //}



            //string str = "IT Cookbook. C#";
            //int len;

            //len = str.Length;

            //Console.WriteLine("String: {0}", str);
            //Console.WriteLine("String length: {0}", len);

            //char[] cArray = { 'C', '#', ' ' };
            //string str = "C# Programming";
            //int len = str.Length;

            //Console.WriteLine("String: {0}", str);
            //Console.WriteLine("String length: {0}", len);
            //Console.WriteLine(cArray[0] + " " + str[0]);

            //Console.WriteLine();

            //for (int i = 0; i < len; i++)
            //{
            //    if (str[i] == 'm')
            //    {
            //        Console.Write('n');
            //    }
            //    else
            //    {
            //        Console.Write(str[i]);
            //    }
            //}
            //Console.WriteLine();



            //string str;

            //Console.Write("Insert Text ==> ");
            //str = Console.ReadLine();

            //Console.Write("New Text ==> ");

            //if (!str.StartsWith("("))
            //    Console.Write("(");

            //for(int i  = 0; i < str.Length; i++)
            //{
            //    Console.Write("{0}", str[i]);
            //}

            //if(!str.StartsWith(")"))
            //    Console.Write(")");

            //Console.WriteLine();


            //string str = "C# studying in progress, C# is fun, C# the best!";

            //Console.WriteLine("String ==> " + str);

            //Console.Write("First C# address ==> ");
            //Console.WriteLine(str.IndexOf("C#"));
            //Console.Write("Last C# address ==> ");
            //Console.WriteLine(str.LastIndexOf("C#"));


            //string str1 = "C# studying in progress... C# is the best. ^^";
            //string str2 = str1.Replace("C#", "C Sharp");
            //Console.WriteLine(str2);

            //str2 = str1.Substring(0, 2);
            //string str3 = str1.Substring(4);

            //string str1 = "IT,CookBook,C#";
            //string[] str2 = str1.Split(',');

            //foreach(string i in str2)
            //{
            //    Console.WriteLine(i);
            //}

            //string str = "ABCD efgh $#@!";

            //Console.WriteLine("Original string ==> [" + str + "]");
            //Console.WriteLine("Uppercase string ==> [" + str.ToUpper() + "]");
            //Console.WriteLine("Lowercase string ==> [" + str.ToLower() + "]");
            //Console.WriteLine("Trimmed  string ==> [" + str.Trim() + "]"); //trim removed whitespace

            //string str1 = "C# Programming";
            //string str2 = "C# IT Cookbook";

            //Console.WriteLine("Original string 1 ==> [" + str1 + "]");
            //Console.WriteLine("Original string 2 ==> [" + 2 + "]");
            //Console.WriteLine(str1.CompareTo(str2));
            //Console.WriteLine(str2.CompareTo(str1));

            //string str;
            //bool numYN = true;

            //Console.Write("Insert text: ");
            //str = Console.ReadLine();

            //Console.Write(str + " --> ");
            //foreach(char c in str)
            //{
            //    if (!Char.IsDigit(c))
            //        numYN = false;
            //}
            //if (!numYN)
            //    Console.WriteLine("is not a number");
            //else
            //    Console.WriteLine("is a number");

            //Console.Write("String input >>> ");
            //string str = Console.ReadLine();
            //int upper = 0, lower = 0, digit = 0, etc = 0, korean = 0;

            //foreach (char ch in str)
            //{
            //    if (char.IsUpper(ch))
            //    {
            //        upper++;
            //    }
            //    else if (char.IsLower(ch))
            //    {
            //        lower++;
            //    }
            //    else if (char.IsDigit(ch))
            //    {
            //        digit++;
            //    }
            //    else if ('가' <= ch && ch <= '희')
            //    {
            //        korean++;
            //    }
            //    else
            //    {
            //        etc++;
            //    }
            //}
            //Console.WriteLine("{0} are uppercase.", upper);
            //Console.WriteLine("{0} are lowercase.", lower);
            //Console.WriteLine("{0} are digits.", digit);
            //Console.WriteLine("{0} are korean.", korean);
            //Console.WriteLine("{0} are other.", etc);

            //Console.WriteLine();

            //for(int i = str.Length - 1; i > 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.WriteLine();

            Console.Write("Input text >>> ");
            string str = (Console.ReadLine()).ToLower();

            int[] arr = new int[26];
            int character = 'a';

            foreach (char c in str)
            {
                if (Char.IsLower(c))
                {
                    arr[c - 97]++;
                }
            }

            for(int i = 0; i < 26; i++)
            {
                Console.Write((char)(i + 97) + " ");
                for (int j = 0; j < arr[i]; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

        }
    }
}


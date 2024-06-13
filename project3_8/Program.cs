using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_8
{
    internal class Program {
        static void Main(string[] args) {
            //project03_8
            //Console.WriteLine("{0:D}", 123);
            //Console.WriteLine("{0,5:D}", 123); //uses spaces 0-5, 0 1 2 3 4 5, prints "   123"
            //Console.WriteLine("{0,5:D5}", 123); //uses spaces 0-5, prints 00123, because it starts at the end 5 from D5

            //Console.WriteLine("{0:F}", 123.456);
            //Console.WriteLine("{0,8:F1}", 123.456);
            //Console.WriteLine("{0,8:F4}", 123.456);

            //Console.WriteLine("{0:S}", "CSharp");
            //Console.WriteLine("{0,8:S}", "CSharp");


            //project03_11
            //Console.WriteLine("         ★");
            //Console.WriteLine("       ★★★");
            //Console.WriteLine("     ★★★★★");
            //Console.WriteLine("   ★★★★★★★");
            //Console.WriteLine(" ★★★★★★★★★");
            //Console.WriteLine("   ★★★★★★★");
            //Console.WriteLine("     ★★★★★");
            //Console.WriteLine("       ★★★");
            //Console.WriteLine("         ★");

            ////project3_12
            //bool boolVar = true;
            //int intVar = 0;
            //float floatVar = 0.0f;
            //char charVar = ' ';
            //string strVar = " ";

            //project3_13
            //Console.WriteLine(boolVar.GetType());
            //Console.WriteLine(intVar.GetType());
            //Console.WriteLine(floatVar.GetType());
            //Console.WriteLine(charVar.GetType());
            //Console.WriteLine(strVar.GetType());

            ////project3_14
            //bool boolVar = false;
            //int intVar = 100;
            //float floatVar = 123.45f;
            //char charVar = 'A';
            //string strVar = "Hello?";

            //project3_16
            //byte decData, binData, hexData;

            //decData = 147;
            //binData = 0b10010011;
            //hexData = 0x93;

            //Console.WriteLine("Decimal(decData) : " + decData);
            //Console.WriteLine("Binary(binData) : " + binData);
            //Console.WriteLine("Hexadecimal(hexData) : " + hexData);

            //project3_19
            //int sel;
            //string num;
            //int num10 = 0;

            //Console.Write("Choose a base (16/10/2): ");
            //sel = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input a number in that base: ");
            //num = Console.ReadLine();

            //if(sel == 16)
            //    num10 = Convert.ToInt32(num, 16);
            //if (sel == 10)
            //    num10 = Convert.ToInt32(num, 10);
            //if (sel == 2)
            //    num10 = Convert.ToInt32(num, 2);

            //Console.WriteLine("Hexadecimal: " + Convert.ToString(num10, 16));
            //Console.WriteLine("Binary: " + Convert.ToString(num10, 2));
            //Console.WriteLine("Decimal: " + Convert.ToString(num10, 10));

            int random; //filler code

            //project3_20
            //int n1 = 100, n2 = 200;
            //float result;

            //result = n1 / n2;
            //Console.WriteLine(String.Format("{0:F}", result));

            //project3_21
            //float flt = 0.12345678901234567890123456789f; //least precise
            //double dbl = 0.12345678901234567890123456789; //double the precision of a float
            //decimal dec = 0.12345678901234567890123456789m; //most precise

            //Console.WriteLine(flt);
            //Console.WriteLine(dbl);
            //Console.WriteLine(dec);

            //project3_22
            //bool b1 = true;
            //bool b2 = (100 == 100);
            //bool b3 = (10 > 100);

            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);

            //char in C# is 2 bytes because it was created after multiple other languages neede 2 bytes to be a char
            //char in C is 1 byte because its old and meant for english only

            //project3_24
            //string str1 = "IT Cookbook~";
            //string str2 = "C# Beginner";
            //string str3 = str1 + str2;

            //Console.WriteLine(str3);
            //Console.WriteLine(str2.Length);
            //Console.WriteLine(str2[0]);
            //Console.WriteLine(str2[0].GetType());
            //Console.WriteLine(str2[str2.Length-1]);

            //project 3_25
            //var data1 = 100;
            //var data2 = "C# coding";

            //Console.WriteLine(data1);
            //Console.WriteLine(data2);

            //end of class project
            string input = "";

            Console.Write("Please input the text: ");
            input = Console.ReadLine();

            for (int i = input.Length; i >= 0; i--) {
                if(i%2 ==0) {
                    Console.Write("*");
                } else {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine("\n");
        }
    }
}

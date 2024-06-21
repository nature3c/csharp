using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proj5_2
            //int year;
            //Console.Write("Input the year: ");
            //year = int.Parse(Console.ReadLine());

            //if(((year % 4 == 0) && ( year %100 != 0)) || (year % 400 == 0))
            //{
            //    Console.WriteLine("{0:D} is a leap year", year);
            //} else
            //{
            //    Console.WriteLine("{0:D} is not a leap year", year);
            //}

            //proj5_3
            //int a = 200;

            //if(a < 100)
            //{
            //    Console.WriteLine("Less than 100");
            //    Console.WriteLine("If true youll see this");
            //}

            //Console.WriteLine("End of program");

            //proj5_5
            //int a = 200;

            //if (a < 100)
            //{
            //    Console.WriteLine("Less than 100");
            //    Console.WriteLine("If true youll see this");
            //} else
            //{
            //    Console.WriteLine("Larger than 100");
            //    Console.WriteLine("If false then youll see this");
            //}

            //Console.WriteLine("End of program");

            //proj5_6
            //int a;
            //Console.Write("Input a number: ");
            //a = int.Parse(Console.ReadLine());

            //if((a%3==0)||(a%5==0))
            //{
            //    Console.WriteLine("Multiple of 3 and 5");
            //} else
            //{
            //    Console.WriteLine("Not a multiple of 3 or 5");
            //}

            //proj5_8
            //int score;
            //Random random = new Random();

            //for(int i= 0; i < 5; i++)
            //{
            //    score = random.Next(0, 100);
            //    Console.Write("Total Score " + score + " ==> ");

            //    if (score >= 90)
            //        Console.WriteLine("A");
            //    else
            //        if (score >= 80)
            //        Console.WriteLine("B");
            //        else
            //            if(score >= 70)
            //            Console.WriteLine("C");
            //                else
            //                    if(score >= 60)
            //                    Console.WriteLine("D"); 
            //                        else
            //                            Console.WriteLine("F"); 

            //}
            //Console.WriteLine("Grades");

            //proj5_10
            //int a;

            //Console.Write("Choose a number 1-4: ");
            //a = int.Parse(Console.ReadLine());

            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("1 selected\n");
            //        break;
            //    case 2:
            //        Console.WriteLine("2 selected\n");
            //        break;
            //    case 3:
            //        Console.WriteLine("3 selected\n");
            //        break;
            //    case 4:
            //        Console.WriteLine("4 selected\n");
            //        break;
            //    default:
            //        Console.WriteLine("That was not an option\n");
            //        break;
            //}

            int score;

            Random random = new Random();

            for(int i =0; i < 5; i++)
            {
                score = random.Next(0, 100);
                Console.Write("Total Score " + score + " ==> ");

                switch(score/10)
                {
                    case 10:
                    case 9:
                        Console.Write('A');
                        break;
                    case 8:
                        Console.Write('B');
                        break;
                    case 7:
                        Console.Write('C');
                        break;
                    case 6:
                        Console.Write('D');
                        break;
                    default:
                        Console.Write('F');
                        break;

                }
                Console.WriteLine();
            }
        }
    }
}

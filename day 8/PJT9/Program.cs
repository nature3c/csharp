using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PJT9
{
    internal class Program
    {

        //static void CoffeeMachine(int button)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("# 1.(Automatically) Prepare hot water");
        //    Console.WriteLine("# 2.(Automatically) Prepare a paper cup");

        //    switch(button)
        //    {
        //        case 1:
        //            Console.WriteLine("# 3. (Automatically) Prepare a regular coffee"); break;
        //        case 2:
        //            Console.WriteLine("# 3. (Automatically) Prepare a sweet coffee"); break;
        //        case 3:
        //            Console.WriteLine("# 3. (Automatically) Prepare a black coffee"); break;
        //        default:
        //            Console.WriteLine("# 3. (Automatically) Prepare aany coffee"); break;
        //    }

        //    Console.WriteLine("# 4. (Automatically) Dispense water");
        //    Console.WriteLine("# 5. (Automatically) Mix with a spoon");
        //}

        //static int Plus(int v1, int v2)
        //{
        //    int result;
        //    result = v1 + v2;
        //    return result;
        //}

        //static int Calc(int v1, char op, int v2, int v3)
        //{
        //    int result;

        //    switch(op)
        //    {
        //        case '+': result = v1 + v2 + v3; break;
        //        case '-': result = v1 - v2 - v3; break;
        //        case '*': result = v1 * v2 * v3; break;
        //        case '/': result = v1 / v2 / v3; break;
        //        default: result = 0; break;
        //    }

        //    return result;
        //}

        //static void FormulaPrint(int v1, int v2, int v3, char op)
        //{
        //    switch(op)
        //    {
        //        case '+': Console.WriteLine("{0} + {1} + {2}", v1, v2, v3); break;
        //        case '-': Console.WriteLine("{0} - {1} - {2}", v1, v2, v3); break;
        //        case '*': Console.WriteLine("{0} * {1} * {2}", v1, v2, v3); break;
        //        case '/': Console.WriteLine("{0} / {1} / {2}", v1, v2, v3); break;
        //    }
        //}

        //static int a = 200;
        //static void Func1()
        //{
        //    int a = 200;
        //    Console.WriteLine("Func1() a value --> {0}", a);
        //}

        //static void Func2()
        //{
        //    a++;
        //    Console.WriteLine("Func2() a value --> {0}", a);
        //}

        //static void Func3()
        //{
        //    int a = 400;
        //    Console.WriteLine("Fun3() a value --> {0}", a);
        //    a++;
        //}

        static int[] DrawDice()
        {
            Random rnd = new Random();
            int[] diceAry = new int[3/*rnd.Next(5, 11)*/];

            for (int i = 0; i < diceAry.Length; i++)
            {
                diceAry[i] = rnd.Next(1, 7);
            }

            return diceAry;
        }

        static bool CheckDice(int[] diceAry)
        {
            return diceAry[0] == diceAry[1] && diceAry[1] == diceAry[2];
        }


        static void Main(string[] args)
        {
            int[] ary;
            ary = DrawDice();
            int count = 1;

            //Console.Write("Rolled {0} --> ", ary.Length);
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    Console.Write(ary[i] + " ");
            //}
            //Console.WriteLine();

            while(true)
            {
                Console.Write("Rolled {0} --> {1} {2} {3}\n", count, ary[0], ary[1], ary[2]);

                if(CheckDice(ary))
                {
                    Console.WriteLine("End");
                    break;
                }


                ary = DrawDice();
                count++;

            }



            //Func1();
            //Func2();
            //Func3();
            //Func3();
            //Console.WriteLine("Main a value --> {0}", a);



            //int res;
            //char oper;
            //int n1, n2, n3;

            //Console.Write("First Number >>> ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Operation (+,-,*,/) >>> ");
            //oper = Console.ReadLine()[0];
            //Console.Write("Second Number >>> ");
            //n2 = int.Parse(Console.ReadLine());
            //Console.Write("Third Number >>> ");
            //n3 = int.Parse(Console.ReadLine());

            //FormulaPrint(n1, n2, n3, oper);
            //res = Calc(n1, oper, n2, n3);
            //Console.WriteLine("Result: {0}", res);

            //int hap;
            //hap = Plus(100, 200);
            //Console.WriteLine("The result of using the Plus() method on 100 and 200 is: {0}\n", hap);

            //int coffee;
            //string[] names = { "A", "C#", "Java" };

            //foreach (string i in names)
            //{
            //    Console.Write("What type of coffee would you like? (1: regular, 2: sweet, 3: black) >>> ");
            //    coffee = int.Parse(Console.ReadLine());

            //    CoffeeMachine(coffee);

            //    Console.WriteLine("\n{0}, your coffee is ready\n", names[i]);
            //}



            //string url = "https://koreaisacademy.com/program/index.html?subject=csharp&time=1900#content";

            ////protocol, domain, path, parameter, fragment

            //string protocol; //https
            //string domain; //koreaisacademy.com
            //string path; //program
            //string parameter; //index.html?subject=csharp&time=1900
            //string fragment; //#content
            //string newURL;

            //int protocolEnd = url.IndexOf("://"); //get index of ://
            //protocol = url.Substring(0, protocolEnd); //protocol = start to the ://
            //newURL = url.Substring(protocolEnd + 3); //newURL gets rid of url up to ://


            //int domainEnd = newURL.IndexOf('/'); //with the new URL get up to the / to show the domain
            //domain = newURL.Substring(0,domainEnd);
            //newURL = newURL.Substring(domainEnd + 1); //the newURL excludes the / that was used to get the domain


            //int pathEnd = newURL.IndexOf("?"); //the next / signifies the end of the path
            //path = newURL.Substring(0,pathEnd); //path is from 0 (because previous / was excluded) and goes until the /
            //newURL = newURL.Substring(pathEnd + 1); //newURL excludes the / that signified the end of the path


            //int parameterEnd = newURL.IndexOf("#"); //parameter goes up until the #
            //parameter = "?" + newURL.Substring(0, parameterEnd); //parameter goes up until the #

            //newURL = newURL.Substring(parameterEnd + 1);//look at line 43, just exclude the # and print it when only the words are left
            //fragment = "#" + newURL; //fragment is # and whatever words are left

            //Console.WriteLine("Protocol: " + protocol);
            //Console.WriteLine("Domain: " + domain);
            //Console.WriteLine("Path: " + path);
            //Console.WriteLine("Parameter: " + parameter);
            //Console.WriteLine("Fragment: " + fragment);
            //Console.WriteLine();

            //teachers code
            //string url = "https://koreaisacademy.com/program/index.html?subject=csharp&time=1900#content";
            //url = "ftp://naver.com/file/favicon.ico?size=256x256#download";

            //int protocolEnd = url.IndexOf("://");
            //string protocol = url.Substring(0, protocolEnd);
            //Console.WriteLine("프로토콜 : " + protocol);

            //string newUrl = url.Substring(protocolEnd + 3);
            //int domainEnd = newUrl.IndexOf("/");
            //string domain = newUrl.Substring(0, domainEnd);
            //Console.WriteLine("도메인 : " + domain);

            //int pathEnd = newUrl.IndexOf("?");
            //string path = newUrl.Substring(domainEnd + 1, pathEnd - domainEnd - 1);
            //Console.WriteLine("경로 : " + path);

            //int parameterEnd = newUrl.IndexOf("#");
            //string parameter = newUrl.Substring(pathEnd, parameterEnd - pathEnd);
            //Console.WriteLine("파라미터 : " + parameter);

            //string fragment = newUrl.Substring(parameterEnd);
            //Console.WriteLine("프래그먼트 : " + fragment);


        }
    }
}

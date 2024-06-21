using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT_DICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dice1, dice2, dice3, dice4, dice5, dice6;
            int throwCount = 0, serialCount = 0;

            Random random = new Random();

            while(true)
            {
                throwCount++;
                dice1 = random.Next(0, 7);
                dice2 = random.Next(0, 7);
                dice3 = random.Next(0, 7);
                dice4 = random.Next(0, 7);
                dice5 = random.Next(0, 7);
                dice6 = random.Next(0, 7);

                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4 && dice4 == dice5 && dice5 == dice6)
                {
                    Console.WriteLine("All the dice are the same: " + dice1);
                    break;
                }
                else if ((dice1 == 1 || dice2 == 1 || dice3 == 1 || dice4 == 1 || dice5 == 1 || dice6 == 1) &&
                        (dice1 == 2 || dice2 == 2 || dice3 == 2 || dice4 == 2 || dice5 == 2 || dice6 == 2) &&
                        (dice1 == 3 || dice2 == 3 || dice3 == 3 || dice4 == 3 || dice5 == 3 || dice6 == 3) &&
                        (dice1 == 4 || dice2 == 4 || dice3 == 4 || dice4 == 4 || dice5 == 4 || dice6 == 4) &&
                        (dice1 == 5 || dice2 == 5 || dice3 == 5 || dice4 == 5 || dice5 == 5 || dice6 == 5) &&
                        (dice1 == 6 || dice2 == 6 || dice3 == 6 || dice4 == 6 || dice5 == 6 || dice6 == 6)) ;

                serialCount++;
            }
            Console.WriteLine("Number of rolls: " + throwCount);
            Console.WriteLine("Number of consecutive number rolls: " + serialCount +"\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder programs");
            int StartPosition = 0;
            //UC2 Rolling a dice
            int ran = 0;
            Random random = new Random(); //Random function can generate random number
            ran = random.Next(1, 7);//Considering range from 1 to 6 i.e below 7
            Console.WriteLine("Rolled Dice");
            Console.WriteLine("Number got: " + ran);
            //UC-Starting Position zero
            Console.WriteLine("Starting Position of Player 1 is :" + StartPosition);
            Console.ReadLine();
        }
    }
}
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
            int Position = 0;
            //Initializing Constants
            const int Ladder = 1;
            const int NoPlay = 2;
            const int Snake = 3;

            Random random = new Random();
            while (Position <= 100)
            {
                int DieRoll = random.Next(1, 7);
                Console.WriteLine($"Die Rolling : {DieRoll}");

                int options = random.Next(1, 4);

                switch (options)
                {
                    case Ladder:
                        Position += DieRoll;
                        break;
                    case Snake:
                        Position -= DieRoll;
                        Position = Position < 0 ? 0 : Position;
                        break;
                    case NoPlay:
                        Console.WriteLine("Position " + Position);
                        break;
                }
            }
            Console.WriteLine("Position " + Position);
            Console.ReadLine();
        }
    }
}
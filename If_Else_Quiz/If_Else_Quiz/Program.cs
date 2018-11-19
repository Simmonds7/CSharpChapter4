using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace If_Else_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int pick;

            WriteLine("Welcome to the Prize Winning Door Program, P.W.D.P. Please pick a door, 1-3.");
            pick = Convert.ToInt32(ReadLine());

            if (pick == 2)

            {
                WriteLine("Congratulations! You have successfully picked the correct door");
            }
            else if (pick == 1 || pick == 3)
            {
                WriteLine("Congratulations! On not being correct!");
            }
            else if (pick != 1 && pick != 2 && pick != 3)
            {
                WriteLine("Error (Number not recognized). Please Restart the program, this time taking care to follow directions.");
            }
            Console.ReadLine();
        }
    }
}

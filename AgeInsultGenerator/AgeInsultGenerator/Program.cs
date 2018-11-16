using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            string yesString;
            int yes;

            WriteLine("Welcome to the Famous Age Insult Generator, F.A.I.G.");
            WriteLine("Please enter your age so the program can happily demean you.");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if (age < 18)
            {
                WriteLine("Awwwww. looks like you can't vote, ya dummyhead.");
            }
            else if (age >= 18 && age < 25)
            {
                WriteLine("Wow. You think you're something? Time for college, you slacker.");
            }
            else if (age >= 25 && age < 32)
            {
                WriteLine("Do you have a job? 1 if yes, 2 if no.");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    WriteLine("Good, but your job is dumb.");
                else
                    WriteLine("Then you suck... That's it... You just suck...");

            }
            else if (age >= 32 && age < 42)
            {
                WriteLine("I bet your In-Laws hate you. If you even have any, loser.");
            }
            else if (age >= 42 && age < 52)
            {
                WriteLine("Your health... Look at it go... Away...");
            }
            else if (age >= 52 && age < 62)
            {
                WriteLine("Its almost over! Keep losing just a little longer.");
            }
            else if (age >= 62)
            {
                WriteLine("Later Dummyhead! Have fun playing in the dirt!");
            }
            ReadLine();
        }
        
    }
}

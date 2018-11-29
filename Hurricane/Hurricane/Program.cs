using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {

            int windSpeed;
            

            WriteLine("Welcome to the Hurricane Category Placeing Program, H.C.P.P. Input the windspeed of the current storm.");
            windSpeed = Convert.ToInt32(ReadLine());

            if (windSpeed < 74)
            {
                WriteLine("Current storm is not a hurricane.");
            }
            else if (windSpeed >= 74 && windSpeed < 96)
            {
                WriteLine("Current storm is a category 1 hurricane.");
            }
            else if (windSpeed >= 96 && windSpeed < 111)
            {
                WriteLine("Current storm is a category 2 hurricane.");
            }
            else if (windSpeed >= 111 && windSpeed < 130)
            {
                WriteLine("Current storm is a category 3 hurricane.");
            }
            else if (windSpeed >= 130 && windSpeed < 157)
            {
                WriteLine("Current storm is a category 4 hurricane.");
            }
            else if (windSpeed >= 157)
            {
                WriteLine("WARNING! CURRENT STORM IS A CATEGORY 5 HURRICANE!");
            }
            
        }
    }
}

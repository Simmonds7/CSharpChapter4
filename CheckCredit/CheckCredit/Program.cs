using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCredit;
            const int MAX = 5000;

            WriteLine("Please enter Purchase Price.");
            inputCredit = Convert.ToInt32(ReadLine());
            if (inputCredit > MAX)
            {
                WriteLine("Error. Price higher than credit limit.");
            }
            else
            {
                WriteLine("Purchase Approved.");
            }
        }
    }
}

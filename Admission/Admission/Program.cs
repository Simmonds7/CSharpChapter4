using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            const double ACCEPTGPA = 3.0;
            int admissionTest;

            WriteLine("Please enter your GPA.");
            GPA = Convert.ToDouble(ReadLine());
            WriteLine("Enter your Admission Test Score.");
            admissionTest = Convert.ToInt32(ReadLine());

            if ((GPA >= ACCEPTGPA && admissionTest >= 60) || (GPA < ACCEPTGPA && admissionTest >= 80))
            {
                WriteLine("You have been accepted.");
            }
            else
            {
                WriteLine("Application Rejected");
            }

        }
    }
}

// HW1b Grade

// Your Name: Ella Camp
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student info
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            int studentid = int.Parse(Console.ReadLine());

            //grade questions
            Console.WriteLine("What is your overall percentage grade for homework?");
            double homework = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participation?");
            double part = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quiz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());

            //establish %
            double homeworkw = 0.20;
            double partw = 0.15;
            double quizw = 0.15;
            double midtermw = 0.25;
            double finalw = 0.25;

            //calculate final grade
            double finalgrade = (homework*homeworkw) + (part*partw) + (quiz*quizw) + (midterm*midtermw) + (final*finalw);

            Console.WriteLine($"{firstname} {lastname} ({studentid}), your final grade is {finalgrade}%");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();





        }
    }
}

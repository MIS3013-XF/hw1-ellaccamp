// HW1a Sales Total

// Your Name: Ella Camp
// Did you seek help ? If yes, specify the helper or web link here: Max Ngo & Pooja (MIS helplab)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking questions
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string product = Console.ReadLine();
            Console.WriteLine("How many football tickets do you want to buy?");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the price for each football ticket?");
            double price = double.Parse(Console.ReadLine());

            //subtotal
            double subtotal = price * quantity;
            subtotal = Math.Round(subtotal, 2);
            Console.WriteLine("The subtotal for your bill is $" + subtotal);

            //sales tax
            double taxrate = 0.085;
            double salestax = subtotal * taxrate;
            salestax = Math.Round(salestax, 2);
            Console.WriteLine("The sales tax for your bill is $" + salestax);

            //sales total
            double salestotal = subtotal + salestax;
            salestotal = Math.Round(salestotal, 2);
            Console.WriteLine("The total for your bill $" + salestotal);

            Console.WriteLine("Press any key to continue...");



        }
    }
}

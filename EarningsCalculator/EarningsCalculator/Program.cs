using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive?");
            double miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many stops did you have?");
            double stops = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many inspections did you do?");
            double inspections = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Meal pay quanity?");
            double mealPay = Convert.ToInt32(Console.ReadLine());

            double totalPay = (miles * 0.48) + (stops * 18.50) + (inspections * 18.50) + (mealPay * 25);

            Console.WriteLine("You made ${0} today!", totalPay);
            Console.ReadLine();

        }
    }
}

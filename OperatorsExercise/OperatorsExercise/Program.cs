using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be multiplied by 50");
            string num1 = Console.ReadLine();
            int inputNum1 = Convert.ToInt32(num1);
            int total = inputNum1 * 50;
            Console.WriteLine("Your number times 50 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Enter a number and 25 will be added to it");
            string num2 = Console.ReadLine();
            int inputNum2 = Convert.ToInt32(num2);
            int total2 = inputNum2 + 25;
            Console.WriteLine("Your number plus 25 is: " + total2);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by 12.5");
            string num3 = Console.ReadLine();
            double inputNum3 = Convert.ToInt32(num2);
            double total3 = inputNum3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + total3);
            Console.ReadLine();

       
            Console.WriteLine("Enter any number and I'll let you know if its bigger than 50");
            string num4 = Console.ReadLine();
            int inputNum4 = Convert.ToInt32(num4);
            int num5 = 50;
            bool greaterThan = inputNum4 > num5;
            Console.WriteLine(greaterThan);
            Console.ReadLine();

            Console.WriteLine("Enter a number to be divided by 7. The remainder will be given");
            string num6 = Console.ReadLine();
            double inputNum6 = Convert.ToInt32(num6);
            double total6 = inputNum6 / 7;
            double render = total6 % inputNum6;
            Console.WriteLine(render);
            Console.ReadLine();
        }
    }
}

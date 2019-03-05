using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to divide each number in the list");
                int number = Convert.ToInt32(Console.ReadLine());

                List<int> list = new List<int>();
                list.Add(2);
                list.Add(4);
                list.Add(10);

                foreach (int numbers in list)
                {
                    Console.WriteLine(numbers / number);
                    Console.ReadLine();
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        
        }
    }
}

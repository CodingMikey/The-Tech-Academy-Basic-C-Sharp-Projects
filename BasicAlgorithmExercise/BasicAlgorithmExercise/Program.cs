using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithmExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2));
            Console.WriteLine(test(3, 2));
            Console.WriteLine(test(2, 2));
            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}

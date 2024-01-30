using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum15
{
    class Program
    {
        static void Main(string[] args)
        {
            ///задагие 1
            Console.WriteLine("x\t y");
            for (int x = -5; x <= 5; x += 2)
            {
                double y = -5 * Math.Pow(x, 2) + 2 * x + 1;
                Console.WriteLine($"{x}\t {y}");
            }
            /// Задание 2, Вариант 9
            Console.WriteLine("x\t f(x)");
            for (double x = -3; x <= 3; x += 0.5)
            {
                double f = 0.5 * Math.Pow(x, 2) + 3;
                Console.WriteLine($"{x}\t {f}");
            }
            Console.WriteLine("x\t f(x)");
            for (double x = -3; x <= 3; x += 0.5)
            {
                double f = 0.5 * Math.Pow(x, 2) + 3;
                Console.WriteLine($"{x}\t {f}");
            }
        }
    }
}

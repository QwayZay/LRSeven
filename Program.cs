using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLRSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите действие из предложенных:");
            Console.WriteLine("1. Сложить ( + )");
            Console.WriteLine("2. Вычесть ( - )");
            Console.WriteLine("3. Умножить ( * )");
            Console.WriteLine("4. Разделить ( / )");

            string act = Convert.ToString(Console.ReadLine());

            switch (act)
            {
                case "1":
                    Console.WriteLine("Ответ: " + (a + b));
                    break;
                case "2":
                    Console.WriteLine("Ответ: " + (a - b));
                    break;
                case "3":
                    Console.WriteLine("Ответ: " + (a * b));
                    break;
                case "4":
                    Console.WriteLine("Ответ: " + (a / b));
                    break;
            }

            Console.ReadLine();
        }
    }
}

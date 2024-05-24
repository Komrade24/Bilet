using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Билет_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите X");
                string x = Console.ReadLine();
                if(int.TryParse(Console.ReadLine(), out int X))
                {
                    Console.WriteLine("Некорректный ввод");
                    Thread.Sleep(3000);
                }

                if(X < 0) Console.WriteLine($"Y равен {X*X+1}");
                else
                {
                    if (X >= 1) Console.WriteLine($"Y равен {4 * X - 1}");
                    else Console.WriteLine($"Y равен {2 * X + 1}");
                }

                Console.WriteLine("Нажмите любую кнопку для рестарта");
                Console.ReadKey();
            }
        }
    }
}

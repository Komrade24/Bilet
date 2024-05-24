using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int A = 5;
                int K = 15;
                double H = 0.2;
                double S = 0;
                int i = 1;

                for (; i <= K; i++)
                    S = S + (A+H*H)*i/(i+1);

                Console.WriteLine($"Y равен {H/(8*S)}");
                Console.WriteLine("Введите любую кнопку для рестарта");
                Console.ReadKey();
            }
        }
    }
}

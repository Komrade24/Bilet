using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Билет_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[,] array = new int[5, 5];
                int[,] array1 = new int[5, 5];

                array = AutoAdd();
                array1 = AutoAdd();

                int a = 0;

                Console.WriteLine("Первый массив: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 2 == 0)
                        {
                            Console.WriteLine(array[i, j]);
                            a += array[i, j];
                        }
                    }            
                }
                Console.WriteLine();
                Console.WriteLine("Второй массив: ");
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array1.GetLength(1); j++)
                    {
                        if (array1[i, j] >= 23 && array1[i, j] < 48)
                        {
                            Console.WriteLine(array1[i, j]);
                            a += array1[i, j];
                        }
                    }
                }
                Console.WriteLine("Сумма заданных чисел равна " + a);
                Console.ReadLine();
            }
        }

        private static int[,] AutoAdd()
        {
            int[,] ar = new int[5,5];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++) ar[i, j] = rnd.Next(1, 101);
            return ar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Билет_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберете нужное: \n1.Решение линейного уравнения " +
                                                   "\n2.Решение квадратного" +
                                                   "\n3.Вычисление квадратного корня " +
                                                   "\n4.Вычисление площади треугольника вписанного в окружность" +
                                                   "\n5.Вычисление площади трапеции");
                string value = Console.ReadLine();

                if (!int.TryParse(value, out int valueNumber))
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                    Thread.Sleep(3000);
                    continue;
                }
                int aValue, bValue, cValue;
                switch (valueNumber)
                {
                    case 1:
                        Console.WriteLine ("Линейное уравнение имеет вид: ax арифм.знак b = c");
                        Console.WriteLine("Введите значение a");
                         aValue = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите значение b");
                         bValue = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите значение c");
                         cValue = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите арифм знак, который стоит между ax и b");
                        string simbol = Console.ReadLine();
                        int result;
                        switch (simbol)
                        {
                            case "+":
                                result = (cValue - bValue)/aValue;
                                Console.WriteLine("Ответ: " + result);
                                break;
                            case "-":
                                result = (cValue + bValue) / aValue;
                                Console.WriteLine("Ответ: " + result);
                                break;
                            case "*":
                                result = cValue / (bValue * aValue);
                                Console.WriteLine("Ответ: " + result);
                                break;
                            case "/":
                                result = (cValue * bValue) / aValue;
                                Console.WriteLine("Ответ: " + result);
                                break;
                            default:
                                goto default;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Квадратное уравнение имеет вид  ax^2 + или - bx + или - c = 0");

                        Console.WriteLine("Линейное уравнение имеет вид: ax арифм.знак b = c");
                        Console.WriteLine("Введите значение a");
                        aValue = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите значение b");
                        bValue = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите значение c");
                        cValue = int.Parse(Console.ReadLine());

                        int D = bValue*bValue - 4 * aValue * cValue;
                        if (D > 0) Console.WriteLine($"x1: {(-1*bValue + Math.Sqrt(D))/2*aValue} x2: {(-1 * bValue - Math.Sqrt(D)) / 2 * aValue}");
                        
                        else if(D == 0) Console.WriteLine($"x: +-{(-1 * bValue) / 2 * aValue}");

                        else Console.WriteLine("Нет корней!");
                        break;
                    case 3:
                        Console.WriteLine("Введите число, из которого хотите извлечь квадрат");
                        aValue = int.Parse(Console.ReadLine());
                        if (aValue > 0) Console.WriteLine($"Число из квадрата равно {Math.Sqrt(aValue)}");
                        else Console.WriteLine("Не возможно");
                        break;
                    case 4:
                        Console.WriteLine("Введите радиус окружности ");
                        aValue = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Площадь равна {(double)(0.5*Math.PI*aValue)}");
                        break;
                    case 5:
                        Console.WriteLine("Введите длину первого основания");
                        aValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длину вторго основания");
                        bValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длину высоты");
                        cValue = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Площадь равна {((aValue+bValue)*cValue)/2}");
                        break;
                    default:
                        Console.WriteLine("Нет такого варианта!");
                        break;
                }

                Console.WriteLine("Нажмите любую кнопку для рестарта программы");
                Console.ReadKey();
            }
        }
    }
}

﻿using System; //Подключение библиотеки System

namespace HelloApp //Создание именнованной области для хранения кода
{
    class Program //Cоздание класса Program
    {
        static void Main(string[] args) //Обязательная иницализация метода старта программы
        {
            Console.WriteLine("Введите сумму вклада: "); //Вывод в консоль текста
            decimal sum = Convert.ToDecimal(Console.ReadLine()); //Создание переменной дробных чисел и получение в неё данных с консоли
            Console.WriteLine("Введите срок вклада в месяцах: ");//Вывод в консоль текста
            int period = Convert.ToInt32(Console.ReadLine());//Создание переменной целочисленных цифр и получение в неё данных с консоли
            int i = period; //Присвоение в переменную значения другой переменной

            while (i > 0) //Запуск цикла, пока переменная i не будет выполнять поставленному условию
            {
                sum += sum * 0.07M; //Прибавление к значению произведения его же значения на число типа decimal
                i--;  //выполнение операции дикримента (убавление значения переменной на один)
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");//Вывод в консоль текста, в котором содержат ссылки на переменные (инкапсуляция)
            Console.ReadKey(); //Ожидание нажатия клавиши (чтобы консоль не свернулась)
        }
    }
}

﻿using System; //Подключение библиотеки System

namespace HelloApp //Создание пространства имен, для хранения обастей кода
{
    class Program //Создание класса Program
    {
        static void Main(string[] args) //Создание метода-точки запуска программы 
        {
            for (int i = 1; i < 10; i++) //Создание цикла фор (в нем инициализируется переменная, так называемый итератор, действие до выполнения условия которого он выполняется. После кажой итерации цикла инкремент увеличивает значение итератора на один)
            {
                for (int j = 1; j < 10; j++) //Создание вложенного цикла фор (в нем инициализируется переменная, так называемый итератор, действие до выполнения условия которого он выполняется. После кажой итерации цикла инкремент увеличивает значение итератора на один)
                {
                    Console.Write($"{i * j}\t"); //Вывод в консоль командой без переноса строки, каждую итерацию цикла произведение итераторов. Значение вычесляется в строке благодаря использованию интерполяции. Также благодаря спецсимволу строка переносится вправо каждую итерацию
                }
                Console.WriteLine(); //Перенос строки каждую итерацию главного цикла, чтобы разделить строковый вывод вложенного цикла
            }
            Console.ReadKey(); //Ожидание нажатия клавиши (чтобы консоль не свернулась)
        }
    }
}

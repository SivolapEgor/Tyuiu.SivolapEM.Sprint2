﻿using Tyuiu.SivolapEM.Sprint2.Task1.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a, b, c, d;
        a = 195;
        b = 16;
        c = 14;
        d = 45;
        bool[] res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнил: Сиволап Е.М. | ИИПб-25-1ы";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логически операции                                                *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений, а также арифметических        *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив).        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* A = " + a);
        Console.WriteLine("* B = " + b);
        Console.WriteLine("* C = " + c);
        Console.WriteLine("* D = " + d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}
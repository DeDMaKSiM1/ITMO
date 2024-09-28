using System;
using System.Collections.Generic;

public class Task2
{
    static void Main()
    {
        /*
        На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) 
        расположена ближе к A, и вывести эту точку и ее расстояние от точки A. 
        Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, 
        совпадать с А или между собой - выдать соответствующее сообщение.
        */

        Console.WriteLine("Введите координаты A, B и C через пробел");
        var dataList = new List<double>(3);
        char[] delimiters = { ' ' };
        string[] line = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        if (line.Length != 3)
        {
            Console.WriteLine("Количество аргументов меньше, либо больше трех");
            return;
        }

        for (int i = 0; i < line.Length; i++)
        {
            if (!double.TryParse(line[i], out double coordinate))
            {
                Console.WriteLine("Ошибка в формате данных");
                return;
            }
            dataList.Add(coordinate);
        }
        double dAB = Math.Abs(dataList[0] - dataList[1]);
        double dAC = Math.Abs(dataList[0] - dataList[2]);
        if (dAB < dAC)
            Console.WriteLine($"Точка B лежит ближе к A, растояние между ними = {dAB}");
        else if (dAB > dAC)
            Console.WriteLine($"Точка C лежит ближе к A, растояние между ними = {dAC}");
        else if (dAC == dAB && dAC == 0)
            Console.WriteLine("Координаты трех точек совпадают");
        else if (dAC == dAB && dAC != 0 && dataList[1] == dataList[2])
            Console.WriteLine("Координаты точек B и C совпадают");
        else if (dAC == dAB && dAC != 0 && dataList[1] != dataList[2])
            Console.WriteLine("Точки B и C равноудалены от точки А");
        else
            Console.WriteLine("Непредвиденная ситуация - ошибка");

    }
}


using System;
using System.Collections.Generic;
public class LoopWhile
{
    static void Main()
    {
        /*
        Ввести положительные числа A, B, C. 
        На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
        Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
        */
        char[] delimiters = { ' ' };
        string[] line = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        if (line.Length != 3)
        {
            Console.WriteLine("Недостаточно данных");
            return;
        }
        int numOfCubes = 0;
        var list = new List<int>(3);
        int rectangleArea = 0, cubeArea = 0;

        for (int i = 0; i < line.Length; i++)
        {
            if (!int.TryParse(line[i], out var value))
            {
                Console.WriteLine("Ошибка в формате данных");
                return;
            }
            if(value <= 0)
            {
                Console.WriteLine("Одно из значений меньше либо равно нулю");
                return;
            }
            list.Add(value);
        }
        //rectangle area
        for (int i = 0; i < list[0]; i++)
        {
            rectangleArea += list[1];
        }
        //cube area
        for (int i = 0; i < list[2]; i++)
        {
            cubeArea += list[2];
        }
        //number of cubes in rectangle
        for (int i = cubeArea; i <= rectangleArea; i += cubeArea)
        {
            numOfCubes++;
        }
        Console.WriteLine($"Количество квадратов, которые можно поместить в данный прямоугольник = {numOfCubes}");
    }
}


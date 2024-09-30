using System;
using System.Collections.Generic;

public class Task6
{
    static void Main()
    {
        /*
        Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
        Заполнить массив числами, вводимыми с клавиатуры. 
        Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
        Магическим квадратом называется матрица, сумма элементов которой в каждой строке, 
        в каждом столбце и по каждой диагонали одинакова.
        */
        Console.WriteLine("Введите размерность матрицы N");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 1)
        {
            Console.WriteLine("Неверный формат данных");
            return;
        }

        int[,] matrix = new int[n, n];
        var sumList = new List<int>(n * 2 + 2);
        bool isMagical = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out int value))
                {
                    Console.WriteLine("Ошибка в формате данных");
                    return;
                }
                matrix[i, j] = value;
            }
        }

        int sumMainDiagonal = 0, sumSideDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            int sumColumn = 0, sumRow = 0;
            for (int j = 0; j < n; j++)
            {
                //сумма по строкам
                sumRow += matrix[i, j];
                //сумма по cтолбцам
                sumColumn += matrix[j, i];
                if (i == j)
                    sumMainDiagonal += matrix[i, j];
                if (j + i == n - 1)
                    sumSideDiagonal += matrix[i, j];
            }
            sumList.Add(sumRow);
            sumList.Add(sumColumn);
        }
        sumList.Add(sumMainDiagonal);
        sumList.Add(sumSideDiagonal);

        for (int i = 0; i < sumList.Count; i++)
        {
            Console.WriteLine(sumList[i]);
            if (sumList[0] != sumList[i])
                isMagical = false;
        }

        if (isMagical)
            Console.WriteLine("Матрица - магический квадрат");
        else
            Console.WriteLine("Матрица - не магический квадрат");
    }
}


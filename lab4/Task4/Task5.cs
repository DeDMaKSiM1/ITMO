using System;

public class Task5
{
    static void Main()
    {
        /*
        Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN 
        следующего вида:
        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1
        */
        Console.WriteLine("Введите размерность матрицы N");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Неверный формат данных");
        }

        int[,] matrix = new int[n, n];
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (count % 2 == 0)
                    matrix[i, j] = 1;
                else
                    matrix[i, j] = 0;
                count++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}


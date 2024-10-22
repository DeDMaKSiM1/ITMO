using System;
using System.Threading;

public class Program
{
    const int row = 2;
    const int col = 5;
    static int[,] fieldArray = new int[row, col] { { 1, 5, 1, 5, 2}, { 4, 1, 6, 15, 12 } };

    static void Main()
    {
        /*
        Имеется пустой участок земли (двумерный массив) и план сада, который необходимо 
        реализовать. Эту задачу выполняют два садовника, которые не хотят встречаться 
        друг с другом. 
        Первый садовник начинает работу с верхнего левого угла сада и 
        перемещается слева направо, сделав ряд, он спускается вниз. 
        
        Второй садовник начинает работу с нижнего правого угла сада и перемещается
        снизу вверх, сделав ряд, он перемещается влево. Если садовник видит, 
        что участок сада уже выполнен другим садовником, он идет дальше.
        
        Садовники должны работать параллельно. Создать многопоточное приложение, 
        моделирующее работу садовников.
        */
        ThreadStart threadStart = new ThreadStart(Gardener1);
        Thread thread = new Thread(threadStart);
        thread.Start();
        Gardener2();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{fieldArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void Gardener1()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (fieldArray[i, j] >= 0)
                {
                    int delay = fieldArray[i, j];
                    fieldArray[i, j] = -1;

                    Thread.Sleep(delay);
                }
            }
        }
    }
    static void Gardener2()
    {
        for (int i = row - 1; i >= 0; i--)
        {
            for (int j = col - 1; j >= 0; j--)
            {
                if (fieldArray[i, j] >= 0)
                {
                    int delay = fieldArray[i, j];
                    fieldArray[i, j] = -2;

                    Thread.Sleep(delay);
                }
            }
        }
    }

}


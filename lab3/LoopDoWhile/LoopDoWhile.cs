using System;
using System.Diagnostics;
public class LoopDoWhile
{
    static void Main()
    {
        /*
        Осуществить ввод последовательности целых чисел и сравнить, что больше, 
        количество положительных или количество отрицательных. Последовательность потенциально не ограничена, 
        окончанием последовательности служит число 0. 
        */
        int numOfPositives = 0, numOfNegatives = 0;
        do
        {
            if (!int.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine("Ошибка в входных данных");
                continue;
            }
            
            if (number > 0)
                numOfPositives++;
            else if (number < 0)
                numOfNegatives++;
            else
                break;
        }
        while (true);        

        Console.WriteLine($"Положительных чисел = {numOfPositives} \nОтрицательных чисел = {numOfNegatives}");

    }

}


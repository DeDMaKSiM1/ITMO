using System;

public class Task2
{
    static void Main()
    {
        /*
         Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из 
         диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.
        */
        int maxValue, minValue;
        int[] valuesArray = new int[15];
        Random rnd = new Random();
        for (int i = 0; i < valuesArray.Length; i++)
        {
            valuesArray[i] = rnd.Next(0, 50);
            Console.WriteLine(valuesArray[i]);
        }

        maxValue = valuesArray[0];
        minValue = valuesArray[0];
        for (int i = 0; i < valuesArray.Length; i++)
        {
            if (maxValue < valuesArray[i])
                maxValue = valuesArray[i];
            if (minValue > valuesArray[i])
                minValue = valuesArray[i];
        }
        Console.WriteLine($"Сумма максимального и минимального значения в массиве = {maxValue + minValue}");
    }
}

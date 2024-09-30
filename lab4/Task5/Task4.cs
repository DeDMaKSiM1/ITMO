using System;

public class Task4
{
    static void Main()
    {
        /*
        Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
        Определить количество нечетных положительных элементов, стоящих на четных местах. 
        */

        int[] valuesArray = new int[20];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < valuesArray.Length; i++)
        {
            valuesArray[i] = rnd.Next(-50, 50);
            Console.Write($"{valuesArray[i]} ");
        }

        int numPosAndEven = 0;
        for (int i = 0; i < valuesArray.Length; i += 2)
        {
            if (valuesArray[i] % 2 == 0)
                numPosAndEven++;
        }
        Console.WriteLine($"\nКоличество положительных чисел на четных позициях = {numPosAndEven}");
    }
}


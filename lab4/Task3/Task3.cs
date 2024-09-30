using System;
using System.Runtime.ExceptionServices;

public class Task3
{
    static void Main()
    {
        /*
        Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
        Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        */
        int[] valuesArray = new int[10];
        Random rnd = new Random();
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < valuesArray.Length; i++)
        {
            valuesArray[i] = rnd.Next(-50, 50);
            Console.Write($"{valuesArray[i]} ");
        }
        Console.WriteLine();

        for (int i = 0; i < valuesArray.Length/2; i++)
        {
            int temp;
            for (int j = i+1; j < valuesArray.Length / 2; j++)
            {
                if (valuesArray[i] > valuesArray[j])
                {
                    temp = valuesArray[i];
                    valuesArray[i] = valuesArray[j];
                    valuesArray[j] = temp;
                }
            }
        }

        for (int i = valuesArray.Length / 2; i < valuesArray.Length; i++)
        {
            int temp;
            for (int j = valuesArray.Length / 2; j < valuesArray.Length; j++)
            {
                if (valuesArray[i] < valuesArray[j])
                {
                    temp = valuesArray[i];
                    valuesArray[i] = valuesArray[j];
                    valuesArray[j] = temp;
                }
            }
        }

        Console.WriteLine("Отсортированный массив");

        for (int i = 0; i < valuesArray.Length; i++)
        {
            Console.Write($"{valuesArray[i]} ");
        }
    }
}

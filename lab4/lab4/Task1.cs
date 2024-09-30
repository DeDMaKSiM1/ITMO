using System;

public class Task1
{
    static void Main()
    {
        /*
        Сформировать одномерный массив из 7 элементов.Заполнить массив числами, вводимыми с клавиатуры, 
        определить среднее арифметическое элементов.
        */
        char[] delimiters = { ' ' };
        Console.WriteLine("Введите 7 элементов через пробел");
        string[] line = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        if (line.Length != 7)
        {
            Console.WriteLine("Введено больше или меньше 7 элементов");
        }

        int[] valuesArray = new int[7];
        for (int i = 0; i < line.Length; i++)
        {            
            if(!int.TryParse(line[i], out int value))
            {
                Console.WriteLine("Ошибка в формате данных");
                return;
            }
            valuesArray[i] = value;
        }

        int Sum = 0;
        for (int i = 0; i < valuesArray.Length; i++)
        {
            Sum += valuesArray[i];
        }
        double arithmeticMean = (double)Sum / valuesArray.Length;

        Console.WriteLine($"Среднее арифметическое = {arithmeticMean:f2}");
    }
}


using System;
using System.IO;


public class Task2
{
    static void Main()
    {
        /*
        Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
        Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
        */
        int sum = 0;
        string path = @"Numbers.txt";
        Random rnd = new Random();
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(rnd.Next(-10, 10));
            }

        }
        using (StreamReader stream = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                if(!int.TryParse(stream.ReadLine(), out int value))
                    continue;
                sum += value;
            }
        }
        Console.WriteLine(sum);
    }
}


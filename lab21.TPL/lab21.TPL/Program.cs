using System;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        /*
        Сформировать массив случайных целых чисел (размер  задается пользователем). 
        Вычислить сумму чисел массива и максимальное число в массиве.  
        Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.
        */

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Ошибка в парсинге размерности массива");
            return;
        }

        Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
        Task<int[]> task1 =new Task<int[]>(func1,n);
        

        Action<Task<int[]>> func2 = new Action<Task<int[]>>(SumArray);
        Task task2 = task1.ContinueWith(func2);

        Action<Task<int[]>> func3 = new Action<Task<int[]>>(FindMax);
        Task task3 = task1.ContinueWith(func3);
        task1.Start();

        Console.ReadKey();
    }
    static int[] GetArray(object a)
    {
        int n = (int)a;
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(0, 100);
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        return array;
    }

    static void SumArray(Task<int[]> task)
    {
        int[] array = task.Result;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }
    static void FindMax(Task<int[]> task)
    {
        int[] array = task.Result;
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
                max = array[i];
        }
        Console.WriteLine(max);
    }
}


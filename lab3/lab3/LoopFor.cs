using System;
public class LoopFor
{
    static void Main()
    {
        /*
        Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: 
        N2 = 1 + 3 + 5 + ... +(2 * N – 1). 
        После добавления к сумме каждого слагаемого выводить текущее значение суммы
        (в результате будут выведены квадраты всех целых чисел от 1 до N).
        */
        if (!int.TryParse(Console.ReadLine(), out var inputValue))
        {
            Console.WriteLine("Ошибка в формате исходных данных");
            return;
        }

        int Sum = 0;
        for (int i = 1; i <= (2 * inputValue - 1); i += 2)
        {
            Sum += i;
            Console.WriteLine(Sum);
        }

    }
}


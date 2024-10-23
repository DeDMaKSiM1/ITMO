using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        if(!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Ошибка в парсинге");
            return;
        }

        FactorialAsync(n);

        Factorial(n+2);
        Console.WriteLine("Конец Main");
        Console.ReadKey();
    }

    static void Factorial(int x)
    {
        Console.WriteLine($"Получено значение {x}");
        int result = 1;
        for (int i = 1; i <= x; i++)
        {
            result *= i;
            Thread.Sleep(100);
        }
        Console.WriteLine(result);
    }
    static async Task FactorialAsync(int x)
    {
        await Task.Run(() => Factorial(x));
    }

}


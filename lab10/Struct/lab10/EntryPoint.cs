using System;

public class EntryPoint
{
    static void Main()
    {
        /*
        Разработать структуру для решения линейного уравнения 0=kx+b. 
        Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
        Для решения уравнения предусмотреть метод Root. 
        Создать экземпляр разработанной структуры. 
        Осуществить использование экземпляра в программе.
        */
        double k, b;
        Console.WriteLine("Введите k и b для уравнения вида kx + b = 0 через пробелы");
        char[] delimiters = { ' ' };
        string[] inputLine = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        try
        {
            if (inputLine.Length != 2)
                throw new ArgumentOutOfRangeException("Введено больше или меньше 2 значений");
            if (!double.TryParse(inputLine[0], out k))
                throw new ArgumentException("Ошибка формата k");
            if (!double.TryParse(inputLine[1], out b))
                throw new ArgumentException("Ошибка формата b");
        }
        catch(ArgumentException arEx)
        {
            Console.WriteLine(arEx.Message);
            return;
        }
        var linearEq = new LinearEquation(k, b);

        Console.WriteLine($"{linearEq.Root():0:##}");
        Console.ReadKey();
    }
}


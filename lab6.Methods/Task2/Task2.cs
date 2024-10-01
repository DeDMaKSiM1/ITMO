using System;

public class Task2
{
    static void Main()
    {
        /*
        Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        Объем = а^3
        Площадь поверхности = 6*а^2
        */
        double area, cubeValue;
        Console.WriteLine("Введите длину ребра куба");
        if (!double.TryParse(Console.ReadLine(), out double cubeEdgeLength))
        {
            Console.WriteLine("Неверный формат данных");
            return;
        }
        if(cubeEdgeLength<= 0)
        {
            Console.WriteLine("Значение ребра не может быть < либо = нулю");
            return;
        }
        CalculateCubeProperties(cubeEdgeLength, out area, out cubeValue);
        Console.WriteLine($"Объем куба = {cubeValue} \nПлощадь поверхности куба = {area}");
    }

    public static void CalculateCubeProperties(double cubeEdgeLength, out double area, out double cubeValue)
    {
        area = 6 * cubeEdgeLength * cubeEdgeLength;
        cubeValue = cubeEdgeLength * cubeEdgeLength * cubeEdgeLength;
    }
}


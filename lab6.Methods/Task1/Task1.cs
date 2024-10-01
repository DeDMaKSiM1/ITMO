using System;

public class Task1
{
    static void Main()
    {
        /*
        Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
        (создать метод для вычисления  площади  треугольника по длинам его сторон).  
        Для решения задачи можно использовать формулу Герона 
        */
        Console.WriteLine("Введите значение сторон первого треугольника через пробел:");
        char[] delimiters = { ' ' };
        string[] firstTriangeValuesLine = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        if (firstTriangeValuesLine.Length != 3)
        {
            Console.WriteLine("Введено меньше либо больше трех сторон для первого треугольника");
            return;
        }


        Console.WriteLine("Введите значение сторон второго треугольника через пробел:");
        string[] secondTriangeValuesLine = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        if (secondTriangeValuesLine.Length != 3)
        {
            Console.WriteLine("Введено меньше либо больше трех сторон для второго треугольника");
            return;
        }

        double[] firstValuesArray = new double[3];
        double[] secondValuesArray = new double[3];
        for (int i = 0; i < firstTriangeValuesLine.Length; i++)
        {
            if (!double.TryParse(firstTriangeValuesLine[i], out var value))
            {
                Console.WriteLine("Ошибка в формате данных для первого треугольника");
                return;
            }
            firstValuesArray[i] = value;
            if (!double.TryParse(secondTriangeValuesLine[i], out value))
            {
                Console.WriteLine("Ошибка в формате данных для второго треугольника");
                return;
            }
            secondValuesArray[i] = value;
        }

        double biggestSide = Math.Max(firstValuesArray[0], Math.Max(firstValuesArray[1], firstValuesArray[2]));
        if (biggestSide == firstValuesArray[0] && biggestSide >= firstValuesArray[1] + firstValuesArray[2])
        {
            Console.WriteLine("Треугольник 1 не может существовать");
            return;
        }
        else if (biggestSide == firstValuesArray[1] && biggestSide >= firstValuesArray[0] + firstValuesArray[2])
        {
            Console.WriteLine("Треугольник 1 не может существовать");
            return;
        }
        else if (biggestSide == firstValuesArray[2] && biggestSide >= firstValuesArray[0] + firstValuesArray[1])
        {
            Console.WriteLine("Треугольник 1 не может существовать");
            return;
        }

        biggestSide = Math.Max(secondValuesArray[0], Math.Max(secondValuesArray[1], secondValuesArray[2]));
        if (biggestSide == secondValuesArray[0] && biggestSide >= secondValuesArray[1] + secondValuesArray[2])
        {
            Console.WriteLine("Треугольник 2 не может существовать");
            return;
        }
        else if (biggestSide == secondValuesArray[1] && biggestSide >= secondValuesArray[0] + secondValuesArray[2])
        {
            Console.WriteLine("Треугольник 2 не может существовать");
            return;
        }
        else if (biggestSide == secondValuesArray[2] && biggestSide >= secondValuesArray[0] + secondValuesArray[1])
        {
            Console.WriteLine("Треугольник 2 не может существовать");
            return;
        }

        double firstArea, secondArea;
        firstArea = CalculateTriangeArea(firstValuesArray[0], firstValuesArray[1], firstValuesArray[2]);
        secondArea = CalculateTriangeArea(secondValuesArray[0], secondValuesArray[1], secondValuesArray[2]);

        Console.WriteLine($"Площадь первого треугольника: {firstArea:f2}");
        Console.WriteLine($"Площадь второго треугольника: {secondArea:f2}");

        if (firstArea > secondArea)
            Console.WriteLine("Площадь первого треугольника больше");
        else if (firstArea < secondArea)
            Console.WriteLine("Площадь второго треугольника больше");
        else
            Console.WriteLine("Площади треугольников равны");

    }

    public static double CalculateTriangeArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Одно из значений сторон меньше либо равно нулю");
        double semiPerimeter = (a + b + c) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        return area;
    }
}


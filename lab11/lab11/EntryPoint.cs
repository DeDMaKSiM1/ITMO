using System;

public class EntryPoint
{
    static void Main()
    {
        double[] coordinateArrValues = new double[4];
        char[] delimiters = { ' ' };
        double radius;
        Console.WriteLine("Введите радиус окружности");

        try
        {
            if (!double.TryParse(Console.ReadLine(), out radius))
                throw new ArgumentException("Ошибка в формате значения радиуса");
            if (radius <= 0)
                throw new ArgumentException("Радиус меньше либо равен нулю");

            Console.WriteLine("Введите координаты центра окружности xC, yC и координаты точки x1,y2 через пробел");
            string[] coordnateArr = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (coordnateArr.Length != 4)
                throw new ArgumentOutOfRangeException("Передано меньше или больше четырех значений координат");
            for (int i = 0; i < coordnateArr.Length; i++)
            {
                if (!double.TryParse(coordnateArr[i], out double value))
                    throw new ArgumentException("Ошибка в формате данных координат");
                coordinateArrValues[i] = value;
            }


            Console.WriteLine($"Периметр равен {Circle.GetPerimeter(radius):0.##}");
            Console.WriteLine($"Площадь равна {Circle.GetArea(radius):0.##}");
            if (Circle.IsInCircle(radius, coordinateArrValues))
                Console.WriteLine("Точка лежит внутри окружности");
            else
                Console.WriteLine("Точка лежит вне окружности");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch
        {
            Console.WriteLine("Неизвестная ошибка");
            return;
        }


    }
}


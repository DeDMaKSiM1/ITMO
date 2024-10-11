using System;

delegate double MyDelegate(double arg);
public class UserDelegate
{
    static void Main()
    {
        /*
        1.В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        - метод получает входным параметром переменную типа double;
        - метод возвращает значение типа double, которое является результатом вычисления.
        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        - длину окружности по формуле D = 2 * π* R;
        - площадь круга по формуле S = π* R²;
        - объем шара. Формула V = 4/3 * π * R³.
        Методы должны быть объявлены как статические.
        */
        MyDelegate myDel = new MyDelegate(PerimeterCalc);
        myDel += AreaCalc;
        myDel += ValueCalc;

        myDel?.Invoke(1);
    }
    static double PerimeterCalc(double radius)
    {
        double result = 2 * Math.PI * radius;
        Console.WriteLine($"Периметр: {result:f2}");
        return result;
    }
    static double AreaCalc(double radius)
    {
        double result = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площадь: {result:f2}");
        return result;
    }
    static double ValueCalc(double radius)
    {
        double result = (4.0 / 3) * Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Объем: {result:f2},результат с userDelegate");
        return result;
    }
}

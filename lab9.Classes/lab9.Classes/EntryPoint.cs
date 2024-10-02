using System;

public class EntryPoint
{
    static void Main()
    {
        /*
        Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
        Реализовать класс, в котором указанные значения представлены в виде свойств. 
        Для свойств предусмотреть проверку корректности данных. 
        Класс должен содержать конструктор для установки начальных значений, 
        а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. 
        Осуществить использование объекта в программе.
        */
        int gradus, minutes, seconds;
        try
        {
            Console.WriteLine("Введите значение градуса");
            if (!int.TryParse(Console.ReadLine(), out gradus))
                throw new ArgumentException("Ошибка в формате значения градуса");

            Console.WriteLine("Введите значение минут");
            if (!int.TryParse(Console.ReadLine(), out minutes))
                throw new ArgumentException("Ошибка в формате значения минут");

            Console.WriteLine("Введите значение секунд");
            if (!int.TryParse(Console.ReadLine(), out seconds))
                throw new ArgumentException("Ошибка в формате значения секунд");

        }
        catch (ArgumentException arEx)
        {
            Console.WriteLine(arEx.Message);
            return;
        }
        var circle1 = new CircleMethods(gradus, minutes, seconds);

        Console.WriteLine($"Градусов {circle1.Gradus}");
        Console.WriteLine($"Минут {circle1.Minute}");
        Console.WriteLine($"Секунды {circle1.Second}");


        Console.WriteLine($"После перевода в радианы: {circle1.ToRadians():0.###}");
    }
}


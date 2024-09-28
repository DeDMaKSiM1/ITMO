using System;

public class Task3
{
    static void Main()
    {
        /*
            Дано целое число в диапазоне 20–69, определяющее возраст(в годах). 
        Вывести строку-описание указанного возраста, обеспечив правильное согласование числа 
        со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». 
        Если пользователь введёт данные не соответствующие условию задачи -выдать сообщение об ошибке.
        */

        Console.WriteLine("Введите целое число от 20 до 69 включительно");
        if (!int.TryParse(Console.ReadLine(), out var age))
        {
            Console.WriteLine("Ошибка в формате данных");
            return;
        }
        if (age < 20 || age > 69)
        {
            Console.WriteLine("Неверный диапазон значения возраста");
            return;
        }
        string ageLine;
        switch (age % 10)
        {
            case 1:
                ageLine = "год";
                break;
            case 2:
            case 3:
            case 4:
                ageLine = "года";
                break;
            default:
                ageLine = "лет";
                break;
        }
        Console.WriteLine($"{age} {ageLine}");
    }
}


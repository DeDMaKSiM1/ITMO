using System;

public class Task4
{
    static void Main()
    {
        /*
        Дано целое число в диапазоне 100–999.Вывести строку - описание данного числа, 
        например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». 
        Если пользователь введёт данные не соответствующие условию задачи -выдать сообщение об ошибке.
        */
        Console.WriteLine("Введите целое число в диапазоне 100-999 включительно");
        if (!int.TryParse(Console.ReadLine(), out var age))
        {
            Console.WriteLine("Ошибка в формате данных");
            return;
        }
        if (age < 100 || age > 999)
        {
            Console.WriteLine("Неверный диапазон значений");
            return;
        }
        string hundreds, tens, units;
        //десятки и единицы
        if (age % 100 >= 11 && age % 100 < 20)
        {
            units = "";
            switch (age % 100)
            {
                case 11:
                    tens = "одиннадцать";
                    break;
                case 12:
                    tens = "двенадцать";
                    break;
                case 13:
                    tens = "тринадцать";
                    break;
                case 14:
                    tens = "четырнадцать";
                    break;
                case 15:
                    tens = "пятнадцать";
                    break;
                case 16:
                    tens = "шестнадцать";
                    break;
                case 17:
                    tens = "семнадцать";
                    break;
                case 18:
                    tens = "восемнадцать";
                    break;
                case 19:
                    tens = "девятнадцать";
                    break;
                default:
                    tens = "";
                    break;
            }

        }
        else if (age % 100 == 10)
        {
            tens = "деcять";
            units = "";
        }
        else
        {            
            switch ((age / 10) % 10)
            {
                case 2:
                    tens = "двадцать";
                    break;
                case 3:
                    tens = "тридцать";
                    break;
                case 4:
                    tens = "сорок";
                    break;
                case 5:
                    tens = "пятьдесят";
                    break;
                case 6:
                    tens = "шестьдесят";
                    break;
                case 7:
                    tens = "семьдесят";
                    break;
                case 8:
                    tens = "восемьдесят";
                    break;
                case 9:
                    tens = "девяносто";
                    break;
                default:
                    tens = "";
                    break;
            }
            switch (age % 10)
            {
                case 1:
                    units = "один";
                    break;
                case 2:
                    units = "два";
                    break;
                case 3:
                    units = "три";
                    break;
                case 4:
                    units = "четыре";
                    break;
                case 5:
                    units = "пять";
                    break;
                case 6:
                    units = "шесть";
                    break;
                case 7:
                    units = "семь";
                    break;
                case 8:
                    units = "восемь";
                    break;
                case 9:
                    units = "девять";
                    break;
                default:
                    units = "";
                    break;
            }
        }
        //сотни
        switch ((age / 100) % 10)
        {
            case 1:
                hundreds = "сто";
                break;
            case 2:
                hundreds = "двести";
                break;
            case 3:
                hundreds = "триста";
                break;
            case 4:
                hundreds = "четыреста";
                break;
            case 5:
                hundreds = "пятьсот";
                break;
            case 6:
                hundreds = "шестьсот";
                break;
            case 7:
                hundreds = "семьсот";
                break;
            case 8:
                hundreds = "восемьсот";
                break;
            case 9:
                hundreds = "девятьсот";
                break;
            default:
                hundreds = "";
                break;
        }
        Console.WriteLine($"{hundreds} {tens} {units}");
    }
}


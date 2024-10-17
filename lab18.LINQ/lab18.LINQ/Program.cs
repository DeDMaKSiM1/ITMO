using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Program
{
    static void Main()
    {
        /*
        1.Модель  компьютера характеризуется  кодом и  названием марки компьютера,  типом процессора, частотой  
        работы процессора, объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, 
        стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
        Создать список, содержащий 6 - 10 записей с различным набором значений характеристик.

        Определить:
        -все компьютеры с указанным процессором. Название процессора запросить у пользователя;
        -все компьютеры с объемом ОЗУ не ниже, чем указано.Объем ОЗУ запросить у пользователя;
        -вывести весь список, отсортированный по увеличению стоимости;
        -вывести весь список, сгруппированный по типу процессора;
        -найти самый дорогой и самый бюджетный компьютер;
        -есть ли хотя бы один компьютер в количестве не менее 30 штук ?
        */

        List<Computer> computerlist = new List<Computer>(6)
        {
            new Computer(){ Id = 1, Brand = "Asus", CoreType = "Intel",
                            CoreHz = 1444, AmountOfRAM = 8, HardDriveCapacity = 1024,
                            VideocardMemoryCapacity = 512, Price = 100000, NumInStock = 10},

            new Computer(){ Id = 2, Brand = "Acer", CoreType = "Intel",
                            CoreHz = 1888, AmountOfRAM = 8, HardDriveCapacity = 2048,
                            VideocardMemoryCapacity = 1024, Price = 205400, NumInStock = 2},

            new Computer(){ Id = 3, Brand = "Gigabyte", CoreType = "AMD",
                            CoreHz = 2650, AmountOfRAM = 16, HardDriveCapacity = 4096,
                            VideocardMemoryCapacity = 2048, Price = 250000, NumInStock = 4},

            new Computer(){ Id = 4, Brand = "Asus", CoreType = "Intel",
                            CoreHz = 2089, AmountOfRAM = 8, HardDriveCapacity = 1024,
                            VideocardMemoryCapacity = 1024, Price = 165000, NumInStock = 3},

            new Computer(){ Id = 5, Brand = "Xiomi", CoreType = "AMD",
                            CoreHz = 1583, AmountOfRAM = 16, HardDriveCapacity = 8192,
                            VideocardMemoryCapacity = 4096, Price = 251000, NumInStock = 62},

            new Computer(){ Id = 6, Brand = "Apple", CoreType = "m2",
                            CoreHz = 865, AmountOfRAM = 8, HardDriveCapacity = 2048,
                            VideocardMemoryCapacity = 1024, Price = 500000, NumInStock = 3},

        };

        
        Console.WriteLine("Задание 1:");
        var task1 = computerlist.Where(x => x.CoreType == "AMD").ToList();
        foreach (var item in task1)
            Console.WriteLine($"{item}");


        Console.WriteLine("Введите нужный объем ОЗУ");
        if (!int.TryParse(Console.ReadLine(), out int ozuTemp))
        {
            Console.WriteLine("Ошибка парсинга значения требуемой ОЗУ");
            return;
        }

        Console.WriteLine("Задание 2:");
        var task2 = computerlist.Where(x => x.AmountOfRAM >= ozuTemp).ToList();
        foreach (var item in task2)
            Console.WriteLine($"{item}");
        

        Console.WriteLine("Задание 3:");
        var task3 = computerlist.OrderBy(x => x.Price).ToList();
        foreach (var item in task3)
        {
            Console.WriteLine($"{item}");
        }
        

        Console.WriteLine("Задание 4");
        var task4 = computerlist.OrderBy(x=> x.CoreType).ToList();

        foreach (var item in task4)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("Задание 5");

        var minCostComp = computerlist.Where(x => x.Price == computerlist.Select(y => y.Price).Min());
        var maxCostComp = computerlist.Where(x => x.Price == computerlist.Select(y => y.Price).Max());
        foreach (var item in minCostComp)
        {
            Console.WriteLine($"Минимальная стоимость:\n{item}");
        }
        foreach (var item in maxCostComp)
        {
            Console.WriteLine($"Максимальная стоимость:\n{item}");
        }
        

        Console.WriteLine("Задание 6");

        var task6 = computerlist.Where(x => x.NumInStock > 30).ToList();
        foreach (var item in task6)
        {
            Console.WriteLine(item);
        }
    }
}


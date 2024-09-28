using System;
using System.Collections.Generic;
public class Task1
{
    static void Main()
    {
        /*
        1.Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
        Найти координаты его четвертой вершины. 
        Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
        параллельными координатным осям, вывести соответствующее сообщение.
        */

        Console.WriteLine("Введите координаты трех вершин прямоугольника x1, y1, x2, y2, x3, y3 через пробел");
        char[] delimiter = { ' ' };
        string[] line = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        var dataList = new List<EntryData>(4);

        if (line.Length != 6)
        {
            Console.WriteLine("Ошибка в количестве введеных координат");
            return;
        }

        for (int i = 0; i < line.Length; i += 2)
        {
            if (!int.TryParse(line[i], out int xParse) || !int.TryParse(line[i + 1], out int yParse))
            {
                Console.WriteLine("Ошибка в формате данных");
                return;
            }
            dataList.Add(new EntryData(xParse, yParse));
        }

        if (dataList[0].X == dataList[2].X && dataList[0].Y != dataList[2].Y)
            dataList.Add(new EntryData(dataList[1].X, dataList[2].Y));

        else if (dataList[0].X == dataList[1].X && dataList[0].Y != dataList[1].Y)
            dataList.Add(new EntryData(dataList[2].X, dataList[1].Y));
        else
        {
            Console.WriteLine("Нельзя получить прямоугольник по данным координатам");
            return;
        }
        Console.WriteLine($"Координата X четвертой вершины = {dataList[3].X} \nКоордината Y четвертой вершины = {dataList[3].Y}");
        Console.ReadLine();
    }
}

public class EntryData
{
    private int _x, _y;
    public int X
    {
        get => _x;
        private set => _x = value;
    }
    public int Y
    {
        get => _y;
        private set => _y = value;
    }

    public EntryData(int x, int y)
    {
        X = x;
        Y = y;
    }
}



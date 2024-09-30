using System;
using System.Collections.Generic;
using System.Text;

public class Task3
{
    static void Main()
    {
        /*
        Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
        В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
        Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
        */
        Console.WriteLine("Введите строку для работы");
        string s = Console.ReadLine();
        if (s == null || s.Trim().Length == 0)
        {
            Console.WriteLine("Пустая строка");
            return;
        }
        var listOfIndex = new List<IndexData>();
        for (int i = 0; ; i++)
        {
            if (s.IndexOf('{', 0) == -1)
                break;
            if (s.IndexOf('}', 0) == -1)
                break;
            listOfIndex.Add(new IndexData(s.IndexOf('{')));
            listOfIndex[i].SecondIndex = s.IndexOf('}');
            s = s.Remove(listOfIndex[i].FirstIndex, listOfIndex[i].SecondIndex - listOfIndex[i].FirstIndex + 1);

        }
        Console.WriteLine($"Результат: {s}");

    }
}

public class IndexData
{
    public int FirstIndex { get; set; }
    public int SecondIndex { get; set; }

    public IndexData(int firstIndex)
    {
        FirstIndex = firstIndex;
    }
}


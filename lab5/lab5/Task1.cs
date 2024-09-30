using System;

public class Task1
{
    static void Main()
    {
        /*
        Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
        Знаки препинания не используются. Найти самое длинное слово в строке.
        */
        Console.WriteLine("Введите предложение без знаков препинания");
        char[] delimiter = { ' ' };
        string[] lineArray = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        if(lineArray.Length == 0)
        {
            Console.WriteLine("Ошибка в формате данных");
            return;
        }
        string longestWord = lineArray[0];
        foreach (string s in lineArray)
        {
            if(longestWord.Length < s.Length)
                longestWord = s;
        }
        Console.WriteLine($"Самое короткое слово в предложении: {longestWord}");
        Console.ReadKey();
    }
}


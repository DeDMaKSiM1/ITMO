using System;
using System.IO;
using System.Text;

public class Task3
{
    static void Main()
    {
        /*
        Вручную подготовьте текстовый файл с фрагментом текста. 
        Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
        */
        char[] delimitersForStrings = { '\r' };
        char[] delimitersForWords = { ' ', '\n', '\r' };
        char[] delimitersForSymbols = {'\r' };

        string path = @"Test\TextFile.txt";
        int stringNumber = 0, wordNumber, symbolNum = 0;
        string allSymbols;

        using (StreamReader stream = new StreamReader(path))
        {
            allSymbols = stream.ReadToEnd();



        }
        var symbolTemp = allSymbols.Split(delimitersForSymbols);
        foreach (var item in symbolTemp)
        {
            symbolNum += item.Length;
        }
        var strings = allSymbols.Split(delimitersForStrings, StringSplitOptions.RemoveEmptyEntries);
        var words = allSymbols.Split(delimitersForWords, StringSplitOptions.RemoveEmptyEntries);
        stringNumber = strings.Length;
        wordNumber = words.Length;
        Console.WriteLine($"Количество символов = {symbolNum}");
        Console.WriteLine($"Количество слов = {wordNumber}");
        Console.WriteLine($"Количество строк = {stringNumber}");
        Console.ReadLine();
    }
}


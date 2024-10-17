using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using CustomClass;

public class Serealization
{
    static void Main()
    {
        #region Variables
        const int n = 5;
        Goods[] backetItem = new Goods[n];

        string path = @"..\..\..\..\Goods";
        #endregion
        #region DataRecording
        for (int i = 0; i < n; i++)
        {
            backetItem[i] = new Goods();

            Console.WriteLine("Введите номер товара");
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Ошибка в парсинге Id");
                return;
            }
            backetItem[i].Id = value;

            Console.WriteLine("Введите цену товара");
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка в парсинге Price");
                return;
            }
            backetItem[i].Price = value;

            Console.WriteLine("Введите название товара");
            string nameTemp = Console.ReadLine();
            if (string.IsNullOrEmpty(nameTemp))
            {
                Console.WriteLine("Пустое значение для имени товара");
                return;
            }
            backetItem[i].Name = nameTemp;

        }
        #endregion
        #region WritingToFile

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        };
        string jsonString = JsonSerializer.Serialize(backetItem, options);

        string filePath = Path.Combine(path, "GoodsData.json");
        using (var sw = new StreamWriter(filePath))
        {
            sw.WriteLine(jsonString);
        }
        #endregion
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CustomClass;
public class Deserialization
{
    static void Main()
    {
        #region Variables
        string path = @"..\..\..\..\Goods\GoodsData.json";
        string jsonData = string.Empty;

        List<Goods> goodsList = new List<Goods>();
        Goods mostExpenciveItem = new Goods();
        #endregion
        #region Deserialization
        using (StreamReader sr = new StreamReader(path))
        {
            while (!sr.EndOfStream)
            {
                jsonData += sr.ReadToEnd();
            }
        }
        goodsList = JsonSerializer.Deserialize<List<Goods>>(jsonData);
        mostExpenciveItem = goodsList[0];
        #endregion
        #region Processing

        for (int i = 0; i < goodsList.Count; i++)
        {
            if (goodsList[i].Price > mostExpenciveItem.Price)
                mostExpenciveItem = goodsList[i];
        }

        Console.WriteLine(mostExpenciveItem);
        #endregion
    }
}


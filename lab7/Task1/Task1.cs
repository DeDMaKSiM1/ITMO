using System;
using System.IO;


public class Task1
{
    static void Main()
    {
        /*
        Выберите любую папку на своем компьютере, имеющую вложенные директории. 
        Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        */
        string path = "TestFolder";
        string[] array;
        if (Directory.Exists(path))
        {
            array = Directory.GetFileSystemEntries(path,"*", SearchOption.AllDirectories);
        }
        else
        {
            Console.WriteLine("Ошибка");
            return;
        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}


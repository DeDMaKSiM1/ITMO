using System;
using System.Text;

public class Task2
{
    static void Main()
    {
        /*
        Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
        Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом 
        без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).
        */
        Console.WriteLine("Введите предложение на его проверку на палиндром");
        char[] delitimers = { ' ' };
        string[] lineArray = Console.ReadLine().Split(delitimers, StringSplitOptions.RemoveEmptyEntries);
        if(lineArray.Length == 0)
        {
            Console.WriteLine("Неверный формат данных");
            return;
        } 
        else if(lineArray.Length == 1)
        {
            Console.WriteLine("Предложение состоит из одного слова");
            return; 
        }
        var sb = new StringBuilder();
        bool isPalindrome = true;
        foreach ( string s in lineArray)
        {
            sb.Append(s);
        }
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] != sb[sb.Length - (i+1)])
            {
                isPalindrome = false;
                break;
            }
                
        }

        if (isPalindrome)
            Console.WriteLine("Предложение является палиндромом");
        else
            Console.WriteLine("Предложение не является палиндромом");

    }
}


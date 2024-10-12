using System;
using System.Collections.Generic;
public class Program
{
    static void Main()
    {
        string inputLine = "{[]}";
        Stack<char> bracketsChars = new Stack<char>();
        bool isValidLine = true;

        for (int i = 0; i < inputLine.Length; i++)
        {
            if (!isValidLine)
                break;
            switch (inputLine[i])
            {
                case '(':
                    bracketsChars.Push(inputLine[i]);
                    bracketsChars.Push((char)((int)inputLine[i] + 1));
                    break;
                case '[':
                case '{':
                    bracketsChars.Push(inputLine[i]);
                    bracketsChars.Push((char)((int)inputLine[i] + 2));
                    break;

                case '}':
                case ')':
                case ']':
                    if (bracketsChars.Count == 0 || bracketsChars.Peek() != inputLine[i])
                    {
                        isValidLine = false;
                        break;
                    }
                    bracketsChars.Pop();
                    bracketsChars.Pop();
                    break;

                default:
                    isValidLine = false;
                    break;
            }
        }

        if (!isValidLine)
        {
            Console.WriteLine("Скобки расставлены некорректно");
            return;
        }
        Console.WriteLine("Скобки расставлены корректно");
    }


}


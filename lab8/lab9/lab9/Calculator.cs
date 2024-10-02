using System;

public class MainClass
{
    static void Main()
    {
        double resultOutput;
        Console.WriteLine("Введите 2 числа для математических преобразований через пробел");
        char[] delimiters = { ' ' };
        string[] inputDataLine = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Введите код операции:\n\t1 - Сложение \n\t2 - Вычитание \n\t3 - Произведение \n\t4 - Частное");
        string operationValueString = Console.ReadLine();
        try
        {
            if (inputDataLine.Length != 2)
                throw new ArgumentOutOfRangeException("Количество чисел не равно 2");
            if (!double.TryParse(inputDataLine[0], out double x1))
                throw new ArgumentException("Ошибка формата первого аргумента");
            if (!double.TryParse(inputDataLine[1], out double x2))
                throw new ArgumentException("Ошибка формата второго аргумента");
            if (!int.TryParse(operationValueString, out int operationNum))
                throw new ArgumentException("Ошибка формата номера операции");

            Calculate(x1, x2, operationNum, out resultOutput);

            Console.WriteLine($"{resultOutput:f2}");
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch(DivideByZeroException divideByZeroEx)
        {
            Console.WriteLine(divideByZeroEx.Message);
        }
        catch
        {
            Console.WriteLine("Неизвестная ошибка");
        }


    }
    static double Calculate(double x1, double x2, int operationNum, out double result)
    {
        switch (operationNum)
        {
            case 1:
                result = x1 + x2;
                break;
            case 2:
                result = x1 - x2;
                break;
            case 3:
                result = checked(x1 * x2);
                break;
            case 4:
                if (x1 == 0 && x2 == 0)
                    throw new DivideByZeroException("Деление нуля на ноль - ошибка");
                if (x2 == 0)
                    throw new DivideByZeroException("Деление на ноль - ошибка");
                result = x1 / x2;
                break;
            default:
                throw new ArgumentException("Операции под данным кодом не существует");
        }
        return result;
    }


}



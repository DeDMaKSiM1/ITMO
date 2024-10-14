using System;


public class Program
{
    static void Main()
    {
        var max = new ClientData<string>("Maxim", "88005553535");
        var tan = new ClientData<int>("Tanya", 22);
        try
        {
            Console.WriteLine($"Номер аккаунта {max.FullName} - {max.AccountNumber}");
            Console.WriteLine(max.Balance);
            max.AddToBalance(100);
            Console.WriteLine(max.Balance);
            max.RemoveToBalance(10);
            Console.WriteLine(max.Balance);

            Console.WriteLine($"Номер аккаунта {tan.FullName} - {tan.AccountNumber}");

        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch
        {
            Console.WriteLine("Неизвестная ошибка");
            return;
        }
    }
}


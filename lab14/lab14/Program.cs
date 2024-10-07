using System;


public class Program
{
    static void Main()
    {
        var arithm = new ArithProgression();
        var geometric = new GeomProgression();
        try
        {
            Console.WriteLine("Арифметическая прогрессия");
            arithm.SetStart(5);
            arithm.SetStep(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arithm.GetNext());
            }
            arithm.Reset();
            Console.WriteLine(arithm.CurrentValue);

            Console.WriteLine("\nГеометрическая прогрессия");
            geometric.SetStep(2);
            geometric.SetStart(1);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(geometric.GetNext());
            }
            geometric.Reset();
            Console.WriteLine(geometric.CurrentValue);

        }
        catch(ArgumentException arEx)
        {
            Console.WriteLine(arEx.Message);
            return;
        }
        catch
        {
            Console.WriteLine("Неизвестная ошибка");
            return;
        }


    }
}


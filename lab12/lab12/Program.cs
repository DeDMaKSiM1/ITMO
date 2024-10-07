using System;

public class Program
{
    static void Main()
    {
        var building1 = new Building("Ленина 1", 50, 10, 30);
        Console.WriteLine(building1.Print());

        var multiBuilding = new MultiBuilding("Фрунзе 10", 100, 20, 60, 20);
        Console.WriteLine(multiBuilding.Print());
    }
}


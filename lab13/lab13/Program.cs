using System;

public class Program
{
    static void Main()
    {
        var dog = new Dog();
        dog.ShowInfo();
        dog.Say();

        var cat = new Cat();
        cat.ShowInfo();
        cat.Say();
    }
}


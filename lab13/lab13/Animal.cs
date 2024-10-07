using System;
public abstract class Animal
{
    public abstract string Name { get;  protected set; }
    
    public Animal(string name)
    {
        Name = name;
    }
    public Animal() : this("Животное")
    {
    }
    public void ShowInfo()
    {
        Console.Write($"{Name} ");
        Say();
    }
    public abstract void Say();
}
public class Cat : Animal
{
    public override string Name { get; protected set; }
    public Cat() : base("Кошка")
    {
    }
    public override void Say() => Console.WriteLine("Мяу");
}
public class Dog : Animal
{
    public override string Name { get; protected set; }
    public Dog() : base("Собака")
    {
    }
    public override void Say() => Console.WriteLine("Гав");
}


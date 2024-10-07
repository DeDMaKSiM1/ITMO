using System;

public class Building
{
    public string Adress { get; private set; }
    public double Length { get; private set; }
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Building(string adress, double length, double width, double height)
    {
        Adress = adress;
        Length = length;
        Width = width;
        Height = height;
    }
    public string Print() => $"Адрес: {Adress}, длина здания: {Length}, ширина здания: {Width}, высота здания {Height}";

}


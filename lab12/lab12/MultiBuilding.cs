using System;
public sealed class MultiBuilding : Building
{
    public int NumOfStoreys { get; private set; }

    public MultiBuilding(string adress, double length, double width, double height, int numOfStoreys)
        : base(adress, length, width, height)
    {
        NumOfStoreys = numOfStoreys;
    }
    public new string Print() => base.Print() + $", количество этажей: {NumOfStoreys}";

}


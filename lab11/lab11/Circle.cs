using System;

public class Circle
{
    public static double GetPerimeter(double radius)
    {
        return 2.0 * Math.PI * radius;
    }
    public static double GetArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    public static bool IsInCircle(double radius, params double[] coordinateValues)
    {

        double xC = coordinateValues[0];
        double yC = coordinateValues[1];
        double x1 = coordinateValues[2];
        double y1 = coordinateValues[3];

        if (Math.Pow(x1 - xC, 2) + Math.Pow(y1 - yC, 2) <= Math.Pow(radius, 2))
            return true;
        return false;
    }

}




using System;

public class CircleMethods
{
    private int _gradus, _min, _sec;

    public int Gradus
    {
        get => _gradus;
        set
        {
            if (value >= 0)
                _gradus = value;
        }
    }
    public int Minute
    {
        get => _min;
        set
        {
            if (value >= 60)
            {
                Gradus += value / 60;
                _min = value % 60;
            }

            else if (value >= 0)
                _min = value;
        }
    }
    public int Second
    {
        get => _sec;
        set
        {
            if (value >= 60)
            {
                Minute += value / 60;
                _sec = value % 60;
            }
            else if (value >= 0)
                _sec = value;

        }
    }
    public CircleMethods(int gradus, int min, int sec)
    {
        Gradus = gradus;
        Minute = min;
        Second = sec;
    }


    public double ToRadians()
    {
        double result = Gradus + (Minute + Second / 60.0) / 60.0;
        return result * Math.PI / 180.0;
    }
}


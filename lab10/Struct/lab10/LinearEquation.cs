using System;


public struct LinearEquation
{
    public double K { get; private set; }
    public double B { get; private set; }

    public LinearEquation(double K, double B)
    {
        this.K = K;
        this.B = B;
    }

    public string Root()
    {
        if (K == 0 && B != 0)
            return "Уравнение корней не имеет";
        if (K == 0 && B == 0)
            return "Корнем уравнения является любое число";
        double result;
        result = -B / K;
        return $"Корень уравнения {result}";
    }
}


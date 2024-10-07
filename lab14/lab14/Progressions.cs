using System;


public interface ISeries
{
    void SetStart(int x);
    int GetNext();
    void Reset();
}

public class ArithProgression : ISeries
{
    public int Step { get; private set; }
    public int StartValue { get; private set; }
    public int CurrentValue { get; private set; }

    public int GetNext()
    {
        if (Step == 0 || StartValue == 0)
            throw new ArgumentException("Начальное число либо шаг прогрессии равен нулю");
        return CurrentValue += Step;
    }
    public void Reset()
    {
        CurrentValue = StartValue;
    }
    public void SetStart(int startNum)
    {
        StartValue = startNum;
        CurrentValue = startNum;
    }
    public void SetStep(int step)
    {
        Step = step;
    }
}
public class GeomProgression : ISeries
{
    public int Koef { get; private set; }
    public int StartValue { get; private set; }
    public int CurrentValue { get; private set; }

    public int GetNext()
    {
        if (Koef == 0 || StartValue == 0)
            throw new ArgumentException("Начальное число либо коэффициент прогрессии равен нулю");
        return CurrentValue *= Koef;
    }
    public void Reset()
    {
        CurrentValue = StartValue;
    }
    public void SetStart(int startNum)
    {
        StartValue = startNum;
        CurrentValue = startNum;
    }
    public void SetStep(int koef)
    {
        Koef = koef;
    }
}

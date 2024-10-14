using System;

public abstract class BaseClientData<T>
{
    public T AccountNumber { get; }
    public decimal Balance { get; protected set; }
    public string FullName { get; }

    public BaseClientData(string fullName, T accountNumber)
    {
        FullName = fullName;
        AccountNumber = accountNumber;
        Balance = 0;
    }
    protected void IsValueValid(ref decimal value)
    {
        if (value < 0)
            throw new ArgumentException("Входное значение для изменения баланса меньше либо равно нулю");
    }
}


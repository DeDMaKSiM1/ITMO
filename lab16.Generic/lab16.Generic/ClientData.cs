using System;

public sealed class ClientData<T> : BaseClientData<T>, IClientBalanceManagable
{
    public ClientData(string fullName, T accountNumber) : base(fullName, accountNumber)
    {
    }
    public void AddToBalance(decimal value)
    {
        IsValueValid(ref value);
        Balance += value;
    }
    public void RemoveToBalance(decimal value)
    {
        IsValueValid(ref value);
        Balance -= value;
    }

}


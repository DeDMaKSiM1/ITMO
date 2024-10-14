using System;

public interface IClientBalanceManagable
{
    void AddToBalance(decimal value);
    void RemoveToBalance(decimal value);
}


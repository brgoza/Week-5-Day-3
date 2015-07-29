using System;

namespace Bank
{
    public interface IBankAccount
    {
        bool DepositMoney(decimal amount);
        bool WithDrawMoney(decimal amount);
        bool TransferMoney(IBankAccount otherAccount, decimal amount);

        Decimal Balance { get; }
    }

    public class CheckingAccount : IBankAccount
    {

        public CheckingAccount(int startingBalance)
        {

        }

        public decimal Balance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool DepositMoney(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool WithDrawMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class SavingsAccount : IBankAccount
    {

        public SavingsAccount(int startingBalance)
        {
        }

        public decimal Balance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool DepositMoney(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool WithDrawMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
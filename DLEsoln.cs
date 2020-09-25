using System.Threading;
using System;
using DLsoln;

namespace DLsoln
{
    public class Account
    {
        double _balance;
        int _id;
        public Account(int id, double balance)
        {
            this._balance = balance;
            this._id = id;
        }
        public int ID // this will return the account ID
        {
            get
            { return _id; }

        }
        public void Withdraw(double amount) //method to withdraw money
        {
            _balance -= amount;
        }
        public void Deposit(double amount) //method to deposit money
        {
            _balance += amount;
        }

    }

    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            object _lock1, _lock2;
            if (_fromAccount.ID < _toAccount.ID)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }
            lock (_lock1)
            {
                Thread.Sleep(1000);
                lock (_lock2)
                {
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
        public static void Main()
        {
            Console.WriteLine("This is main method");
            Account accountA = new Account(104, 5000);
            Account accountB = new Account(105, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);//here Fromacc is accountA,Toacc is accountB
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";
            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);//here Fromacc is accountB,Toacc is accountA
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            Console.WriteLine("Main completed");


        }
    }
}

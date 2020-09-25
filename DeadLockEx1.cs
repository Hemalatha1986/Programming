using System.Threading;
using System;
using DLexample;

namespace DLexample
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
            {return _id;}

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
    public AccountManager(Account fromAccount,Account toAccount,double amountToTransfer)
    {
        this._fromAccount = fromAccount;
        this._toAccount = toAccount;
        this._amountToTransfer = amountToTransfer;
    }
    public void Transfer()
    {
         Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire to lock on" + _fromAccount.ID.ToString());
        lock(_fromAccount)
        {
                Console.WriteLine(Thread.CurrentThread.Name + "acquire to lock on" + _fromAccount.ID.ToString());
                 Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "Back in action and trying to acquire lock on" + _toAccount.ID.ToString());
                lock (_toAccount)
            {
                    Console.WriteLine("DeadLock");
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

namespace AccountLibrary;

using System;

public class Account
{
    private static int _number = 101;
    public readonly int  AccountNumber;
    private int Balance;
    private string _accountName;

    // default Constructor
    public Account()
    {

    }

    // Parameterized Constructor
    public Account(string accountName , int balance)
    {
        AccountNumber = _number++;
        Balance = balance;
        _accountName = accountName;
    }

    // Deposit
    public void Deposit(int Amount)
    {
        Balance = Balance + Amount;
        Console.WriteLine("Amount Deposited Successfully...");
    }

    // Withdraw
    public void Withdraw(int Amount)
    {
        if (Amount > Balance)
        {
            Console.WriteLine("Insufficient Balance!");
            return;
        }

        Balance = Balance - Amount;
        Console.WriteLine("Amount Withdrawn Successfully...");
    }

    // Balance enquiry
    public int BalanceEnquiry()
    {
        return Balance;
    }

    public void AccountDetails()
    {
        Console.WriteLine("Account Number : "+AccountNumber);
        Console.WriteLine("Account Name : "+_accountName);
        Console.WriteLine("Account Balance : "+Balance);
        Console.WriteLine("---------------------------");
    }
}

using System;

class Account
{
    long AccNum;
    private int Balance = 0;

    // default Constructor
    public Account()
    {

    }

    // Parameterized Constructor
    public Account(long AccNum)
    {
        this.AccNum = AccNum;
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
    public void BalanceEnquiry()
    {
        Console.WriteLine("Your final balance is " + Balance);
    }


    public static void Main()
{
    // Creating multiple accounts
    Account[] accounts = new Account[3];
    accounts[0] = new Account(1111);
    accounts[1] = new Account(2222);
    accounts[2] = new Account(3333);

    while (true)
    {
        Console.Write("\nEnter Account Number: ");
        long accNo = long.Parse(Console.ReadLine());

        Account selectedAccount = null;

        // Check account number match
        for (int i = 0; i < accounts.Length; i++)
        {
            if (accounts[i].AccNum == accNo)
            {
                selectedAccount = accounts[i];
                break;
            }
        }

        if (selectedAccount == null)
        {
            Console.WriteLine("Invalid Account Number!");
            continue;
        }

        Console.WriteLine("\n1 Deposit Amount");
        Console.WriteLine("2 Withdraw Amount");
        Console.WriteLine("3 Balance Enquiry");
        Console.WriteLine("4 Exit");

        Console.Write("Enter Your Choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter Deposit Amount: ");
                int depositAmt = int.Parse(Console.ReadLine());
                selectedAccount.Deposit(depositAmt);
                break;

            case 2:
                Console.Write("Enter withdraw amount: ");
                int withdrawAmt = int.Parse(Console.ReadLine());
                selectedAccount.Withdraw(withdrawAmt);
                break;

            case 3:
                selectedAccount.BalanceEnquiry();
                break;

            case 4:
                Console.WriteLine("Exit");
                return;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}

    // Main method
    // public static void Main()
    // {
    //     Account ac = new Account(1234567890);


    //     while (true)
    //     {
    //         Console.WriteLine("\n1 Deposit Amount");
    //         Console.WriteLine("2 Withdraw Amount");
    //         Console.WriteLine("3 Balance Enquiry");
    //         Console.WriteLine("4 Exit");

    //         Console.Write("Enter Your Choice: ");
    //         int choice = int.Parse(Console.ReadLine());

    //         switch (choice)
    //         {
    //             case 1:
    //                 Console.Write("Enter Deposit Amount: ");
    //                 int depositAmt = int.Parse(Console.ReadLine());
    //                 ac.Deposit(depositAmt);
    //                 break;

    //             case 2:
    //                 Console.Write("Enter withdraw amount: ");
    //                 int withdrawAmt = int.Parse(Console.ReadLine());
    //                 ac.Withdraw(withdrawAmt);
    //                 break;

    //             case 3:
    //                 ac.BalanceEnquiry();
    //                 break;

    //             case 4:
    //                 Console.WriteLine("Exit");
    //                 return;

    //             default:
    //                 Console.WriteLine("Invalid choice");
    //                 break;
    //         }
    //     }
    // }
}

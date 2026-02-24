using AccountLibrary;

namespace AccountExample
{
    class MainClass
    {
        static Account[] accounts = new Account[10];
        static int counter;
        

        static bool search(int accountNumber)
        {
            for (int location = 0; location < counter; location++)
            {
                if (accounts[location].AccountNumber == accountNumber)
                {
                    Transaction(location);
                    return true;
                }
            }
            return false;
        }
        static void Transaction(int location)
        {
            int operationCode;
            int amount;

            Console.WriteLine("\nWhat Operation You Want To Perform");
            Console.WriteLine("1.Deposit\n2.Withdraw\n3.Balance Enquiry\n4.Print Account Details");
            Console.Write("Enter Operation Code: ");
            operationCode = int.Parse(Console.ReadLine());

            switch (operationCode)
            {
                case 1:
                    Console.Write("Enter Amount To Deposit: ");
                    amount = int.Parse(Console.ReadLine());
                    accounts[location].Deposit(amount);
                    break;
                case 2:
                    Console.Write("Enter Amount To Withdraw: ");
                    amount = int.Parse(Console.ReadLine());
                    accounts[location].Withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine("Current Balance: " + accounts[location].BalanceEnquiry());
                    break;
                case 4:
                    accounts[location].AccountDetails();
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Operation Code Between 1-4 only");
                    break;
            }
        }

        static void Main()
        {
            
            int requirementCode;
            string name;
            int amount;
            char choice;            
            int accountNumber;
            bool found;
            
            do
            {
                Console.WriteLine("\nWhat is your Requirement");
                Console.WriteLine("1.Create a new Account Object\n2.Perform Transaction in Existing Account\n3.Print Details of All Accounts");
                Console.Write("Enter Requirement Code: ");
                requirementCode = int.Parse(Console.ReadLine());

                switch (requirementCode)
                {
                    case 1:
                        Console.Write("\nEnter Account Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Initial Deposit Amount: ");
                        amount = int.Parse(Console.ReadLine());
                        accounts[counter++] = new Account(name, amount);
                        break;

                    case 2:
                        found = false;
                        Console.WriteLine("\nWhich Account You Want To Perform Transaction");
                        Console.Write("Enter Account Number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        found=search(accountNumber);
                        if (!found) Console.WriteLine("Invalid Account Number");                
                        break;
                    case 3:
                        for (int i= 0;i < counter;i++)
                        {
                            accounts[i].AccountDetails();
                        }
                        break;
                }
                Console.Write("Do You Have Any Other Requirement('Y|N'): ");
                choice = char.Parse(Console.ReadLine());
            } while (choice == 'y' | choice=='Y');
            Console.WriteLine("**********Thank For Banking With Us***********");


        }
    }
}



















// using AccountLibrary;

// Account[] accounts = new Account[10];
// int requirmentCode,operationCode;
// string name;
// int amount;
// char Choice;
// bool found;
// int accountNumber;
// int counter = 0;

// do{
//     Console.WriteLine("What is your Requirment");
//     Console.WriteLine("1. Create an Account object");
//     Console.WriteLine("2. Perform trancastion on extising account");
//     Console.WriteLine("3. Print Details of all Accounts");
//     Console.Write("Enter your Requirment Code  ");
//     requirmentCode = int.Parse(Console.ReadLine());

//     switch(requirmentCode)
//     {
//         case 1:
//         Console.Write("\nEnter the Account name :  ");
//         name = Console.ReadLine();
//         Console.Write("Enter intinal deposit amount :  ");
//         amount = int.Parse(Console.ReadLine());
//         accounts[counter++] = new Account(name, amount);
//         break;

//         case 2:

//         Console.WriteLine("In which account to operation you want to perform ");
//         Console.WriteLine("Enter Account Number");
//         accountNumber = int.Parse(Console.ReadLine());
//         found = false;

//         for(int i =0;i< counter;i++)
//         {
//             if(accounts[i].AccountNumber == accountNumber)
//                 {
//                     found = true;

//                     Console.WriteLine("What operation to want to perform");
//                     Console.WriteLine("1 Deposit");
//                     Console.WriteLine("2 Withdraw");
//                     Console.WriteLine("3 Balance Enquiry");
//                     Console.WriteLine("4 Print Account details");
//                     operationCode = int.Parse(Console.ReadLine());

//                     switch(operationCode)
//                     {
//                         case 1:
//                         Console.Write("Enter the Amount to Deposit");
//                         amount = int.Parse(Console.ReadLine());
//                         accounts[i].Deposit(amount);
//                         break;

//                         case 2:
//                         Console.Write("Enter the Amount to Withdraw");
//                         amount = int.Parse(Console.ReadLine());
//                         accounts[i].Withdraw(amount);
//                         break;    

//                         case 3:
//                         Console.WriteLine("Current Balance "+accounts[i].BalanceEnquiry());
//                         break;

//                         case 4:
//                         accounts[i].AccountDetails();
//                         break;

//                         default:
//                         Console.WriteLine("Please enter the valid operation code");
//                         break;   
//                     }
//                     break;
//                 }
//         }
//         if(found == false)
//             {
//                 Console.WriteLine("Invalid Account number");
//                 break;
//             }


//         break;

//         case 3:
//         for(int i = 0; i < counter;i++)
//         {
//             accounts[i].AccountDetails();
//         }
//         break;
//     }
//     Console.Write("Do You have any other Requirments('Y|N): ");
//     Choice = char.Parse(Console.ReadLine());

// }while(Choice == 'y' | Choice =='Y');

// Console.WriteLine("******************** Thank for banking with us ************************");

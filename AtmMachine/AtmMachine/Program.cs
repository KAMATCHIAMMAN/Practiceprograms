using System.Collections;
using System.Collections.Generic;
namespace AtmMachine
{
    public class Program
    {
        public string UserService(int CardNumber,int PinNumber)
        {
            Hashtable userdetails = new Hashtable();
            Hashtable userdetailstwo = new Hashtable();

            userdetails.Add(12345, 50000);
            userdetails.Add(67890, 40000);
            userdetails.Add(54321, 30000);
            userdetailstwo.Add(12345, 0000);
            userdetailstwo.Add(67890, 1111);
            userdetailstwo.Add(54321, 2222);

            if (userdetails.ContainsKey(CardNumber) && userdetailstwo.ContainsValue(PinNumber))
            {
                Console.WriteLine("Choose serive :");
                Console.WriteLine("1.Balance Encuary");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw ");
                Console.WriteLine("4.Transfer");
                int service = Convert.ToInt32(Console.ReadLine());
                switch(service)
                {
                    case 1:
                        Console.WriteLine("Your Account Balaence is {0}",userdetails[CardNumber]);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Amount to Deposit");
                        int DepositAmount = Convert.ToInt32(Console.ReadLine());
                        userdetails[CardNumber]=Convert.ToInt32(userdetails[CardNumber])+DepositAmount;
                        Console.WriteLine("Your Account Balaence is {0}", userdetails[CardNumber]);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Amount to Withdraw");
                        int WithdrawAmount = Convert.ToInt32(Console.ReadLine());
                        userdetails[CardNumber]=Convert.ToInt32(userdetails[CardNumber])-WithdrawAmount;
                        Console.WriteLine("Your Account Balaence is {0}", userdetails[CardNumber]);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Amount to Transfer");
                        int TransferAmount = Convert.ToInt32(Console.ReadLine());
                        userdetails[CardNumber]=Convert.ToInt32(userdetails[CardNumber])-TransferAmount;
                        Console.WriteLine("Your Account Balaence is {0}", userdetails[CardNumber]);
                        break;

                    default:Console.WriteLine("Choose the vaild opition");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Please enter correct pin number");
            }
            Console.WriteLine("If you want to continue press yes or else press no : ");
            string UserWish=Console.ReadLine();
            return UserWish;
        }
        static void Main(string[] args)
        {
            Program Atmserice = new Program();    
            Console.WriteLine("Welcome to Indian Bank Atm .");
            Console.WriteLine("Please Insert your card properly for successful service .");
            Console.WriteLine("Please Enter your Number and PIN :");
            int CardNumber = Convert.ToInt32(Console.ReadLine());
            int PinNumber = Convert.ToInt32(Console.ReadLine());
            string WishToContinue = Atmserice.UserService(CardNumber, PinNumber);
            if (WishToContinue.Equals("yes"))
            {
                Atmserice.UserService(CardNumber, PinNumber);
            }
            else
            {
                Console.WriteLine("Thank you for visit.....");
            }
        }
    }
}
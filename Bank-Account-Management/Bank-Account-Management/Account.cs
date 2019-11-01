using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management
{
    class Account
    {
        private int accountID;
        private decimal balance;
        private string lastName;
        private string firtName;

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        public string FirtName
        {
            get { return firtName; }
            set { firtName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(int account, string firtname, string lastname, decimal balance)
        {
            this.AccountID = account;
            this.FirtName = firtName;
            this.LastName = lastname;
            this.Balance = balance;
        }

        public void FillInfor()
        {
            Console.WriteLine("xin mời nhập Account ID: ");
            AccountID = int.Parse(Console.ReadLine());
            Console.WriteLine("Firt Name: ");
            FirtName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Balance: ");
            Balance = int.Parse(Console.ReadLine());
        }

        public void Query()
        {
            Console.WriteLine("Account: " +AccountID);
            Console.WriteLine("Firt Name: "+FirtName);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Balance: "+Balance);
        }
    }
}

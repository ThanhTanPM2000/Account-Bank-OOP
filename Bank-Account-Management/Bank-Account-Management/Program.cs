using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("==================================================");
                Console.WriteLine("\t bank account management"
                    + Environment.NewLine
                    + "1. Add Account"
                    + Environment.NewLine
                    + "2. Save"
                    + Environment.NewLine
                    + "3. Load");
                Console.Write("Nhập: ");
                int usercomand = int.Parse(Console.ReadLine());
                AccountList al = new AccountList();
                switch (usercomand)
                {
                    case 1:
                        al.NewAccounts();
                        break;
                    case 2:
                        al.SaveFile();
                        break;
                    case 3:
                        al.LoadFile();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Bank_Account_Management
{
    class AccountList
    {
        private ArrayList Accounts = new ArrayList();

        public void NewAccounts()
        {
            Account acc = new Account();
            acc.FillInfor();
            Accounts.Add(acc);
        }

        public void SaveFile()
        {
            Console.WriteLine("nhập vào file mà bạn muốn lưu");
            string filename = Console.ReadLine();
            //đọcfile

            try
            {
                //tạo luồng file truy cập
                FileStream output = new FileStream(filename,
                    FileMode.CreateNew, FileAccess.Write);

                //thiết lập writer
                StreamWriter writer = new StreamWriter(output);

                //duyệt qua từng đối tượng trong Accounts
                foreach (Account acc in Accounts)
                {
                    //lưu các thông tin của một account trên dòng, phân cách nhau bằng dấu ,
                    writer.WriteLine("{0},{1},{2},{3}", acc.AccountID, acc.FirtName, acc.LastName, acc.Balance);
                }
                //đóng kết nối
                writer.Close();
                output.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile()
        {
            // đọc tên file chứa dữ liệu 
            Console.WriteLine("nhập file mà bạn muốn đọc ");
            string FileLoad = Console.ReadLine();
            // xóa danh sách
            Accounts.Clear();

            try
            {
                // tạo luồng đọc file
                FileStream input = new FileStream(FileLoad,
                    FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                //đọc qua từng dòng kết thúc khi chuỗi null
                while ((str = reader.ReadLine())!=null)
                {
                    //tách chuỗi đọc ra thành các chuỗi con có phân cách nhau dấu ','
                    string[] list = str.Split(',');

                    //tạo đối tượng account mới
                    Account acc = new Account(int.Parse(list[0]), list[1], list[2], decimal.Parse(list[3]));
                    //đưa đối tượng mới đọc vào danh sách account
                    Accounts.Add(acc);
                }

                // đóng luồng
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

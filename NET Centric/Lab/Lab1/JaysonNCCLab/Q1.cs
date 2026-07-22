using System;

namespace JaysonNCCLab
{
    class Account
    {
        public string Username;
        public static string AppName;

        public Account()
        {
            Username = "Guest";
        }

        public Account(string name)
        {
            Username = name;
        }

        public Account(Account other)
        {
            Username = other.Username;
        }

        private Account(int id)
        {
            Username = "Admin";
        }

        public static Account CreateAdmin()
        {
            Account admin = new Account(1);
            return admin;
        }

        static Account()
        {
            AppName = "Lab";
        }
    }

    class Q1
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Console.WriteLine("Default: " + acc1.Username);

            Account acc2 = new Account("Jayson");
            Console.WriteLine("Parameterized: " + acc2.Username);

            Account acc3 = new Account(acc2);
            Console.WriteLine("Copied: " + acc3.Username);

            Account acc4 = Account.CreateAdmin();
            Console.WriteLine("Private: " + acc4.Username);

            Console.WriteLine("Static: " + Account.AppName);

            Console.WriteLine("\nLab No: 1");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }
    }
}
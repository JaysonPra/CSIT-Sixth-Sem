using System;

namespace JaysonNCCLab
{
    public delegate void Notify(string message);

    class Button
    {
        public event Notify? Clicked;

        public void Click()
        {
            Clicked?.Invoke("Button was clicked!");
        }
    }

    class Q9
    {
        static void Main(string[] args)
        {
            Notify singleDel = ShowAlert;
            singleDel("Single delegate call");

            Notify multiDel = ShowAlert;
            multiDel += ShowLog;
            multiDel("Multicast delegate call");

            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine("Func Result (Add): " + add(5, 10));

            Action<string> print = message => Console.WriteLine("Action: " + message);
            print("Action delegate call");

            // Continue from here

            Notify anonDel = delegate (string msg)
            {
                Console.WriteLine("Anonymous Method: " + msg);
            };
            anonDel("Anonymous call");

            Button btn = new Button();
            btn.Clicked += ShowAlert;
            btn.Clicked += ShowLog;
            btn.Click();

            Console.WriteLine("\nLab No: 9");
            Console.WriteLine("Name: Jayson Pradhananga");
            Console.WriteLine("Roll No: 80011011");
        }

        static void ShowAlert(string msg)
        {
            Console.WriteLine("Alert: " + msg);
        }

        static void ShowLog(string msg)
        {
            Console.WriteLine("Log: " + msg);
        }
    }
}
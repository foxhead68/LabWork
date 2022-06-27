using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(15, 10);
            PrintMessage();
            string callSign = GetMessage();
        }

        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }

        static string GetMessage()
        {
            Console.Write("What is your call sign? ");
            string msg = Console.ReadLine();
            return msg;
        }

    }
}

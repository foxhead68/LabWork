using System;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 15, n2 = 10;
            int result = Add(n1, n2);
            PrintMessage();
            string callSign = GetMessage();
            PrintMessage(callSign);
            Timestamp(ref callSign);
            PrintMessage(callSign);

            Random rando = new Random();
            n1 = rando.Next(100);
            n2 = rando.Next(100);
            result = 0;
            GetSum(n1, n2, ref result);
            //$ - C# interpolated string
            Console.WriteLine($"{n1} + {n2} = {result}");
            Console.WriteLine(DateTime.Now);
        }

        static void Timestamp(ref string message)
        {
            message = $"{DateTime.Now}: {message}";
        }

        static void GetSum(int num1, int num2, ref int sum)
        {
            sum = num1 + num2;
        }

        static int Add(int num1, int num2)
        {
            num1 += 5;
            int sum = num1 + num2;
            return sum;
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string GetMessage()
        {
            Console.Write("What is your call sign? ");
            string msg = Console.ReadLine();
            return msg;
        }

    }
}

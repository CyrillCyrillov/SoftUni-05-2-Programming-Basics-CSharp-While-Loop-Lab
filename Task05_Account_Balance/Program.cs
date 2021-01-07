using System;

namespace Task05_Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            while (true)
            {
                string nextIncrease = Console.ReadLine();
                if (nextIncrease == "NoMoreMoney")
                {
                    break;
                }
                double nextSum = double.Parse(nextIncrease);
                if (nextSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {nextSum:F2}");
                totalSum += nextSum;
            }
            
            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}

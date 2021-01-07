using System;

namespace Task03_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int upLine = int.Parse(Console.ReadLine());
            int nextNumber = int.MinValue;
            int sum = 0;
            while (sum < upLine)
            {
                nextNumber = int.Parse(Console.ReadLine());
                sum += nextNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

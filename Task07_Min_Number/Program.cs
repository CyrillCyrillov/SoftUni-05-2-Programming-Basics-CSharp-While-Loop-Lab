using System;

namespace Task07_Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string nextNumber = Console.ReadLine();
                if (nextNumber == "Stop")
                {
                    break;
                }
                int nextNumberDigit = int.Parse(nextNumber);
                if (nextNumberDigit < minNumber)
                {
                    minNumber = nextNumberDigit;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}

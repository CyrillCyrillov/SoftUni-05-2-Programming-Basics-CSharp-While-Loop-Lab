using System;

namespace Task06_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            while (true)
            {
                string nextNumber = Console.ReadLine();
                if (nextNumber == "Stop")
                {
                    break;
                }
                int nextNumberDigit = int.Parse(nextNumber);
                if (nextNumberDigit > maxNumber)
                {
                    maxNumber = nextNumberDigit;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}

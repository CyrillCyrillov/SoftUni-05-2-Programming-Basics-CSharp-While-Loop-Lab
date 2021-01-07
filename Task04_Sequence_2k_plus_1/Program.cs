using System;

namespace Task04_Sequence_2k_plus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nextNumber = 1;
            while (nextNumber <= n)
            {
                Console.WriteLine(nextNumber);
                nextNumber = nextNumber * 2 + 1;
            }
        }
    }
}

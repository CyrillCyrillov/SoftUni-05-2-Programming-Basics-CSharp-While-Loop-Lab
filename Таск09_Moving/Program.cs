using System;

namespace Таск09_Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimentionOne = int.Parse(Console.ReadLine());
            int dimentionTwo = int.Parse(Console.ReadLine());
            int dimentionThree = int.Parse(Console.ReadLine());
            int volume = dimentionOne * dimentionTwo * dimentionThree;
            int volumeIn = 0;
            while (volumeIn < volume)
            {
                string nextIn = Console.ReadLine();
                if (nextIn == "Done")
                {
                    break;
                }
                volumeIn += int.Parse(nextIn);
            }
            if (volumeIn <= volume)
            {
                Console.WriteLine($"{(volume - volumeIn)} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {(volumeIn - volume)} Cubic meters more.");
            }
        }
    }
}

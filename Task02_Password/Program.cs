using System;

namespace Task02_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passWord = Console.ReadLine();
            string input = " ";
            while (input != passWord)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}

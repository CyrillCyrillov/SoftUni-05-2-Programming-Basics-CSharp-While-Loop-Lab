using System;

namespace Task01_Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Stop")
                {
                    break;
                }
                Console.WriteLine(name);
            }
        }
    }
}

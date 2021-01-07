using System;

namespace Task08_Graduation_pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int badGrades = 0;
            double sum = 0;
            string name = Console.ReadLine();
            while (n <= 12)
            {
                double nextEvaluation = double.Parse(Console.ReadLine());
                if (nextEvaluation < 4)
                {
                    badGrades += 1;
                }
                if (badGrades == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {n - 1} grade");
                    break;
                }
                sum += nextEvaluation;
                n += 1;
            }
            if (badGrades < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):F2}");
            }
        }
    }
}

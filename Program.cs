using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers between {0} and {1} are:", n1, n2);

            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}


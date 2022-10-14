using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 };
            int i = 0;
            while (i < 20)
            {
                Console.WriteLine(num[i]);
                i++;
            }
        }
    }
}
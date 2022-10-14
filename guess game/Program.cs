using System;
using System.Runtime.InteropServices;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                int v = 3 - i;
                int guesses = v;
                Console.WriteLine("Its a bird. ");
                Console.WriteLine("Guess something. ");
                Console.WriteLine("you have " + guesses + " guesses left. ");
                string a = Console.ReadLine();
                if (a == "duck")
                {
                    Console.WriteLine("Correct! ");
                    i = 3;
                }
                i++;
            }
            if (i == 3)
            {
                Console.WriteLine("You've failed :( ");
            }
        }
    }
}
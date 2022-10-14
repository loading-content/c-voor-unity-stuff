internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("wil je plus / +, min / -, keer / *, of delen / / doen");
        string vraag = Console.ReadLine();
        if (vraag == "plus" || vraag == "+")
        {
            float a = 0;
            float b = 0;
            Console.WriteLine("Zeg een getal");
            string a1 = Console.ReadLine();
            Console.WriteLine("Zeg nog een getal");
            string b1 = Console.ReadLine();
            a = Convert.ToSingle(a1);
            b = Convert.ToSingle(b1);
            float c = a + b;
            Console.WriteLine(a + " + " + b + " = " + c);
        }
        if (vraag == "min" || vraag == "-")
        {
            float a = 0;
            float b = 0;
            Console.WriteLine("Zeg een getal");
            string a1 = Console.ReadLine();
            Console.WriteLine("Zeg nog een getal");
            string b1 = Console.ReadLine();
            a = Convert.ToSingle(a1);
            b = Convert.ToSingle(b1);
            float c = a - b;
            Console.WriteLine(a + " - " + b + " = " + c);
        }
        if (vraag == "keer" || vraag == "*")
        {
            float a = 0;
            float b = 0;
            Console.WriteLine("Zeg een getal");
            string a1 = Console.ReadLine();
            Console.WriteLine("Zeg nog een getal");
            string b1 = Console.ReadLine();
            a = Convert.ToSingle(a1);
            b = Convert.ToSingle(b1);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("no");
                Console.WriteLine("");
                Main(args);
            }
            float c = a * b;
            Console.WriteLine(a + " * " + b + " = " + c);
        }
        if (vraag == "delen" || vraag == "/")
        {
            float a = 0;
            float b = 0;
            Console.WriteLine("Zeg een getal");
            string a1 = Console.ReadLine();
            Console.WriteLine("Zeg nog een getal");
            string b1 = Console.ReadLine();
            a = Convert.ToSingle(a1);
            b = Convert.ToSingle(b1);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("no");
                Console.WriteLine("");
                Main(args);
            }
            float c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);
        }
        else
        {
            Console.WriteLine("Dat is niet valid probeer opnieuw");
            Console.WriteLine(" ");
            Main(args);
        }
    }
}
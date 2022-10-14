using System;
using System.Data;

namespace Bibliotheek
{
    class Program
    {
        public class Boek
        {
            public string type;
            public string model;
            public string os;
            public string maker;
            public int price;
            public Boek(string type, string model, string os, string maker, int price)
            {
                this.type = type;
                this.model = model;
                this.os = os;
                this.maker = maker;
                this.price = price;
            }
        }
        static void Main(string[] args)
        {
            float btw = 0.21f;

            Boek boek1 = new Boek("Iphone", "Iphone XS", "Apple IOS", "Steve Jobs", 500);
            Boek boek2 = new Boek("Samsung", "Galaxy S7", "Android", "Andy Rubin", 400);
            Boek boek3 = new Boek("Google Pixel", "Pixel 3", "Chrome OS", "Sundar Pichai", 300);

            Console.WriteLine("Welke telefoon wil je kopen? ");
            Console.WriteLine("(je moet het hetzelfde spellen als het er staat)");
            Console.WriteLine("");

            Console.WriteLine(boek1.type + ":");
            Console.WriteLine("model = " + boek1.model);
            Console.WriteLine("prijs = $" + boek1.price + ". (exclusief btw)");
            Console.WriteLine("");

            Console.WriteLine(boek2.type + ":");
            Console.WriteLine("prijs = " + boek2.model);
            Console.WriteLine("model = $" + boek2.price + ". (exclusief btw)");
            Console.WriteLine("");

            Console.WriteLine(boek3.type + ":");
            Console.WriteLine("model = " + boek3.model);
            Console.WriteLine("prijs = $" + boek3.price + ". (exclusief btw)");
            Console.WriteLine("");

            string keuze = Console.ReadLine();

            if (keuze == boek1.type || keuze == boek1.model)
            {
                float a = 0;
                Console.WriteLine("hoeveel " + boek1.model + " wil je? ");
                Console.WriteLine("");
                string aantal = Console.ReadLine();
                a = Convert.ToSingle(aantal);
                float totaal = a * boek1.price + (a * boek1.price) * btw;
                if (totaal > 1000)
                {
                    totaal = totaal * 0.90f;
                }
                Console.WriteLine("dat is dan $" + totaal + ". ");
            }

            else if (keuze == boek2.type || keuze == boek2.model)
            {
                float a = 0;
                Console.WriteLine("hoeveel " + boek2.model + " wil je? ");
                Console.WriteLine("");
                string aantal = Console.ReadLine();
                a = Convert.ToSingle(aantal);
                float totaal = a * boek2.price + (a * boek2.price) * btw;
                if (totaal > 1000)
                {
                    totaal = totaal * 0.90f;
                }
                Console.WriteLine("dat is dan $" + totaal + ". ");
            }
            else if (keuze == boek3.type || keuze == boek3.model)
            {
                float a = 0;
                Console.WriteLine("hoeveel " + boek3.model + " wil je? ");
                Console.WriteLine("");
                string aantal = Console.ReadLine();
                a = Convert.ToSingle(aantal);
                float totaal = a * boek3.price + (a * boek3.price) * btw;
                if (totaal >= 1000)
                {
                    totaal = totaal * 0.90f;
                    Console.WriteLine("je krijgt korting. ");
                }
                Console.WriteLine("dat is dan $" + totaal + ". ");

            }
            else
            {
                Console.Clear();
                Main(args);
            }
        }
    }
}
using System;
using System.ComponentModel;
using System.Runtime;

namespace Boodschappen
{
    public class pr
    {
        public string product;
        public float prijsExclBtw;
        public float btwPercentage = 0.21f;
        public pr(string product, float prijsExclBtw)
        {
            this.product = product;
            this.prijsExclBtw = prijsExclBtw;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            float totaal = 0f;
            float btwPercentage = 0.21f;

            pr ip = new pr("ipphone", 89);
            pr sam = new pr("samung", 189);
            pr bannaar = new pr("banaare", 1);
            pr amonus = new pr("amonus", 35);
            pr kruifat = new pr("kruifat", 84);
            pr water = new pr("water", 39);
            pr peach = new pr("peach", 87);
            pr joemama = new pr("joemama", 46);
            pr shirt = new pr("shirt", 18);
            pr pencis = new pr("pencis", 72);

            int i = 1;
            while (i < 4)
            {
                Console.WriteLine(i + "e product(en)");
                Console.WriteLine("Kies een producs");
                Console.WriteLine(ip.product + " kost $" + ip.prijsExclBtw + " ex btw.");
                Console.WriteLine(sam.product + " kost $" + sam.prijsExclBtw + " ex btw.");
                Console.WriteLine(bannaar.product + " kost $" + bannaar.prijsExclBtw + " ex btw.");
                Console.WriteLine(amonus.product + " kost $" + amonus.prijsExclBtw + " ex btw.");
                Console.WriteLine(kruifat.product + " kost $" + kruifat.prijsExclBtw + " ex btw.");
                Console.WriteLine(water.product + " kost $" + water.prijsExclBtw + " ex btw.");
                Console.WriteLine(peach.product + " kost $" + peach.prijsExclBtw + " ex btw.");
                Console.WriteLine(joemama.product + " kost $" + joemama.prijsExclBtw + " ex btw.");
                Console.WriteLine(shirt.product + " kost $" + shirt.prijsExclBtw + " ex btw.");
                Console.WriteLine(pencis.product + " kost $" + pencis.prijsExclBtw + " ex btw.");

                Console.WriteLine("");
                Console.WriteLine("Wat wil je kopen? ");
                string a = Console.ReadLine();

                if (a == ip.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (ip.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == sam.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (sam.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == bannaar.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (bannaar.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == amonus.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (amonus.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == kruifat.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (kruifat.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == water.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (water.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == peach.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (peach.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == joemama.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (joemama.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == shirt.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (shirt.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else if (a == pencis.product)
                {
                    Console.WriteLine("");
                    Console.WriteLine("hoeveel wil je? ");
                    string hv = Console.ReadLine();
                    int hv1 = Convert.ToInt32(hv);
                    totaal = totaal + (pencis.prijsExclBtw * hv1);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("dat bestaat niet probeer opnieuw");
                    Console.WriteLine("");
                    Main(args);
                }
                i++;
            }
            float totaalPrijs = totaal + totaal * btwPercentage;
            Console.WriteLine("");
            Console.WriteLine("dat kost dan $" + totaalPrijs + ". ");
        }
    }
}


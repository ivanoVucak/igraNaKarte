using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta;
            int rezultat = 0;

            Console.WriteLine("Igra na karte");
            Console.WriteLine("Unesite kartu od 1 do 13");

            do
            {
                ponovo: Console.Write("Unesi kartu: ");
                karta = Convert.ToInt32(Console.ReadLine());
                if (karta < 1 || karta > 13) {
                    Console.WriteLine();
                Console.WriteLine("Niste unesli ispravnu kartu!");
                    Console.WriteLine();
                }
                if (karta >= 1 && karta <= 13)
                {
                    rezultat = rezultat + karta;
                }

            } while (rezultat < 31);
            if (rezultat == 31)
            {
                Console.WriteLine("Pobijedili ste sa rezultatom jednak 31!");
            }
            else {
                Console.WriteLine("Ovaj put ste izgubili jer vam je rezultat bodova veći od 31!");

            }
            Console.ReadKey();
        }
    }
}

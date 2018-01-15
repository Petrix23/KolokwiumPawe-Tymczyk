using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            char decyzja;

            do
            {
                Console.WriteLine("Co chcesz zrobić?\nA - buduj biurowiec\nB - buduj dom jednorodzinny.\nX - wyjscie z aplikacji.");
                decyzja=Convert.ToChar(Console.ReadLine());

                if(decyzja=='X')
                {
                    Console.WriteLine("Dziękuję za skorzystanie z programu.");
                    break;
                }
                else if(decyzja=='A')
                {
                    SzefBudowy projekt = new SzefBudowy();

                    Console.WriteLine("Na jaki kolor pomalować elewację biurowca\n(1- Biel,2- Czerwony,3- Zielony,4- Czarny)? ");
                    int elewacja = Convert.ToInt32(Console.ReadLine());
                    Kolor kolor = (Kolor)elewacja;

                    string drzwi;
                    Console.WriteLine("Na jakie drzwi ma mieć biurowiec? ");
                    drzwi = Console.ReadLine();

                    string okna;
                    Console.WriteLine("Na jakie okna ma mieć biurowiec? ");
                    okna = Console.ReadLine();

                    projekt.Buduj(okna, drzwi, kolor);

                    Console.WriteLine("Zbudowano: ");
                    projekt.ToString();
                }
                else if(decyzja=='B')
                {
                    SzefBudowy projekt = new SzefBudowy();

                    int elewacja = Convert.ToInt32(2);
                    Kolor kolor = (Kolor)elewacja;

                    string drzwi;
                    
                    Console.WriteLine("Na jakie drzwi ma mieć domek? ");
                    drzwi = Console.ReadLine();
                    

                    string okna;
                    Console.WriteLine("Na jakie okna ma mieć domek? ");
                    okna = Console.ReadLine();

                    projekt.Buduj(okna, drzwi);

                    Console.WriteLine("Zbudowano: ");
                    projekt.ToString();
                }
                else
                {
                    Console.WriteLine("Błędnie wybrana opcja.");
                }

            }while(true);

            Console.ReadKey();
        }
    }
}

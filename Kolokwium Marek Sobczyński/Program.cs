using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Marek_Sobczyński
{
    class Program
    {
        static void Main(string[] args)
        {

            int szerokosc = 0;
            int dlugosc = 0;
            int liczbaPomieszczen = 0;
            int numerPomieszczenia = 1;


            do
            {
                Console.WriteLine("podaj liczbe pomieszcen od 1 do 10");
            } while (!int.TryParse(Console.ReadLine(), out liczbaPomieszczen) || liczbaPomieszczen < 0 || liczbaPomieszczen > 11) ;


            while (liczbaPomieszczen != 0)
            {
                            
                Console.WriteLine($"Plan pomieszczenia {numerPomieszczenia}");
                Console.WriteLine();

                do
                {
                    Console.WriteLine("podaj szerokosc podłogi od 3 do 40");
                } while (!int.TryParse(Console.ReadLine(), out szerokosc) || szerokosc < 2 || szerokosc > 41);

                do
                {
                    Console.WriteLine("Podaj dlugosc podlogi od 2 do 25");
                } while (!int.TryParse(Console.ReadLine(), out dlugosc) || dlugosc < 1 || dlugosc > 26);

                Console.Write("*");
                for (int i = 0; i < szerokosc; i++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                Console.WriteLine();

                for (int i = 0; i < dlugosc; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < szerokosc; j++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.Write("*");
                for (int i = 0; i < szerokosc; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("*");

                Console.WriteLine($"szerokosc = {szerokosc} dlugosc = {dlugosc} powierzchnia = {szerokosc * dlugosc}m2 ");
                liczbaPomieszczen--;
                numerPomieszczenia++;
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

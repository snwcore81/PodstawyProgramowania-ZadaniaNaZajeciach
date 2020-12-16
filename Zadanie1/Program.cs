using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int _iIloscLiczb = 0;

            Console.Write("Podaj długość ciągu:");

            if (int.TryParse(Console.ReadLine(), out _iIloscLiczb) && _iIloscLiczb > 0)
            {
                int[] _iTablicaLiczb = new int[_iIloscLiczb];

                for (int i = 0; i < _iIloscLiczb; i++)
                {
                    do
                    {
                        Console.Write($"Podaj {i + 1} liczbę:");
                    }
                    while (!int.TryParse(Console.ReadLine(), out _iTablicaLiczb[i]));
                }

                int _iSumaLiczb = 0;

                Console.Write("Średnia z liczb ");

                for (int i = 0; i < _iIloscLiczb; i++)
                {
                    Console.Write($"{_iTablicaLiczb[i]} ");

                    _iSumaLiczb += _iTablicaLiczb[i];
                }

                float _fSrednia = (float)_iSumaLiczb / (float)_iIloscLiczb;

                Console.WriteLine($"wynosi {_fSrednia}");
            }
            else
            {
                Console.WriteLine("Coś jest grubo nie tak :-/");
            }
        }
    }
}

using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _iIloscLiczb = new int[5];

            int _iDlugoscCiagu = 0;

            Console.Write("Podaj długość ciągu:");

            if (int.TryParse(Console.ReadLine(), out _iDlugoscCiagu) && _iDlugoscCiagu > 0)
            {
                for (int i = 0; i < _iDlugoscCiagu; i++)
                {
                    int _iLiczba = 0;
                    do
                    {
                        Console.Write($"Podaj {i + 1} liczbę z przedziału od 1-5:");
                    }
                    while (int.TryParse(Console.ReadLine(), out _iLiczba) == false || _iLiczba < 1 || _iLiczba > 5);

                    _iIloscLiczb[_iLiczba - 1]++;
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i + 1} ");

                    for (int j = 0; j < _iIloscLiczb[i]; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Coś poszło grubo nie tak :-/");
            }
        }
    }
}

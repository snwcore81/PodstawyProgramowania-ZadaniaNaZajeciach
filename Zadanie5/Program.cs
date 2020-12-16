using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int _iMinimum;
            int _iMaximum;

            Console.Write("Podaj wartość startową (minimalną) > 1 :");

            if (int.TryParse(Console.ReadLine(), out _iMinimum) == false || _iMinimum <2 )
            {
                Console.WriteLine("Coś poszło grubo nie tak :-/");
            }
            else
            {
                Console.Write($"Podaj wartość końcową (maksymalną) > {_iMinimum}:");

                if (int.TryParse(Console.ReadLine(),out _iMaximum) == false || _iMaximum <= _iMinimum)
                {
                    Console.WriteLine("Coś poszło grubo nie tak :-/");
                }
                else
                {
                    bool[] _CzyNieWykreslone = new bool[_iMaximum+1];

                    for (int i = _iMinimum; i <= _iMaximum; i++)
                    {
                        _CzyNieWykreslone[i] = true;
                    }

                    for (int i = _iMinimum; i<=Math.Sqrt(_iMaximum);i++)
                    {
                        if (_CzyNieWykreslone[i] == true)
                        {
                            for (int j=i*2;j<=_iMaximum;j+=i)
                            {
                                _CzyNieWykreslone[j] = false;
                            }
                        }
                    }

                    for (int i=_iMinimum;i<=_iMaximum;i++)
                    {
                        if (_CzyNieWykreslone[i] == true)
                            Console.Write($" {i}");
                    }
                }
            }

            Console.ReadKey();            
        }
    }
}

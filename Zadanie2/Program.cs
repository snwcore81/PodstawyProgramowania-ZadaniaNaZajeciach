using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _sImionaGraczy;
            int[] _iWylosowaneLiczby;
            int _iLiczbaGraczy;

            Random _oLotomat = new Random();

            Console.Write("Podaj liczbę graczy (1-5):");

            if (int.TryParse(Console.ReadLine(), out _iLiczbaGraczy) && _iLiczbaGraczy > 0 && _iLiczbaGraczy < 6)
            {
                _sImionaGraczy = new string[_iLiczbaGraczy];
                _iWylosowaneLiczby = new int[_iLiczbaGraczy];

                for (int i = 0; i < _iLiczbaGraczy; i++)
                {
                    Console.Write($"Podaj imię gracza {i + 1}:");
                    _sImionaGraczy[i] = Console.ReadLine();
                    _iWylosowaneLiczby[i] = _oLotomat.Next(0, 1000) % 10;
                }

                int _iAktualnyGracz = 0;

                while (true)
                {
                    Console.WriteLine($"Gra gracz: {_sImionaGraczy[_iAktualnyGracz]}");

                    int _iLiczba = 0;

                    do
                    {
                        Console.Write("Odgadnij liczbę:");
                    }
                    while (!int.TryParse(Console.ReadLine(), out _iLiczba));

                    if (_iWylosowaneLiczby[_iAktualnyGracz] > _iLiczba)
                    {
                        Console.WriteLine("Liczba zbyt mała! Spróbuj jeszcze raz");
                    }
                    else if (_iWylosowaneLiczby[_iAktualnyGracz] < _iLiczba)
                    {
                        Console.WriteLine("Liczba zbyt duża! Spróbuj jeszcze raz");
                    }
                    else
                    {
                        Console.WriteLine($"Brawo! Wygrywa gracz {_sImionaGraczy[_iAktualnyGracz]}");
                        break;
                    }

                    _iAktualnyGracz++;

                    if (_iAktualnyGracz >= _iLiczbaGraczy)
                        _iAktualnyGracz = 0;
                }

                for (int i = 0; i < _iLiczbaGraczy; i++)
                {
                    Console.WriteLine($"Gracz:{_sImionaGraczy[i]} Wylosowana liczba:{_iWylosowaneLiczby[i]}");
                }
            }
            else
            {
                Console.WriteLine("Coś poszło grubo nie tak :-/");
            }
        }
}

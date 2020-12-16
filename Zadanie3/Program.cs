using System;

namespace Zadanie3
{
    class Program
    {
        static void WyswietlMenu()
        {
            Console.WriteLine();
            Console.WriteLine("***** Menu *****");
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Informacja o autorze");
            Console.WriteLine("3. Wyjście");
            Console.Write("Wybierz opcje (1,2,3):");
        }

        static void InfoOAutorze()
        {
            Console.WriteLine("Aplikacja Menu (C) by Jacek Kuźmicz");
        }

        static void NowaGra()
        {
            Console.WriteLine("@@@@ Rozpoczynasz nową grę @@@@");
        }

        static bool CzyWyjsc()
        {
            Console.Write("Czy wyjść z programu? (T/N):");

            char _sChar = Console.ReadKey().KeyChar;

            if (_sChar == 't')
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            bool _bAplikacjaDziala = true;

            do
            {
                WyswietlMenu();

                int _iOpcja = 0;
                int.TryParse(Console.ReadLine(), out _iOpcja);

                switch (_iOpcja)
                {
                    case 1:
                        NowaGra();
                        break;

                    case 2:
                        InfoOAutorze();
                        break;

                    case 3:
                        if (CzyWyjsc() == true)
                            _bAplikacjaDziala = false;
                        break;

                    default:
                        Console.WriteLine("Wybrano nieprawidłową wartość");
                        break;
                }
            }
            while (_bAplikacjaDziala);
        }
    }
}

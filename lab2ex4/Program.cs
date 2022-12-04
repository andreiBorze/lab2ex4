using System;

namespace lab2ex4
{
    /*Ex 4: Scrieti un program care va determina daca un numar este sau nu palindrom. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va determina daca un numar este sau nu palindrom. \n");

            var nr = 0;
            Console.WriteLine("Introduceti un numar:");
            bool success = int.TryParse(Console.ReadLine(), out nr);

            if (success)
            {
                Console.WriteLine($"Este palindrom: {checkPalindrom(nr)}");
            }
            else
            {
                Console.WriteLine(" Atentie! Ai introdus si litere!");
            }
        }

        private static Boolean checkPalindrom(int nr)
        {
            if (nr > 0)
            {
                var temp = nr;
                var b = 0;
                var digit = 0;
                while (temp != 0)
                {
                    digit = temp % 10;
                    b = b * 10 + digit;
                    temp /= 10;
                }

                return nr == b;
            }
            else
            {
                return false;
            }
        }
    }
}

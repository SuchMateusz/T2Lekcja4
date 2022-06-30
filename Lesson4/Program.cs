using System;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            string firstName;
            string secondName;
            int age;
            char gender;
            int peselNumber;
            int employNumber;

            //Zadanie 2
            char zm1 = 'a';
            char zm2 = 'b';
            char zm3 = 'c';

            Console.WriteLine($"{zm1}{zm2}{zm3}");

            //Zadanie 3

            int a = 2;
            int b = 4;
            double diag = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Przekątna prostokąta wynosi: {diag}.");

            //Zadanie 4
            int value1 = 10;
            string Napis = "Szkoła Dotneta";
            double value2 = 12.5;

            //Zadanie 5

            Console.WriteLine("Podaj imie: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            secondName = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj płeć: m (męzczyzna), k (kobieta)");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer pesel");
            peselNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wage: ");
            double weight = double.Parse(Console.ReadLine());

        }
    }
}
using System;

namespace ConsoleApp1
{
    class Exercici_Fase1
    {
        static void Main(string[] args)
        {
            string nom = "Carles";
            string cognom1 = "Gascó";
            string cognom2 = "Tomàs";

            int dia = 13;
            int mes = 1;
            int any = 2020;

            Console.WriteLine($"{cognom1} {cognom2}, {nom}");
            Console.WriteLine($"{dia}/{mes}/{any}");

            Console.ReadKey(true);
        }
    }
}

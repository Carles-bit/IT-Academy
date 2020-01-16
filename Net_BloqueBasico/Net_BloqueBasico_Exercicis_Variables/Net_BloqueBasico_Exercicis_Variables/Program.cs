using System;

namespace Net_BloqueBasico_Exercicis_Variables
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine($"\nResultat Exercici 1:\n*********************");
            Exercici1();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Exercici 2:\n*********************");
            Exercici2();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Exercici 3:\n*********************");
            Exercici3();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Exercici 4:\n*********************");
            Exercici4();
            Console.ReadKey(true); // Pausa
        }

        //Exercici 1 - Variables, Constants i bucle For
        public static void Exercici1()
        {
            string nom = "Carles";
            string cognom1 = "Gascó";
            string cognom2 = "Tomàs";

            int dia = 13;
            int mes = 1;
            int any = 2020;

            
            Console.WriteLine($"{cognom1} {cognom2}, {nom}");
            Console.WriteLine($"{dia}/{mes}/{any}");
        }

        //Exercici 2 - Variables, Constants i bucle For
        public static void Exercici2()
        {
            const int ANYTRASPAS = 1948;
            int cadaQuantsAnys = 4;
            int anyNaixement = 1966;

            /** Convertim a Int doncs només ens interesa la part entera de la divisió.*/
            int nTraspas = ((anyNaixement - ANYTRASPAS) / cadaQuantsAnys);
                        
            Console.WriteLine($"Numero d'anys de traspàs : {nTraspas}");
        }

        //Exercici 3 - Variables, Constants i bucle For
        public static void Exercici3() 
        {
            int anyNaixement = 1966;
            bool esTraspas = false;
            
            for (int any = 1948; any <= anyNaixement; any++)
            {
                if (((any % 4 == 0) && (any % 100 != 0)) || (any % 400 == 0))
                {
                    Console.WriteLine($"{any}");
                    if (any == anyNaixement)
                    {
                        esTraspas = true ;
                    }
                }
            }

            if (esTraspas)
            {
                Console.WriteLine($"BINGO: Vas néixer en un any de traspàs !!!!");
            }
            else
            {
                Console.WriteLine($"Es teu any de naixement ({anyNaixement}) NO és de traspàs.");
            }
        }

        //Exercici 4 - Variables, Constants i bucle For
        public static void Exercici4()
        {
            string nom = "Carles Gascó Tomàs";
            string dataNaixement = "01/10/1964";
            int any = DateTime.Parse(dataNaixement).Year;

            Console.WriteLine($"El meu nom és {nom}");
            Console.WriteLine($"Vaig néixer el {dataNaixement}");
            if (((any % 4 == 0) && (any % 100 != 0)) || (any % 400 == 0)) 
            {
                Console.WriteLine($"El meu any de naixement és de traspàs.");
            }
        }
    }
}

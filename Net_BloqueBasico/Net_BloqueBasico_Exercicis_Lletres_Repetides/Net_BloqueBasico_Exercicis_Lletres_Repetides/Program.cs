using System;
using System.Collections.Generic;

namespace Net_BloqueBasico_Exercicis_Lletres_Repetides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nResultat Fase 1:\n*********************");
            Fase1();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Fase 2:\n*********************");
            Fase2();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Fase 3:\n*********************");
            Fase3();
            Console.ReadKey(true); // Pausa

            Console.WriteLine($"\nResultat Fase 4:\n*********************");
            Fase4();
            Console.ReadKey(true); // Pausa

        }

        //Fase 1 - Lletres Repetides
        public static void Fase1()
        {
            char[] nom = { 'C', 'a', 'r', 'l', 'e', 's' };
            for (var i = 0; i < nom.Length; i++)
            {
                Console.Write(nom[i]);
            }
            Console.WriteLine();
        }

        //Fase 2 - Lletres Repetides
        public static void Fase2()
        {
            List<char> nom = new List<char> { 'C', 'a', 'r', 'l', 'e', 's', 'E', '1' };
            var nomLower = ' ';

            bool numero = false;

            for (var i = 0; i < nom.Count; i++)
            {
                nomLower = Char.ToLower(nom[i]);
                switch (nomLower)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"{nom[i]} : VOCAL");
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        Console.WriteLine($"{nom[i]} :");
                        numero = true;
                        break;
                    default:
                        Console.WriteLine($"{nom[i]} : CONSONAT");
                        break;
                }
            }

            if (numero)
            {
                Console.WriteLine("\nEls noms de persones no contenen números!");
            }

        }

        //Fase 3 - Lletres Repetides
        public static void Fase3()
        {
            List<char> nom = new List<char> { 'C', 'a', 'r', 'l', 'e', 's', 'E', '1' };
            var nomLower = ' ';
            Dictionary<char, int> lletraCount = new Dictionary<char, int>();
            for (var i = 0; i < nom.Count; i++)
            {
                nomLower = Char.ToLower(nom[i]);

                if (!lletraCount.ContainsKey(nomLower))
                {
                    lletraCount.Add(nomLower, 1);
                }
                else
                {
                    lletraCount[nomLower]++;
                }
            }

            foreach (KeyValuePair<char, int> result in lletraCount)
            {
                Console.WriteLine(string.Format("Lletra {0} apareix {1} vegada/es", result.Key, result.Value));
            }


        }

        //Fase 4 - Lletres Repetides
        public static void Fase4()
        {
            List<char> name = new List<char> { 'C', 'a', 'r', 'l', 'e', 's'};
            List<char> surname = new List<char> { 'G', 'a', 's', 'c', 'ó' };

            
            List<char> fullName = new List<char>() ;

            fullName.AddRange(name);
            fullName.Add(' ');
            fullName.AddRange(surname);

            foreach (var nombre in fullName)
            {
                Console.Write(nombre);
               
            }

            Console.WriteLine();
        }
    }
}

using System;

namespace Noms_Ciutats
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
        
        //Fase 1 - Noms Ciutats
        public static void Fase1()
        {
            string ciutat1 = System.String.Empty;
            string ciutat2 = System.String.Empty;
            string ciutat3 = System.String.Empty;
            string ciutat4 = System.String.Empty;
            string ciutat5 = System.String.Empty;
            string ciutat6 = System.String.Empty;

            Console.Write("Introdueix la Ciutat número 1: ");
            ciutat1 = Console.ReadLine();
            Console.Write("Introdueix la Ciutat número 2: ");
            ciutat2 = Console.ReadLine();
            Console.Write("Introdueix la Ciutat número 3: ");
            ciutat3 = Console.ReadLine();
            Console.Write("Introdueix la Ciutat número 4: ");
            ciutat4 = Console.ReadLine();
            Console.Write("Introdueix la Ciutat número 5: ");
            ciutat5 = Console.ReadLine();
            Console.Write("Introdueix la Ciutat número 6: ");
            ciutat6 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Ciutats introduides : \n\t{ciutat1},\n\t{ciutat2},\n\t{ciutat3},\n\t{ciutat4},\n\t{ciutat5},\n\t{ciutat6}");
           
            Console.WriteLine();
        }

        //Fase 2 - Noms Ciutats
        public static void Fase2()
        {
            string ciutat1 = "Barcelona";
            string ciutat2 = "Madrid";
            string ciutat3 = "Valencia";
            string ciutat4 = "Malaga";
            string ciutat5 = "Cadis";
            string ciutat6 = "Santander";
            string[] ciutats = new string[] { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };

            // Sort array in ascending order. 
            Array.Sort(ciutats);

            Console.WriteLine("Ciutats ordenades alfabeticament:");
            // print all element of array 
            foreach (string value in ciutats)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }

        //Fase 3 - Noms Ciutats
        public static void Fase3()
        {
            string[] ciutats = new string[] { "Barcelona", "Madrid", "Valencia", "Malaga", "Cadis", "Santander" };
            string[] ArrayCiutatsModificades = new string[ciutats.Length];


            for (int i =0; i < ciutats.Length; i++)
            {
                ArrayCiutatsModificades[i] = ciutats[i].Replace('a', '4');
            }

            Array.Sort(ArrayCiutatsModificades);
            Console.WriteLine("Ciutats ordenades alfabeticament (canvi 'a' per '4') :");
            // print all element of array 
            foreach (string value in ArrayCiutatsModificades)
            {
                Console.Write(value + " ");
            }


            Console.WriteLine();
        }

        //Fase 4 - Noms Ciutats
        public static void Fase4()
        {
            string[] ciutats = new string[] { "Barcelona", "Madrid", "Valencia", "Malaga", "Cadis", "Santander" };
            
            char[] ciutat1 = new char[ciutats[0].Length];
            char[] ciutat2 = new char[ciutats[1].Length];
            char[] ciutat3 = new char[ciutats[2].Length];
            char[] ciutat4 = new char[ciutats[3].Length];
            char[] ciutat5 = new char[ciutats[4].Length];
            char[] ciutat6 = new char[ciutats[5].Length];

            for (int i = 0; i < ciutat1.Length; i++)
            {
                ciutat1[i] = ciutats[0][i];
            }
            Console.Write(new string(ciutat1) + " - ");
            Array.Reverse(ciutat1);
            Console.WriteLine(ciutat1);

            for (int i = 0; i < ciutat2.Length; i++)
            {
                ciutat2[i] = ciutats[1][i];
            }
            Console.Write(new string(ciutat2) + " - ");
            Array.Reverse(ciutat2);
            Console.WriteLine(ciutat2);

            for (int i = 0; i < ciutat3.Length; i++)
            {
                ciutat3[i] = ciutats[2][i];
            }
            Console.Write(new string(ciutat3) + " - ");
            Array.Reverse(ciutat3);
            Console.WriteLine(ciutat3);

            for (int i = 0; i < ciutat4.Length; i++)
            {
                ciutat4[i] = ciutats[3][i];
            }
            Console.Write(new string(ciutat4) + " - ");
            Array.Reverse(ciutat4);
            Console.WriteLine(ciutat4);

            for (int i = 0; i < ciutat5.Length; i++)
            {
                ciutat5[i] = ciutats[4][i];
            }
            Console.Write(new string(ciutat5) + " - ");
            Array.Reverse(ciutat5);
            Console.WriteLine(ciutat5);

            for (int i = 0; i < ciutat6.Length; i++)
            {
                ciutat6[i] = ciutats[5][i];
            }
            Console.Write(new string(ciutat6) + " - ");
            Array.Reverse(ciutat6);
            Console.WriteLine(ciutat6);

            Console.WriteLine();
        }
    }
}


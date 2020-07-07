using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fase1();
            fase2();
            fase3();*/
            fase4(); // incluye todos los anteriores
        }

        private static void title(string title)
        {
            Console.WriteLine($"\n\n---\n{title}:\n");
        }

        private static string[] inputCities(int numCities)
        {
            // I'd rather ask and save directly as an array :)
            string[] cities = new string[numCities];
            Console.WriteLine("Introdueix el nom d'una ciutat i prem 'Enter'.");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"    Ciutat {i+1}: ");
                cities[i] = Console.ReadLine();
            }
            return cities;
        }

        private static void printCities(string[] cities)
        {
            Console.WriteLine($"\nNom de les {cities.Length} cities:");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"    {i+1}. {cities[i]}");
            }
        }

        private static void fase1()
        {
            title("fase1");
            int numCities = 6; // we could ask the user to input it
            var cities = inputCities(numCities);
            printCities(cities);
        }

        private static void fase2()
        {
            title("fase2");
            int numCities = 6; // we could ask the user to input it
            var cities = inputCities(numCities);

            Array.Sort<string>(cities); // Sort the string array

            printCities(cities);
        }

        private static string[] replace_a(string[] cities)
        {
            string[] citiesModified = new string[cities.Length];
            for (int i = 0; i < cities.Length; i++)
            {
                citiesModified[i] = cities[i].Replace('a','4');
                // to be more robust also do it for 'A' (maybe using RegExp)
            }
            return citiesModified;
        }

        private static void fase3()
        {
            title("fase3");
            int numCities = 6; // we could ask the user to input it
            var cities = inputCities(numCities);

            Array.Sort<string>(cities); // Sort the string array

            string[] citiesModified = replace_a(cities);

            printCities(citiesModified);
        }

        private static void fase4()
        {
            title("fase4");
            Console.WriteLine("(Includes all previous fases (1-3))\n");
            int numCities = 6; // we could ask the user to input it
            var cities = inputCities(numCities);

            Array.Sort<string>(cities); // Sort the string array

            string[] citiesModified = replace_a(cities);
            printCities(citiesModified);

            // it would be great to do this in a more automated way... ******
            char[] ct0 = new char[cities[0].Length],
                   ct1 = new char[cities[1].Length],
                   ct2 = new char[cities[2].Length],
                   ct3 = new char[cities[3].Length],
                   ct4 = new char[cities[4].Length],
                   ct5 = new char[cities[5].Length];
            
            for (int c = 0; c < cities.Length; c++)
            {
                for (int i = 0; i < cities[c].Length; i++)
                {
                    if (c==0) ct0[i] = cities[c][i];
                    else if (c==1) ct1[i] = cities[c][i];
                    else if (c==2) ct2[i] = cities[c][i];
                    else if (c==3) ct3[i] = cities[c][i];
                    else if (c==4) ct4[i] = cities[c][i];
                    else if (c==5) ct5[i] = cities[c][i];
                }
            }

            // fully reverse char arrays
            Array.Reverse(ct0, 0, ct0.Length);
            Array.Reverse(ct1, 0, ct1.Length);
            Array.Reverse(ct2, 0, ct2.Length);
            Array.Reverse(ct3, 0, ct3.Length);
            Array.Reverse(ct4, 0, ct4.Length);
            Array.Reverse(ct5, 0, ct5.Length);

            // print like a mirror: Barcelona - anolecraB
            Console.WriteLine("\nNom de les ciutats invertits:");
            Console.WriteLine($"    {cities[0]} - {new string(ct0)}");
            Console.WriteLine($"    {cities[1]} - {new string(ct1)}");
            Console.WriteLine($"    {cities[2]} - {new string(ct2)}");
            Console.WriteLine($"    {cities[3]} - {new string(ct3)}");
            Console.WriteLine($"    {cities[4]} - {new string(ct4)}");
            Console.WriteLine($"    {cities[5]} - {new string(ct5)}");
        }
    }
}

using System;

namespace Hackathon2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese la primera cadena: ");
            string cadena1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese la segunda cadena: ");
            string cadena2 = Console.ReadLine().ToLower();
            if (cadena1.Length == cadena2.Length)
            {
                bool desordenado= cadenaDesordenada(cadena1, cadena2);
                if (desordenado)
                {
                    Console.WriteLine("La primera cadena es una cadena " +
                        "desordenada de la segunda");
                }
                else
                {
                    Console.WriteLine("La primera cadena NO es una cadena " +
                        "desordenada de la segunda");
                }
            }
            else
            {
                Console.WriteLine("Las cadenas no tienen la misma longitud");
            }
        }

        public static bool cadenaDesordenada(string cadena1, string cadena2)
        {
            bool encontrado = false;
            string temp = "";
            for (int i = 0; i < cadena1.Length; i++)
            {
                encontrado = false;
                for (int j = 0; j < cadena2.Length; j++)
                {
                    if (cadena1[i] == cadena2[j])
                    {
                        temp = cadena2.Remove(j,1);
                        encontrado = true;
                        break;
                    }
                }
                if (!encontrado)
                {
                    return false;
                }
                cadena2 = temp;
            }
            return true;
        }  
    }
}

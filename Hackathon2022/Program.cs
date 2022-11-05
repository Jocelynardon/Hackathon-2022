using System;
using System.Collections.Generic;

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
                bool desordenado = cadenaDesordenada(cadena1, cadena2);
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

            Console.WriteLine("Ingrese Texto por líneas presionando la tecla Enter. " +
                "Cuando termine, ingrese el caracter $ en una línea independiente");
            List<string> texto = new List<string>();
            string linea = "";
            while (linea != "$")
            {
                linea = Console.ReadLine();
                if (linea.Length > 40)
                {
                    Console.WriteLine("La linea escrita excede el máximo " +
                        "de caracteres");
                }
                else
                {
                    texto.Add(linea);
                }
            }
            justificarTexto(texto);
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
                        temp = cadena2.Remove(j, 1);
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
        public static List<string> justificarTexto(List<string> texto)
        {
            List<string> justificado = new List<string>();
            int contadorCaracteres = 0;
            for (int i = 0; i < texto.Count; i++)
            {
                
            }
            return justificado;
        }
    }
}

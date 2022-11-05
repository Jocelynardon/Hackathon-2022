using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Hackathon2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Scramble");
            Console.WriteLine("2. Justificador de texto");
            Console.WriteLine("3. Cadenas subsecuentes");
            Console.WriteLine("4. Abuela binaria");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Escoge un problema: ");
            int opción = int.Parse(Console.ReadLine());
            switch (opción)
            {
                case 1:
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
                    break;
                case 2:
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
                    List<string> textoJustificado = justificarTexto(texto);
                    for (int i = 0; i < textoJustificado.Count; i++)
                    {
                        Console.WriteLine(textoJustificado[i].ToString());
                    }
                    break;
                case 3:
                    Console.WriteLine("Escriba la primera cadena: ");
                    string cadena_1 = Console.ReadLine();
                    Console.WriteLine("Escriba la segunda cadena: ");
                    string cadena_2 = Console.ReadLine();

                    string ans = CadenaSubsecuente(cadena_1.ToLower(), cadena_2.ToLower());
                    if (ans != "")
                    {
                        Console.WriteLine("La cadena subsecuente es: " + ans);

                    }
                    else
                    {
                        Console.WriteLine("No se encontró una cadena subsecuente :(");
                    }
                    break;
                case 4:
                    Console.WriteLine("Hola nieto! <3 Dime un número: ");
                    int resultado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora dime dos números que sumados den ese resultado <3 ");
                    Console.WriteLine("Primer número: ");
                    int primero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número: ");
                    int segundo = int.Parse(Console.ReadLine());
                    Console.WriteLine(AbuelaBinaria(resultado, primero, segundo));
                    break;
                default:
                    Console.WriteLine("No se escogió una opción válida :(");
                    break;
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
        public static string CadenaSubsecuente(string cadena1, string cadena2)
        {
            string cadenaSubsecuente = "";
            string menorcadena = "";
            string mayorcadena = "";
            if (cadena1.Length <= cadena2.Length)
            {
                menorcadena = cadena1;
                mayorcadena = cadena2;
            }
            else
            {
                menorcadena = cadena2;
                mayorcadena = cadena1;
            }
            for (int i = 0; i < menorcadena.Length; i++)
            {
                if (mayorcadena[i] == menorcadena[i])
                {
                    cadenaSubsecuente += menorcadena[i];
                }
            }
            return cadenaSubsecuente;
        }
        public static List<string> justificarTexto(List<string> texto)
        {
            List<string> justificado = new List<string>();
            int contadorCaracteres = 0;
            for (int i = 0; i < texto.Count; i++) /* Lista de lineas*/
            {
                for (int j = 0; j < texto[i].Length; j++) /* cadena */
                {
                    bool vacio = string.IsNullOrWhiteSpace(texto[i][j].ToString());
                    if (!vacio)
                    {
                        contadorCaracteres++;
                    }
                }
                string[] palabras = texto[i].Split(' ');
                int espaciosAgregar = 40 - contadorCaracteres;
                int divisor = 1;
                if (palabras.Length != 1)
                {
                    divisor = (palabras.Length - 1);
                }
                int espaciosMedio = espaciosAgregar / divisor;
                int espaciosSobrantes = 40 - (espaciosMedio * palabras.Length);
                string nuevaLinea = "";
                int contador = 0;
                for (int k = 0; k < palabras.Length; k++)
                {
                    nuevaLinea += palabras[k];
                    if (k != palabras.Length - 1)
                    {
                        for (int l = 0; l < espaciosMedio; l++)
                        {
                            nuevaLinea += " ";
                        }
                        contador++;
                        if (contador < espaciosSobrantes)
                        {
                            nuevaLinea += " ";
                        }
                    }
                }
                justificado.Add(nuevaLinea);
            }
            return justificado;
        }
        public static string AbuelaBinaria(int resultado, int num1, int num2)
        {
            int count = 0;
            if (num1 + num2 == resultado)
            {
                string binario1 = Convert.ToString(num1, 2);
                string binario2 = Convert.ToString(num2, 2);
                foreach (var item in binario1)
                {
                    if (item == '1')
                    {
                        count++;
                    }
                }
                foreach (var item in binario2)
                {
                    if (item == '1')
                    {
                        count++;
                    }
                }
                return "Muy bien!, te has ganado " + count + " avellanas";
            }
            else
            {
                return "La suma de los números no es igual al resultado :( intenta de nuevo";
            }
        }
    }
}

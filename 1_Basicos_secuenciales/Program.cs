using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Basicos_secuenciales
{
    internal class Program
    {
        static void ejercicio1()
        {
            int num1 = ParseInt("Introduce un número entero: ");
            int num2 = ParseInt("Introduce otro número entero: ");

            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio2()
        {
            float hamburguesa = 3.50f;
            float papas = 1.50f;
            float bebidas = 2.00f;

            int numHamb = ParseInt("Cantidad de hamburguesas: ");
            int numPapas = ParseInt("Cantidad de papas: ");
            int numBeb = ParseInt("Cantidad de bebidas: ");
            float total = hamburguesa * numHamb + papas * numPapas + bebidas * numBeb;
            Console.WriteLine($"Cantidad a pagar: {total} euros");
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio3()
        {
            int num1 = ParseInt("Introduce un número entero: ");
 
            Console.WriteLine("Valor absoluto: " + Math.Abs(num1));
            Console.WriteLine("Potencia al cubo: " + Math.Pow(num1, 3));
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num1));
            Console.WriteLine("Seno: " + Math.Sin(num1));
            Console.WriteLine("Coseno: " + Math.Cos(num1));
            Console.WriteLine();

            int num2 = ParseInt("Ahora introduce otro número: ");
            Console.WriteLine("El número máximo es: " + Math.Max(num1, num2));
            Console.WriteLine("El número mínimo es: " + Math.Min(num1, num2));
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio4()
        {
            Console.WriteLine("Cálculo del perímetro de un cuadrado.");
            float lado = ParseFloat("Introduce la longitud de un lado: ");
            Console.WriteLine("El perímetro del cuadrado es: " + (lado * 4));
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio5()
        {
            Console.WriteLine("Este programa suma los dos primeros números enteros y multiplica los 2 siguientes.");

            int num1 = ParseInt("Introduce el primero: ");
            int num2 = ParseInt("Introduce el segundo: ");
            Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");
            Console.WriteLine();

            Console.WriteLine("Vamos ahora con la multiplicación");
            int num3 = ParseInt("Introduce ahora el tercer número: ");
            int num4 = ParseInt("Introduce el último número: ");
            Console.WriteLine($"La multiplicación de {num3} y {num4} es: {num3 * num4}");
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio6()
        {
            Console.WriteLine("Este programa suma 4 números enteros y calcula su promedio.");
            int num1 = ParseInt("Introduce el primer número: ");
            int num2 = ParseInt("Introduce el segundo número: ");
            int num3 = ParseInt("Introduce el tercer número: ");
            int num4 = ParseInt("Introduce el cuarto número: ");

            int total = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma total es: " + total);

            float promedio = (float)total / 4;
            Console.WriteLine("Su promedio es: " + promedio);
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio7()
        {
            float precio = ParseFloat("Introduce el precio del artículo: ");
            int unid = ParseInt("Introduce el número de unidades: ");

            Console.WriteLine("El precio total es: " + (precio * unid));
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio8()
        {
            Console.WriteLine("Cálculo de la nota final de Desarrollo de Interfaces");
            float parcial1 = ParseFloat("Introduce la primera calificación parcial: ");
            float parcial2 = ParseFloat("Introduce la segunda calificación parcial: ");
            float examen = ParseFloat("Introduce la nota del examen: ");
            float trabajo = ParseFloat("Introduce la nota del trabajo final: ");

            float parciales = (parcial1 + parcial2) / 2;

            Console.WriteLine("Nota final: " + ((parciales * 50) + (examen * 30) + (trabajo * 20)) / 100);
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static void ejercicio9()
        {
            Console.WriteLine("Cálculo del porcentaje de participación de los socios.");
            float socio1 = ParseFloat("Introduce la cantidad que aporta el socio 1: ");
            float socio2 = ParseFloat("Introduce la cantidad que aporta el socio 2: ");
            float socio3 = ParseFloat("Introduce la cantidad que aporta el socio 3: ");

            float total = socio1 + socio2 + socio3;
            float porcentaje1 = (socio1 / total) * 100;
            float porcentaje2 = (socio2 / total) * 100;
            float porcentaje3 = (socio3 / total) * 100;

            Console.WriteLine($"El porcentaje del socio 1 es: {porcentaje1}%");
            Console.WriteLine($"El porcentaje del socio 2 es: {porcentaje2}%");
            Console.WriteLine($"El porcentaje del socio 3 es: {porcentaje3}%");
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static bool ejercicio10()
        {
            Console.Write("Introduce un string: ");
            string entrada = Console.ReadLine();

            return entrada.StartsWith("www");

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        static int ParseInt(string message)
        {
            int number;
            bool isValid;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number);

                if (!isValid)
                    Console.Write("Entrada no válida. Por favor, introduce un número válido: ");
            } while (!isValid) ;

            return number;
        }

        static float ParseFloat(string message)
        {
            float number;
            bool isValid;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out number);

                if (!isValid)
                    Console.Write("Entrada no válida. Por favor, introduce un número válido: ");
            } while (!isValid);

            return number;
        }

        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();
            ejercicio8();
            ejercicio9();
            Console.WriteLine("Esta cadena devuelve: " + ejercicio10());
        }
    }
}

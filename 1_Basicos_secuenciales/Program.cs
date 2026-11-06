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
            Console.Write("Introduce un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine();
        }

        static void ejercicio2()
        {
            float hamburguesa = 3.50f;
            float papas = 1.50f;
            float bebidas = 2.00f;

            Console.Write("Cantidad de hamburguesas: ");
            int numHamb = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de papas: ");
            int numPapas = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de bebidas: ");
            int numBeb = int.Parse(Console.ReadLine());
            float total = hamburguesa * numHamb + papas * numPapas + bebidas * numBeb;
            Console.Write("Cantidad a pagar: " + total);
        }

        static void ejercicio3()
        {
            Console.Write("Introduce un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Valor absoluto: " + Math.Abs(num1));
            Console.WriteLine("Potencia al cubo: " + Math.Pow(num1, 3));
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num1));
            Console.WriteLine("Seno: " + Math.Sin(num1));
            Console.WriteLine("Coseno: " + Math.Cos(num1));
            Console.WriteLine();

            Console.Write("Ahora introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El número máximo es: " + Math.Max(num1, num2));
            Console.Write("El número mínimo es: " + Math.Min(num1, num2));
        }

        static void ejercicio4()
        {
            Console.WriteLine("Cálculo del perímetro de un cuadrado.");
            Console.Write("Introduce la longitud de un lado: ");
            float lado = float.Parse(Console.ReadLine());
            Console.WriteLine("El perímetro del cuadrado es: " + (lado * 4));
        }

        static void ejercicio5()
        {
            Console.WriteLine("Este programa suma los dos primeros números enteros y multiplica los 2 siguientes.");

            Console.Write("Introduce el primero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma de {num1} y {num2} es: {num1 + num2}");
            Console.WriteLine();

            Console.WriteLine("Vamos ahora con la multiplicación");
            Console.Write("Introduce ahora el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el último número: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La multiplicación de {num3} y {num4} es: {num3 * num4}");
        }

        static void ejercicio6()
        {
            Console.WriteLine("Este programa suma 4 números enteros y calcula su promedio.");
            Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el cuarto número: ");
            int num4 = int.Parse(Console.ReadLine());

            int total = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma total es: " + total);

            float promedio = (float)total / 4;
            Console.WriteLine("Su promedio es: " + promedio);
        }

        static void ejercicio7()
        {
            Console.Write("Introduce el precio del artículo: ");
            float precio = float.Parse(Console.ReadLine());
            Console.Write("Introduce el número de unidades: ");
            int unid = int.Parse(Console.ReadLine());

            Console.WriteLine("El precio total es: " + (precio * unid));
        }

        static void ejercicio8()
        {
            Console.WriteLine("Cálculo de la nota final de Desarrollo de Interfaces");
            Console.Write("Introduce la primera calificación parcial: ");
            float parcial1 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la segunda calificación parcial: ");
            float parcial2 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la nota del examen: ");
            float examen = float.Parse(Console.ReadLine());
            Console.Write("Introduce la nota del trabajo final: ");
            float trabajo = float.Parse(Console.ReadLine());

            float parciales = (parcial1 + parcial2) / 2;

            Console.WriteLine("Nota final: " + ((parciales * 50) + (examen * 30) + (trabajo * 20)) / 100);
        }

        static void ejercicio9()
        {
            Console.WriteLine("Cálculo del porcentaje de participación de los socios.");
            Console.Write("Introduce la cantidad que aporta el socio 1: ");
            float socio1 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la cantidad que aporta el socio 2: ");
            float socio2 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la cantidad que aporta el socio 3: ");
            float socio3 = float.Parse(Console.ReadLine());

            float total = socio1 + socio2 + socio3;
            float porcentaje1 = (socio1 / total) * 100;
            float porcentaje2 = (socio2 / total) * 100;
            float porcentaje3 = (socio3 / total) * 100;

            Console.WriteLine($"El porcentaje del socio 1 es: {porcentaje1}%");
            Console.WriteLine($"El porcentaje del socio 2 es: {porcentaje2}%");
            Console.WriteLine($"El porcentaje del socio 3 es: {porcentaje3}%");
        }

        static bool ejercicio10()
        {
            Console.Write("Introduce un string: ");
            string entrada = Console.ReadLine();

            return entrada.StartsWith("www");
        }

        static void Main(string[] args)
        {
            // ejercicio1();
            // ejercicio2();
            // ejercicio3();
            // ejercicio4();
            // ejercicio5();
            // ejercicio6();
            // ejercicio7();
            // ejercicio8();
            // ejercicio9();
            // Console.WriteLine("Esta cadena devuelve: " + ejercicio10());
        }
    }
}

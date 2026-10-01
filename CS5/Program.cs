using System;
// Espacio de nombres
namespace CS5 
{
    class Program
    {
        static void Main(string[] args)
        {

            //Unidad 1: Estructuras de control 2
            //Unidad 2: Funciones 2
            //Sesion 12: Instruccion while 30092026
            //sintaxis:while
            //inicializacion;
            //while(expresion)
            //{
            //      bloque de instrucciones
            //      iterador;
            // }
            //iterar: repetir
            //Ejemplo 1: Ciclo ascendiente (rango: 1-3)
            //m: variable de control
            int m = 1; //Inicializacion
            while(m <= 3)
            {
                //Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1;
            }
            //Ejercitacion
            //1. Definir un ciclo para imprimir tu nombre 5 veces
            //Nota: Para la expresion, utilizar el operador <.
            int n = 0;
            while(n < 5)
            {
                Console.WriteLine("Tu nombre: Gerardo R.");
                n+= 1; // Iterador
            }
            // b. Ciclo descendente
            int d = 3;

            while(d >= 1)
            {
                Console.WriteLine($"d");
                d -= 1;
            }

            // Secuencia 3 6 9 12 15 18

            int s = 3;

            while (s <= 18)
            {
                Console.WriteLine($"S: {s}");
                s += 3;
            }

            // Imprimir 331 8 veces con resta de 2

            int c = 16;

            while (c >= 1)
            {
                Console.WriteLine("331");
                c -= 2;
            }
            // Actividad 1: Ciclo Infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solución, utilizar el operador de diferencia.
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("Ciclo infinito ascendente");
                a += 1; // Iterador
            }

            int b = -1;
            while ( b != 0)
            {
                Console.WriteLine("Ciclo infinito descendente");
                b -= 1; // Iterador
            }
        }
    }
}

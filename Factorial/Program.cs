using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8) Escribir un método que acepte un int y te devuelva el factorial de dicho número.
//Nota: El factorial de 3 es 3*2*1, el factorial de 5 es 5*4*3*2*1, etc.

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    int numero, resultado = 1;

                    Console.WriteLine("Ingrese un número para calcular su factorial: ");                   
                    numero = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numero; i++)
                    {
                        resultado = resultado * i;
                    }
                    Console.WriteLine("El factorial de " + numero + " es:" + resultado);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escribe algún valor válido");
                }

            }

        }
    }
}

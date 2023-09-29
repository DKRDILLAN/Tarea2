using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la cantidad de artículos al usuario
            Console.Write("Ingrese la cantidad de artículos: ");
            int cantidadArticulos = int.Parse(Console.ReadLine());

            // Definir los precios por artículo
            double precioPorArticulo;

            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20.0;
            }
            else
            {
                precioPorArticulo = 15.0;
            }

            // Calcular el precio total
            double precioTotal = cantidadArticulos * precioPorArticulo;

            // Mostrar el precio por artículo y el precio total
            Console.WriteLine($"Precio por artículo: ${precioPorArticulo:F2}");
            Console.WriteLine($"Precio total: ${precioTotal:F2}");
        }
    }
}

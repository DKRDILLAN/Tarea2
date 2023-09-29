using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de cada camisa: ");
            double precioCamisa = double.Parse(Console.ReadLine());

            double precioTotal;

            if (cantidadCamisas == 1)
            {
                // No hay descuento
                precioTotal = cantidadCamisas * precioCamisa;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                // Aplicar descuento del 15%
                double descuento = cantidadCamisas * precioCamisa * 0.15;
                precioTotal = cantidadCamisas * precioCamisa - descuento;
            }
            else
            {
                // Aplicar descuento del 20%
                double descuento = cantidadCamisas * precioCamisa * 0.20;
                precioTotal = cantidadCamisas * precioCamisa - descuento;
            }

            Console.WriteLine($"El precio total de {cantidadCamisas} camisa(s) es: ${precioTotal:F2}");
        }
    }
}
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el carnet del estudiante: ");
            string carnet = Console.ReadLine();

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la nota del Quiz 1: ");
            double quiz1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Quiz 2: ");
            double quiz2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Quiz 3: ");
            double quiz3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 1: ");
            double tarea1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 2: ");
            double tarea2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 3: ");
            double tarea3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 1: ");
            double examen1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 2: ");
            double examen2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 3: ");
            double examen3 = double.Parse(Console.ReadLine());

            // Calcular porcentaje de quices, tareas y exámenes
            double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30;
            double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45;

            // Calcular el promedio final
            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinar la condición del estudiante
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50 && promedioFinal < 70)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar los resultados
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices:P}");
            Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas:P}");
            Console.WriteLine($"Porcentaje de Exámenes: {porcentajeExamenes:P}");
            Console.WriteLine($"Promedio Final: {promedioFinal:F2}");
            Console.WriteLine($"Condición: {condicion}");
        }
    }
}

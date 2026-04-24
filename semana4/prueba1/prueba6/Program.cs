using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pon el promedio del estudiante");
            if (!int.TryParse(Console.ReadLine(), out int nota))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            if (nota <= 5)
            {
                Console.WriteLine($"su nota fue de {nota} tuvo clasificación deficiente");
            }
            else if (nota <= 10)
            {
                Console.WriteLine($"su nota fue de {nota} tuvo clasificacion regular");
            }
            else if (nota <= 14)
            {
                Console.WriteLine($"su nota fue de {nota} tuvo clasificacion bueno");
            }
            else if (nota <= 20)
            {
                Console.WriteLine($"su nota fue de {nota} tuvo clasificacion excelente");
            }
            else
            {
                Console.WriteLine("valor invalido");
            }

        }
    }
}

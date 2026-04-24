using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pueba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese examen parcial");
            int parcial = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese examen final");
            int final = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese practica 1 :");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese practica 2 :");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese practica 3 :");
            int p3 = int.Parse(Console.ReadLine());
            
            int minPractica = Math.Min(p1, Math.Min(p2, p3));
            int prom_practicas = (p1 + p2 + p3 - minPractica) / 2;

            int promedio_final =( parcial +final + prom_practicas) / 3;

            Console.WriteLine($"el promedio de practicas : {prom_practicas}");
            Console.WriteLine($"promedio final: {promedio_final}");

            if (promedio_final >= 18) 
            {
                Console.WriteLine("exelente");
                    }
          else if (promedio_final >= 14) 
            {
                Console.WriteLine("bueno");
                    }
          else if (promedio_final >= 10) 
            {
                Console.WriteLine("regular");
                    }    
            else if (promedio_final < 10)
            {
                Console.WriteLine("deficiente");
            }


        }
    }
}

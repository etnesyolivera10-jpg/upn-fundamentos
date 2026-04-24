using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese la categoria del trabajador (A, B o C)");
            string cat = Console.ReadLine().ToUpper();
            Console.WriteLine("ingrese el numero de horas trabajadas");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de años trabajados");
            int anios = int.Parse(Console.ReadLine());
            double tarifa = 0.0;
           
                if (cat == "A") tarifa = 33.50;
                else if (cat == "B") tarifa = 29.80;
                else if (cat == "C") tarifa = 25.70;
                else
               { 
                 Console.WriteLine("categoria invalida");
                 return;
               }
            double bono = 0;
            if (anios <= 3) bono = 0.00;
            else if (anios >= 4 && anios <= 10) bono = 0.10;
            else if (anios >= 11 && anios <= 17) bono = 0.20;
            else bono = 0.30;

            double sueldoFinal = tarifa * horas * (1 + bono);
            Console.WriteLine($"sueldo: s/. {sueldoFinal:F2}");



        }
    }
}

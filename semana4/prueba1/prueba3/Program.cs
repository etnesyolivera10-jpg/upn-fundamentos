using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el peso kg");
            double peso=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la estatura en metros");
            double estatura=double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(estatura, 2);

            double imcred = Math.Round(imc, 2);

            Console.WriteLine($"IMC: {imcred}");

            if (imc < 18.5) 
            {
                Console.WriteLine("bajo peso");
            }
            else if (imc < 25){
                Console.WriteLine("normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("sobrepeso");
            }
            else
            {
                Console.WriteLine("obesidad");
            }
        }
    }
}

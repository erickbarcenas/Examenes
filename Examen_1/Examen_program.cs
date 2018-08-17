using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Examen_program
    {
        static void Main(string[] args)
        {
            double Numero_1 = 0;
            double Numero_2 = 0;
            double La_suma = 0;
            double La_div = 0;

            Console.WriteLine("Bienvenido, ingresa dos números");
            Numero_1 = Convert.ToDouble(Console.ReadLine());
            Numero_2 = Convert.ToDouble(Console.ReadLine());

            Clase_suma sum_1 = new Clase_suma(Numero_1, Numero_2);
            Clase_Division div_1 = new Clase_Division(Numero_1, Numero_2);

            La_suma = sum_1.Suma_metodo();
            La_div = div_1.Division_metodo();

            Console.WriteLine("La suma es " + La_suma + " y la división es " + La_div);
            Console.WriteLine("Cualquier tecla para salir");
            Console.ReadKey();


        }
    }
}

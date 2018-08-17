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
            Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.ForegroundColor = ConsoleColor.White;

            /*He escogido el dato double debido a su tamaño en longitud (1.7E-308 a 1.7E+308) debido a las pruebas que quise realizar*/
            double Numero_1 = 0;
            double Numero_2 = 0;
            double La_suma = 0;
            double La_div = 0;

            try
            {

                Console.WriteLine("Bienvenido, ingresa dos números");
                Numero_1 = Convert.ToDouble(Console.ReadLine());
                Numero_2 = Convert.ToDouble(Console.ReadLine());

                Clase_suma sum_1 = new Clase_suma(Numero_1, Numero_2);
                Clase_Division div_1 = new Clase_Division(Numero_1, Numero_2);

                La_suma = sum_1.Suma_metodo();
                La_div = Math.Round(div_1.Division_metodo(), 4);

                if (Numero_2 != 0)
                {
                    Console.WriteLine("La suma es " + La_suma + " y la división es " + La_div);
                    Console.WriteLine("Cualquier tecla para salir");
                }
                else
                {
                    Console.WriteLine("La suma es " + La_suma + " y la división 'no está indefinida'");
                    Console.WriteLine("Cualquier tecla para salir");
                    
                }
            }catch(Exception e)
            {
                Console.WriteLine("Ingresaste un caracter \n presiona [Enter] para salir y después vuelve a iniciar el programa");
            }



            Console.ReadKey();


        }
    }
}

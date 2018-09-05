using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class Program


    {
        static void Main(string[] args)
        {
            Double AreaRectangulo;
            Double AreaTriangulo;
            Double AreaCirculo;
            const Double PI = 3.1416;
            int Respuesta;
            Double base_pedida = 0;
            Double altura__pedida = 0;
            Figura dato_base = new Figura();
            Figura dato_altura = new Figura();


            try
            {
                Console.WriteLine("¿Qué área deseas calcular [1]Rectángulo, [2] Triángulo, [3] Círculo?");
                Respuesta = Convert.ToInt16(Console.ReadLine());
                if (Respuesta == 1)
                {
                    base_pedida = dato_base.PideBase();
                    altura__pedida = dato_base.PideAltura();


                }
                else if (Respuesta == 2)
                {
                    base_pedida = dato_base.PideBase();
                    altura__pedida = dato_base.PideAltura();
                }
                else if (Respuesta == 3)
                {
                    Console.WriteLine("Ingresa radio: ");
                    altura__pedida = Convert.ToDouble(Console.ReadLine());
                }
                Figura Base_Rectangulo = new Figura(base_pedida);
                Figura Altura_Rectangulo = new Figura(altura__pedida);
                Figura Radio_Circulo = new Figura(altura__pedida);

                AreaRectangulo = Base_Rectangulo * Altura_Rectangulo;
                AreaTriangulo = Base_Rectangulo * Altura_Rectangulo;
                AreaCirculo = Radio_Circulo * Radio_Circulo;
                if (Respuesta == 1)
                {
                    Console.WriteLine("El área del rectangulo es: " + AreaRectangulo);
                }
                else if (Respuesta == 2)
                {
                    Console.WriteLine("El área del triángulo es: " + AreaTriangulo / 2);
                }
                else if (Respuesta == 3)
                {
                    Console.WriteLine("El área del círculo es: " + AreaCirculo * PI);
                }
                else
                {
                    Console.WriteLine("El área del rectangulo es: " + AreaRectangulo);
                    Console.WriteLine("El área del triángulo es: " + AreaTriangulo / 2);
                    Console.WriteLine("El área del círculo es: " + AreaCirculo * PI);
                }

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Ingresaste un caracter");
            }
            finally
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Examen 3: sobrecarga de operadores \nFin del examen");
                Console.ReadKey();
            }
        }

    }
}




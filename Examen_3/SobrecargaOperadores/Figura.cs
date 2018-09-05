using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class Figura
    {

        
        public Double base_private;
        public double Base_private { get => base_private; set => base_private = value; }
        public Figura(Double base_private)
        {
            Base_private = base_private; //se manga al set
        }
        public static Double operator *(Figura bas_param, Figura area_param)
        {
            return bas_param.Base_private * area_param.Base_private;
        }


        //
        public Figura()
        {
            
        }

        public Double PideBase()
    {
        Double base_1 = 0;
        Console.WriteLine("Ingresa base: ");
        base_1 = Convert.ToDouble(Console.ReadLine());
        return base_1;
    }

        public Double PideAltura()
        {
            Double altura_1 = 0;
            Console.WriteLine("Ingresa altura: ");
            altura_1 = Convert.ToDouble(Console.ReadLine());
            return altura_1;
        }


    }
}
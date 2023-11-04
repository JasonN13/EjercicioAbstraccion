using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Invertebrado : Animal
    {
        public string? tipo;
        public bool tienepatas;
        public int numeropatas;
        public bool tieneconcha;

        public override void imprimir()
        {
            Console.WriteLine("Nombre :" + nombre);
            Console.WriteLine("Color :" + color);

            if (Validar())
            {
                Console.WriteLine("Tipo :" + tipo);
            }
            Console.WriteLine("Tiene paatas :" + tienepatas);
            Console.WriteLine("Es Domestico :" + numeropatas);
            Console.WriteLine("Es Herviboro :" + tieneconcha);
      

        }
        public override bool Validar()
        {
            if (tipo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

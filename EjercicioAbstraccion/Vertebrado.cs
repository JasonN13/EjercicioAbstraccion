using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class Vertebrado : Animal
    {
        public string? tipo;
        public bool tienepatas;
        public bool esdomestico;
        public bool esherviboro;
        public bool escarnivoro;

        public override void imprimir()
        {
            Console.WriteLine("Nombre :" + nombre);
            Console.WriteLine("Color :" + color);

            if (Validar())
            {
                Console.WriteLine("Tipo :" + tipo);
            }
            Console.WriteLine("Tiene paatas :" + tienepatas);
            Console.WriteLine("Es Domestico :" + esdomestico);
            Console.WriteLine("Es Herviboro :" + esherviboro);
            Console.WriteLine("Es Carnivoro :" + escarnivoro);


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


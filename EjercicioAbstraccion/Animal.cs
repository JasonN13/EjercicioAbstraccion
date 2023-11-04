using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal abstract class Animal
    {
        public string? nombre;
        public string? color;
        public string? tamano;
        public string? familia;

    /*Imprimir*/

    public abstract void imprimir();

    /*Validar*/

    public abstract bool Validar();

    }
}

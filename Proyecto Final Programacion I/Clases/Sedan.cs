using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_I.Clases
{
    internal class Sedan : VehiculoBase
    {
        public int NumeroPuertas { get; set; }
        public bool TieneMaletero { get; set; }

        public void AbrirMaletero()
        {
            Console.WriteLine("Abriendo el maletero del sedán.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_I.Clases
{
    internal class SUV: VehiculoBase
    {
        public bool TerceraFilaAsientos { get; set; }
        public bool TraccionIntegral { get; set; }

        public void ActivarModoOffRoad()
        {
            Console.WriteLine("Activando modo off-road en el SUV.");
        }
    }
}

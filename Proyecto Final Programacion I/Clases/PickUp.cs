using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_I.Clases
{
    internal class PickUp: VehiculoBase
    {
        public int CargaMaxima { get; set; }
        public bool TieneCaja { get; set; }

        public void ActivarTraccion4x4()
        {
            Console.WriteLine("Activando tracción 4x4 en la pick-up.");
        }
    }
}

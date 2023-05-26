using Proyecto_Final_Programacion_I.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programacion_I.Clases
{
    internal class VehiculoBase : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; private set; }

        public VehiculoBase()
        {
            VelocidadMaxima = 200;
            VelocidadActual = 0; 
        }

        public void Bocina()
        {
            Console.WriteLine("Sonando la bocina del vehículo.");
        }

        public void Acelerar(int cuanto)
        {
            if (VelocidadActual + cuanto <= VelocidadMaxima)
            {
                VelocidadActual += cuanto;
                Console.WriteLine($"Acelerando el vehículo en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("No se puede acelerar más allá de la velocidad máxima.");
            }
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo el vehículo.");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el vehículo.");
        }

        public void Frenar(int cuanto)
        {
            if (VelocidadActual - cuanto >= 0)
            {
                VelocidadActual -= cuanto;
                Console.WriteLine($"Frenando el vehículo en {cuanto} km/h. Velocidad actual: {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo ya se encuentra detenido.");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Vehículos
{
    internal class BaseVehiculo
    {
        public BaseVehiculo() { }
        public BaseVehiculo(int iD, string marca, string modelo, int año)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
    }
}

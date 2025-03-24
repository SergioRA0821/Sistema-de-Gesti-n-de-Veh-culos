using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Vehículos
{
    internal class VehiculoCamion : BaseVehiculo
    {
        public VehiculoCamion() { }
        public VehiculoCamion(int iD, string marca, string modelo, int año, double capacidadCarga)
            : base(iD, marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public double CapacidadCarga { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Vehículos
{
    internal class VehiculoCoche : BaseVehiculo
    {
        public VehiculoCoche() { }
        public VehiculoCoche(int id, string marca, string modelo, int año, int numPuertas)
        : base(id, marca, modelo, año)
        {
            NumPuertas = numPuertas;
        }

        public int NumPuertas { get; set; }
    }
}

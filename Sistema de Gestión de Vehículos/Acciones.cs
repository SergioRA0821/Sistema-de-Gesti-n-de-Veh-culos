using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Vehículos
{
    internal class Acciones
    {
        Dictionary<int, VehiculoCoche> diccionario = new Dictionary<int, VehiculoCoche> ();
        Dictionary<int, VehiculoCamion> diccionario2 = new Dictionary<int, VehiculoCamion> ();
        VehiculoCoche coche = new VehiculoCoche ();
        VehiculoCamion camion = new VehiculoCamion ();

        public void AddCoche()
        {
            Console.WriteLine("Ingresa ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la marca");
            coche.Marca = Console.ReadLine();
            Console.WriteLine("Ingresa el modelo:");
            coche.Modelo = Console.ReadLine();
            Console.WriteLine("Ingresa el año:");
            coche.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa su capacidad de carga en toneladas:");
            coche.NumPuertas = Convert.ToInt32(Console.ReadLine());
            diccionario.Add(id, new VehiculoCoche(coche.ID, coche.Marca, coche.Modelo, coche.Año, coche.NumPuertas));
        }
        public void AddCamion()
        {
            Console.WriteLine("Ingresa ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la marca:");
            camion.Marca = Console.ReadLine();
            Console.WriteLine("Ingresa el modelo:");
            camion.Modelo = Console.ReadLine();
            Console.WriteLine("Ingresa el año:");
            camion.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa su capacidad de carga en toneladas:");
            camion.CapacidadCarga = Convert.ToDouble(Console.ReadLine());

            diccionario2.Add(id, new VehiculoCamion(camion.ID, camion.Marca, camion.Modelo, camion.Año, camion.CapacidadCarga));
        }
        public void MostrarVehiculos()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Coches:");
            foreach (var a in diccionario)
            {
                Console.WriteLine($"ID: {a.Value.ID}");
                Console.WriteLine($"Marca: {a.Value.Marca}");
                Console.WriteLine($"Modelo: {a.Value.Modelo}");
                Console.WriteLine($"Año: {a.Value.Año}");
                Console.WriteLine($"Número de puertas: {a.Value.NumPuertas}");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Camiones");
            foreach (var p in diccionario2)
            {
                Console.WriteLine($"ID: {p.Value.ID}");
                Console.WriteLine($"Marca: {p.Value.Marca}");
                Console.WriteLine($"Modelo: {p.Value.Modelo}");
                Console.WriteLine($"Año: {p.Value.Año}");
                Console.WriteLine($"Capacidad de carga en toneladas: {p.Value.CapacidadCarga}");
            }
        }
        public void ActualizarCoche()
        {
            Console.WriteLine("Dame ID a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());

            var coches = diccionario.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID");
            coches.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nueva marca");
            coches.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame nuevo modelo");
            coches.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame nuevo año");
            coches.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nuevo número de puertas");
            coches.Value.NumPuertas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El coche se actualizó con éxito");
        }
        public void ActualizarCamion()
        {
            Console.WriteLine("Dame ID a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());

            var camion = diccionario2.FirstOrDefault(x => x.Value.ID == id);

            Console.WriteLine("Dame nuevo ID");
            camion.Value.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nueva marca");
            camion.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame nuevo modelo");
            camion.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame nuevo año");
            camion.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame nueva capacidad de carga");
            camion.Value.CapacidadCarga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El camión se actualizó con éxito");
        }
    }
}

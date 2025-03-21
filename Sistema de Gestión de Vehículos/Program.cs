using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Vehículos
{
    internal class Program
    {
        public enum Menu
        {
            AñadirCoche = 1, AñadirCamion, MostrarVehiculos, ActualizarCoche, ActualizarCamion, EliminarCoche, EliminarCamion, Salir
        }
        static void Main(string[] args)
        {
            while (true)
            {
                switch (menu())
                {
                    case Menu.AñadirCoche:
                        break;
                    case Menu.AñadirCamion:
                        break;
                    case Menu.MostrarVehiculos:
                        break;
                    case Menu.ActualizarCoche:
                        break;
                    case Menu.ActualizarCamion:
                        break;
                    case Menu.EliminarCoche:
                        break;
                    case Menu.EliminarCamion:
                        break;
                    case Menu.Salir:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Intenta con otro número");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("Escoge la opción que deseas");
            Console.WriteLine("1) Agregar coche");
            Console.WriteLine("2) Agregar camión");
            Console.WriteLine("3) Mostrar vehículos");
            Console.WriteLine("5) Actualizar coche");
            Console.WriteLine("6) Actualizar camión");
            Console.WriteLine("7) Eliminar coche");
            Console.WriteLine("8) Eliminar camión");
            Console.WriteLine("9) Salir");
            Menu opc = (Menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}

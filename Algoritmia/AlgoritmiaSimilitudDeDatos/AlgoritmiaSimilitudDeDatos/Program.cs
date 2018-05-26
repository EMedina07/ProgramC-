using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiaSimilitudDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string servicio = "";

            Console.WriteLine("Ingrese el nuevo servicio");
            servicio = Console.ReadLine();

            GestionDeServicios servicesObject = new GestionDeServicios();
            servicesObject.AgregarServicio(servicio);

            Console.ReadKey();
        }
       
    }
}

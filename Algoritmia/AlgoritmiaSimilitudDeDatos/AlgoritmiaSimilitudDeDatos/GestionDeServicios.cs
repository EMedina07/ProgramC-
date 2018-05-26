using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoritmiaSimilitudDeDatos
{
    public class GestionDeServicios
    {
        private List<string> ListadoDeServicios { get; set; }

        public GestionDeServicios()
        {
            ListadoDeServicios = new List<string>()
            {
                "solicitud de prestamo","Solicitud de prestamo", "Solicitud de préstamo",
                "Solicitud de Prestamo", "Solicitud de Préstamo", "Solicitud de préstamo vehículo",
                "Solicitud  de  prestamo  vehiculo", "Solicitud de  préstamo  vehiculo",
                "Solicitud de  prestamo  vehículo", "Solicitud de prestamo","Solicitud prestamo"
            };
        }

        public void AgregarServicio(string servicio)
        {

            VerificarSiElServicioYaEstaEnLaLista(servicio);
            
        }

        private void VerificarSiElServicioYaEstaEnLaLista(string servicio)
        {
            Console.Clear();

            Console.WriteLine("Este servicio no se puede registrar por que ya esta registrado");
            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Coincidencias Encontradas");
            Console.WriteLine("---------------------------\n");

            string otraSolicitud = "solicitud de prestamo vehiculo";

            foreach (var item in ListadoDeServicios)
            {
                if (ListadoDeServicios.Contains(servicio.ToLower()) && (!item.Contains(otraSolicitud.ToLower())))
                {
                    List<string> listItem = new List<string>();
                    listItem.Add(item);

                    Console.WriteLine(item);

                    continue;
                }
                else
                {
                    if (ListadoDeServicios.Contains(servicio.ToLower()) && (item.Contains(otraSolicitud.ToLower())))
                    {
                        List<string> listItem = new List<string>();
                        listItem.Add(item);

                        Console.WriteLine(item);

                        continue;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Registrando Servicio...");
                        Thread.Sleep(5000);
                        Console.Clear();

                        ListadoDeServicios.Add(servicio.ToLower());
                        Console.WriteLine("Servicio registrado sastifatoriamente");

                        break;
                    }
                }
            }
         }
    }
}

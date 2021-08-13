using System;
using System.Collections.Generic;

namespace Taller_POO.Venta
{
    public class ModuloVentas
    {
        public static void ModuloVenta(List<Factura> ListaFactura, List<Taller_POO.Productos.Productos> ListaProducto, List<Taller_POO.Clientes.Clientes> ListaCliente)
        {
            int respuesta = 0;
            Boolean iniciar = true;

            while (iniciar)
            {
                    Console.WriteLine("");
                    Console.WriteLine("-------------------- Bienvenido al Módulo de Ventas. -----------------------");
                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Registrar una venta.");
                    Console.WriteLine("2: Buscar Factura.");
                    Console.WriteLine("3: Deshabilitar Factura.");
                    Console.WriteLine("4: Salir de este módulo.");

                    respuesta = int.Parse(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        VentaServices.AgregarFactura(ListaFactura, ListaProducto, ListaCliente);
                        break;

                    case 2:
                        VentaServices.Buscar(ListaFactura);
                        break;

                    case 3:
                        VentaServices.Deshabilitar(ListaFactura);
                        break;

                    case 4:
                        Console.WriteLine("Gracias por ingresar a este módulo, adiós. :^)");
                        iniciar = false;
                        break;

                    default:
                            Console.WriteLine("");
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("La opción no es válida. Ingrese las que se encuentran en el menú.");
                            Console.WriteLine("-----------------------------------------------------------------");
                        break;
                }


            }
        }
    }
}
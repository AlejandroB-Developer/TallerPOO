using System;
using ModuloP;
using ModuloC;
using System.Collections.Generic;
using Taller_POO.Clientes;
using Taller_POO.Productos;
using Taller_POO.Venta;



namespace taller_POO
{
    class Program
    {   
        
         static void Main(string[] args)
        {
        principal();
        }

        public static  void principal()
        { 
           
            int respuesta = 0;
            Boolean iniciar = true;
            
            var ListaCliente = new List<Clientes>();
            var ListaProducto = new List<Productos>();
            var nombreEmpresa = new List<Empresa>();
            var ListaFactura = new List<Factura>();
            var ListaReportes = ListaCliente;
            var ListaReportesPro = ListaProducto;
            var ListaReportesFactura = ListaFactura;
            int iteracion = 0;

            do 
            { 
            Console.WriteLine("");
            Console.WriteLine("Bienvenido a:");
            if (iteracion == 0)
                    {
                    
                    Console.WriteLine($"------NOMBRE DE LA EMPRESA------");

                    }
                    else if (iteracion != 0)
                    {
                     string Ultimo = "";

                        for (int i = 0; i < nombreEmpresa.Count; i++)
                        {
                              Ultimo = nombreEmpresa[nombreEmpresa.Count - 1].configuracionNombre;
                            
                        }

                        Console.WriteLine(Ultimo);
                    }

                    Console.WriteLine("¿Qué desea hacer?");
                    Console.WriteLine("1: Ingresar al módulo de clientes.");
                    Console.WriteLine("2: Ingresar al módulo de productos.");
                    Console.WriteLine("3: Ingresar al módulo de ventas.");
                    Console.WriteLine("4: Ingresar al módulo de reportes.");
                    Console.WriteLine("5: Configurar el sistema.");
                    Console.WriteLine("6: salir del programa. ");
                    
                    Console.WriteLine("");
                    respuesta = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
            
               switch (respuesta)
                {
                    case 1:
                    ModuloClientes.ModuloCliente(ListaCliente);
                     break;

                    case 2:
                    ModuloProductos.ModuloProducto(ListaProducto); 
                        break;
                    case 3:
                    ModuloVentas.ModuloVenta(ListaFactura, ListaProducto, ListaCliente);
                        break;
                    case 4:
                    Console.WriteLine("-------------------------- Bienvenido al módulo de reportes --------------------");
                    modReportes.moduloReportes(ListaReportesPro, ListaReportes, ListaReportesFactura);
                        break;
                     case 5:
                    iteracion++;
                    funcionConfi.moduloConfiguracion(nombreEmpresa);
                        break;
                    case 6:
                    Console.WriteLine("Gracias por usar este programa, adiós. :^)");
                    iniciar = false;
                        break;

                    default:  
                    Console.WriteLine("");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("La opción no es válida. Ingrese las que se encuentran en el menú.");
                    Console.WriteLine("-----------------------------------------------------------------");
                        break;
                }

            } while (iniciar);
        }
   
}
}
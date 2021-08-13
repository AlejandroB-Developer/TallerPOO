using System;
using System.Collections.Generic;
using System.Linq;
using Taller_POO.Clientes;
using Taller_POO.Productos;

namespace Taller_POO.Venta
{
    public class VentaServices
    {
        static int numeroFactura = 1;
        // --------------------------------- AGREGAR --------------------------
        public static void AgregarFactura(List<Factura> ListaFactura, List<Taller_POO.Productos.Productos> ListaProducto, List<Taller_POO.Clientes.Clientes> ListaCliente)
        {
            DateTime fechaFactura = DateTime.Now;
            string cedula;
            List<DetalleFactura> detalleFacturas = new List<DetalleFactura>();

            Console.WriteLine("");
            Console.WriteLine("------------ REGISTRAR VENTA ----------");
            Console.WriteLine("Por favor, ingrese los siguientes datos: ");

            Console.WriteLine("Cédula del Cliente: ");
            cedula = Console.ReadLine();

            var cliente = ListaCliente.FirstOrDefault(x => x.cedula == cedula);
            if(cliente == null)
            {
                Console.WriteLine("El cliente no existe: ");
                return;
            }

            bool agregarProducto = true;

            while (agregarProducto)
            {
                Console.WriteLine("Ingrese el Código del Producto");
                String codigoProducto = Console.ReadLine();

                var producto = ListaProducto.FirstOrDefault(x => x.codigo == codigoProducto);
                if (producto == null)
                {
                    Console.WriteLine("El producto no existe");
                    continue;
                }

                Console.WriteLine("Ingrese la Cantidad de Unidades");
                int cantidadUnidadesProducto = Convert.ToInt32(Console.ReadLine());

                if(cantidadUnidadesProducto > producto.cantidad)
                {
                    Console.WriteLine("No hay unidades disponibles");
                    continue;
                }

                Console.WriteLine("Desea Ingresar otro Producto (Si/No)");
                String respuesta = Console.ReadLine();

                if (respuesta == "No" || respuesta == "NO" || respuesta == "no" || respuesta == "nO" )
                {
                    agregarProducto = false;
                }


                DetalleFactura detalle = new DetalleFactura(codigoProducto, cantidadUnidadesProducto, producto.precio);
                detalleFacturas.Add(detalle);
            }

            var factura = new Factura(numeroFactura, fechaFactura, cedula, detalleFacturas);
            ListaFactura.Add(factura);
            numeroFactura++;
            Console.WriteLine("¡Venta realizada con éxito! (^u^)//");

        }

        // --------------------------------- BUSCAR --------------------------
        public static void Buscar(List<Factura> ListaFactura)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------- BUSCAR FACTURA ------------");
            Console.WriteLine("Por favor, digite el número de la factura para continuar. ");
            int numeroFactura = Convert.ToInt32(Console.ReadLine());

            var factura = ListaFactura.Where(c => c.numeroFactura == numeroFactura).FirstOrDefault();
            Console.WriteLine("");
            Console.WriteLine("Consulta realizada con éxito. Estos son los datos encontrados: ");
            Console.WriteLine("Número de Factura: " + numeroFactura);
            Console.WriteLine("Fecha de Realización: " + factura.fechaFactura);
            Console.WriteLine("Documento del Cliente: " + factura.cedula);
            Console.WriteLine("Valor Total: " + factura.valorTotal);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("¡Factura consultada con éxito! (^u^)// ");
        }


        // --------------------------------- DESHABILITAR --------------------------

        public static void Deshabilitar(List<Factura> ListaFactura)
        {
            String factura;

            Console.WriteLine("");
            Console.WriteLine("-------------- DESHABILITAR FACTURA ------------");
            Console.WriteLine("Por favor, digite el número de la factura para continuar. ");

            factura = Console.ReadLine();

            var estado = ListaFactura.Where(c => c.numeroFactura == numeroFactura).FirstOrDefault();

            estado.activo = false;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Factura Deshabilitada exitosamente (^u^)//");
        }
    }
}
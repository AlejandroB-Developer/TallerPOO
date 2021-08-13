using System;
using System.Collections.Generic;
using Taller_POO.Clientes;
using Taller_POO.Productos;
using Taller_POO.Venta;

public class ReportesServices
{
    public void ModuloReportes(List<Clientes> ListaReportes)
    {
        Console.WriteLine("Clientes registrados:");
        for (int i = 0; i < ListaReportes.Count; i++)

        {
            Console.WriteLine($"{ListaReportes[i].cedula}, {ListaReportes[i].nombre}, {ListaReportes[i].direccion}, {ListaReportes[i].telefono} ");
        
        }

    }
    public void ModuloReportesProducto(List<Productos> ListaReportesPro)
    {

        Console.WriteLine("Productos registrados:");
        for (int i = 0; i < ListaReportesPro.Count; i++)
        {
            Console.WriteLine($"{ListaReportesPro[i].codigo}, {ListaReportesPro[i].precio}, {ListaReportesPro[i].cantidad} ");
            Console.WriteLine("-----------------------");
        }

    }

    public void ModuloReportesFactura(List<Factura> ListaReportesFactura)
    {

        Console.WriteLine("Facturas registradas:");
        for (int i = 0; i < ListaReportesFactura.Count; i++)
        {
            Console.WriteLine($"{ListaReportesFactura[i].numeroFactura}, {ListaReportesFactura[i].fechaFactura}, {ListaReportesFactura[i].cedula}, {ListaReportesFactura[i].detalleFacturas}, {ListaReportesFactura[i].valorTotal} ");
            Console.WriteLine("-------------------------");
        }

    }
}
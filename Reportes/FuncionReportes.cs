using System.Collections.Generic;
using Taller_POO.Clientes;
using Taller_POO.Productos;
using Taller_POO.Venta;

public class modReportes
{
    
       public static void moduloReportes(List<Productos> listaReportesPro, List<Clientes> listaReportes, List<Factura> listaReportesFactura)
        {
            var ReportesServices = new ReportesServices();

            ReportesServices.ModuloReportes(listaReportes);
            ReportesServices.ModuloReportesProducto(listaReportesPro);
            ReportesServices.ModuloReportesFactura(listaReportesFactura);

        }


    
}
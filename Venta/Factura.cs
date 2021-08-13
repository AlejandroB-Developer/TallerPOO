using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Venta
{
    public class Factura
    {
        public int numeroFactura;
        public DateTime fechaFactura;
        public string cedula;
        public double valorTotal;
        public List<DetalleFactura> detalleFacturas;
        public bool activo = true;


        public Factura(int numeroFactura, DateTime fechaFactura, string cedula, List<DetalleFactura> detalleFacturas)
        {
            this.numeroFactura = numeroFactura;
            this.fechaFactura = fechaFactura;
            this.cedula = cedula;
            this.detalleFacturas = detalleFacturas;
            this.valorTotal = detalleFacturas.Sum(detalle => detalle.cantidad * detalle.valor);
        }
    }
}

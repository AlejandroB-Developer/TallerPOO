using System;
namespace Taller_POO.Venta
{
    public class DetalleFactura
    {
        public string producto;
        public int cantidad;
        public double valor;

        public DetalleFactura(string producto, int cantidad, double valor)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.valor = valor;
        }
    }
}

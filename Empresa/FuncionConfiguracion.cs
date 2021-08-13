using System.Collections.Generic;
using Taller_POO.Clientes;
using Taller_POO.Productos;

public class funcionConfi
{
    
     public static void moduloConfiguracion(List<Empresa> nombreEmpresa)
        {
        var EmpresaServices = new  EmpresaServices();
        EmpresaServices.AgregarNombre(nombreEmpresa);
        }


    
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_POO.Clientes

{
    public class ClienteService
    {

    // --------------------------------- AGREGAR --------------------------
        public static void Agregar(List<Clientes> ListaClientes)
        {
            String cedula;
            String nombre;
            String direccion;
            String telefono;
            
            Console.WriteLine("");
            Console.WriteLine("------------ AGREGAR CLIENTE ----------");
            Console.WriteLine("Por favor, ingrese los siguientes datos: ");

            Console.WriteLine("Cédula: ");
            cedula = Console.ReadLine();
            Console.WriteLine("");

            var verificarCedula = ListaClientes.Any(c => c.cedula == cedula);
            if(verificarCedula){
                        Console.WriteLine("La cédula ya existe en el sistema, por favor inténtelo de nuevo. o(╥-╥)o");
                } 
                else {
                    Console.WriteLine("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Dirección: ");
                    direccion = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Teléfono: ");
                    telefono = Console.ReadLine();
                    Console.WriteLine("");
                    

                    var clientes = new Clientes(cedula, nombre, direccion, telefono);
                    ListaClientes.Add(clientes);
                    Console.WriteLine("¡Cliente agregado con éxito! (^u^)//");
                }
                
            }

// --------------------------------- BUSCAR --------------------------
        public static void Buscar(List<Clientes> ListaClientes)
        {
            String cedula;
            Console.WriteLine("");
            Console.WriteLine("----------------- BUSCAR CLIENTE ---------------");
            Console.WriteLine("Por favor, digite la cédula del cliente para continuar. ");
            cedula = Console.ReadLine();

            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("");

            var verificarCedula = ListaClientes.Any(c => c.cedula == cedula);
            if (!verificarCedula)
             {
                 Console.WriteLine("Consulta fallida. La cédula no se encuentra registrada en el sistema. o(╥-╥)o");  
             } 
            else {
            Console.WriteLine("Consulta realizada. Estos son los datos encontrados: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("¡Cliente consultado con éxito!  (^u^)// ");
            }
        }

// --------------------------------- EDITAR --------------------------

        public static void Editar(List<Clientes> ListaClientes)
        {
            String cedula;
            String nombre;
            String direccion;
            String telefono;

            Console.WriteLine("");
            Console.WriteLine("------------------------ EDITAR CLIENTE ----------------------");
            Console.WriteLine("Por favor, ingrese la cédula del cliente para continuar. ");
            cedula = Console.ReadLine();

             var verificarCedula = ListaClientes.Any(c => c.cedula == cedula);
             if(!verificarCedula){
                        Console.WriteLine("Edición fallida. La cédula no se encuentra registrada en el sistema. o(╥-╥)o");
                } 
                else {

            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("");
            Console.WriteLine("Datos del cliente que se editarán: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Por favor ingrese los siguientes datos para continuar:");
            Console.WriteLine("Nuevo nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Nueva dirección del cliente: ");
            direccion = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Nuevo teléfono del cliente:");
            telefono = Console.ReadLine();
            Console.WriteLine("");

            clientes.nombre = nombre;
            clientes.direccion = direccion;
            clientes.telefono = telefono;
            
            Console.WriteLine("Cliente editado con éxito. Estos son los nuevos datos  (^u^)//: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
            }
        }

// --------------------------------- ELIMINAR --------------------------

        public static void Eliminar(List<Clientes> ListaClientes)
        {
            String cedula;

            Console.WriteLine("");
            Console.WriteLine("----------------------- ELIMINAR CLIENTE ---------------------");

            Console.WriteLine("Por favor, digite la cédula del cliente para continuar");
            cedula = Console.ReadLine();
            Console.WriteLine("");

             var verificarCedula = ListaClientes.Any(c => c.cedula == cedula);
             if(!verificarCedula){
                        Console.WriteLine("Eliminación fallida. La cédula no se encuentra registrada en el sistema. o(╥﹏╥)o");
                } 
                else {
            var clientes = ListaClientes.Where(c => c.cedula == cedula).FirstOrDefault();
            Console.WriteLine("Datos que se borraron: ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cédula: "+clientes.cedula);
            Console.WriteLine("Nombre: "+clientes.nombre);
            Console.WriteLine("Dirección: "+clientes.direccion);
            Console.WriteLine("Teléfono: "+clientes.telefono);
            ListaClientes.Remove(clientes);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Cliente borrado exitosamente  (^u^)// ");
            }
        }
    }
}
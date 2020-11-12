using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace webservicejghz
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Alumno ObtenerAlumno(int Semestre)
        {
            switch (Semestre)
            { 
            
                case 1:
                    return new Alumno() { Nombre = "Rodrigo", Carrera = "Administración", Num_Control = "17030087" };
                    

                case 2:
                    return new Alumno() { Nombre = "Iván", Carrera = "Industrial", Num_Control = "17030045" };
                  

                case 3: 
                    return new Alumno() { Nombre = "Mario", Carrera = "Informática", Num_Control = "17040071" };

                case 4:
                    return new Alumno() { Nombre = "Juan", Carrera = "Administración", Num_Control = "17030023" };


                case 5:
                    return new Alumno() { Nombre = "Manuél", Carrera = "Alimentarias", Num_Control = "17030056" };


                case 6:
                    return new Alumno() { Nombre = "María", Carrera = "Administración", Num_Control = "17040045" };


                default: 
                    return new Alumno() { error = "Alumno no encontrado" };
                    
            }

        }

        public Cliente ObtenerCliente(string Identificador)
        {
            if (Identificador == "1")
            {
                return new Cliente() { Nombre = "Juan", Apellido_Paterno = "Rodriguez", Apellido_Materno = "Perez" };
            }
            else if (Identificador == "2")
            {
                return new Cliente() { Nombre = "joan Carlo", Apellido_Paterno = "Marquéz", Apellido_Materno = "Ponce" };
            }
            else if (Identificador == "3")
            {
                return new Cliente() { Nombre = "Saul", Apellido_Paterno = "Vargas", Apellido_Materno = "Vazquez" };
            }
            else
            {
                return new Cliente() { Error = "Cliente no encontrado" };
            }
            
        }

        public Producto ObtenerProducto(int Codigo)
        {
            if (Codigo == 2020)
            {
                return new Producto() { Nombre = "Marlboro", Clasificación = "Cigarrillos", inventario = "5" };
            }
             if (Codigo == 1798)
            {
                return new Producto() { Nombre = "Pica Fresas", Clasificación = "Dulce", inventario = "10" };
            }
            if (Codigo == 3287)
            {
                return new Producto() { Nombre = "Sabritas", Clasificación = "Papas", inventario = "30" };
            }
            else
            {
                return new Producto() { Fallo = "Producto no encontrado" };
            }
        }
    }

}

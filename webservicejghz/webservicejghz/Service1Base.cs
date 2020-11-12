namespace webservicejghz
{
    public class Service1Base
    {

        public Cliente ObtenerCliente(string ID)
        {
            if (ID == "1")
            {
                return new Cliente() { Nombre = "Juan", Apellido_Paterno = "Rodriguez", Apellido_Materno = "Perez" };
            }
            else if (ID == "2")
            {
                return new Cliente() { Nombre = "joan Carlo", Apellido_Paterno = "Marquéz", Apellido_Materno = "Ponce" };
            }
            else if (ID == "3")
            {
                return new Cliente() { Nombre = "Saul", Apellido_Paterno = "Vargas", Apellido_Materno = "Vazquez" };
            }
            else
            {
                return new Cliente() { Error = "Cliente no encontrado" };
            }
        }
        public Alumno ObtenerAlumno(string Semestre)
        {
            if (Semestre == "1")
            {


                return new Alumno() { Nombre = "Rodrigo", Carrera = "Administración", Num_Control = "17030087" };
            }
            else if (Semestre == "2")
            {

                return new Alumno() { Nombre = "Iván", Carrera = "Industrial", Num_Control = "17030045" };
            }
            else if (Semestre == "3")
            {

                return new Alumno() { Nombre = "Mario", Carrera = "Informática", Num_Control = "17040071" };
            }
            else
            {


                return new Alumno() { error = "Cliente no encontrado" };
            }

        }
    }
}
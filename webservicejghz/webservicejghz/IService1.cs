using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace webservicejghz
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Cliente ObtenerCliente(string Identificador);

        [OperationContract]
        Alumno ObtenerAlumno(int Semestre);
        [OperationContract]
        Producto ObtenerProducto(int Codigo);

        // TODO: agregue aquí sus operaciones de servicio
    } 
    [DataContract]
    public class Producto:  REST
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Clasificación { get; set; }
        [DataMember]
        public string inventario { get; set; }
    }


    [DataContract]
    public class Cliente: Respuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido_Paterno { get; set; }
        [DataMember]
        public string Apellido_Materno { get; set; }
    }

    [DataContract]
    public class Alumno: Res
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Carrera { get; set; }
        [DataMember]
        public string Num_Control { get; set; }

    }

    [DataContract]
    public class Respuesta
    {
        public string Error { get; set; }
    }
    [DataContract]
    public class Res
    {
        public string error { get; set; }
    }
    [DataContract]
    public class REST
    {
        public string Fallo { get; set; }
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

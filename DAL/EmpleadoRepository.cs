using Entity.Enums;
using System.IO;

using Entity;
using Entity.Enums;

namespace DAL
{
    public class EmpleadoRepository
    {
        private StreamWriter streamWriter;
        private StreamReader streamReader;

        public EmpleadoRepository()
        {

        }

        public bool GuardarEmpleado(Empleado empleado)
        {
            if (ExisteEmpleado(empleado.Identificacion)) 
            {
                return false; 
            }
            streamWriter = new StreamWriter("./Empleados.txt", true);
            streamWriter.WriteLine(empleado);
            streamWriter.Close();
            return true;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return this.LeerArchivoEmpleados();
        }

        private bool ExisteEmpleado(string identificacion)
        {
            List<Empleado> empleados = this.ObtenerEmpleados();

            foreach(Empleado empleado in empleados)
            {
                if(empleado.Identificacion.Equals(identificacion))
                {
                    return true;
                }
            }
            return false;
        }

        private List<Empleado> LeerArchivoEmpleados()
        {
            if (!File.Exists("./Empleados.txt")) { return new List<Empleado>(); }
            streamReader = new StreamReader("./Empleados.txt");
            List<Empleado> empleados = new List<Empleado>();
            string registro;
            string[] campos;

            do
            {
                registro = streamReader.ReadLine();
                if (registro is null) 
                {
                    streamReader.Close();
                    return new List<Empleado>(); 
                }
                campos = registro.Split(";");
                Estado activo;
                Estado inactivo;

                Empleado empleado = new Empleado(campos[0], campos[1], Decimal.Parse(campos[2]), campos[3]);

                empleados.Add(empleado);

            } while (!streamReader.EndOfStream);

            streamReader.Close();

            return empleados;

        }
    }
}
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

        public void GuardarEmpleado(Empleado empleado)
        {
            streamWriter = new StreamWriter("./Empleados.txt", true);
            streamWriter.WriteLine(empleado);
            streamWriter.Close();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return this.LeerArchivoEmpleados();
        }

        private List<Empleado> LeerArchivoEmpleados()
        {
            streamReader = new StreamReader("./Empleados.txt");
            List<Empleado> empleados = new List<Empleado>();
            string registro;
            string[] campos;

            do
            {
                registro = streamReader.ReadLine();
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
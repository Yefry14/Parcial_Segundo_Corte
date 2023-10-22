using Entity;
using Entity.Enums;
using DAL;


namespace BLL
{
    public class EmpleadoService
    {
        private EmpleadoRepository empleadoRepository;

        public EmpleadoService()
        {
            empleadoRepository = new EmpleadoRepository();
        }

        public bool GuardarEmpleado(Empleado empleado)
        {
            if(empleadoRepository.GuardarEmpleado(empleado))
            {
                return true;
            }

            return false;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleadoRepository.ObtenerEmpleados();
        }
    }
}
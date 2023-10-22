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

        public void GuardarEmpleado(Empleado empleado)
        {
            empleadoRepository.GuardarEmpleado(empleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleadoRepository.ObtenerEmpleados();
        }
    }
}
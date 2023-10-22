using Entity.Enums;

namespace Entity
{
    public class Empleado
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }
        public string Estado { get; set; }

        public Empleado(string identificacion, string nombre, decimal salarioBase, string estado)
        {
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.SalarioBase = salarioBase;
            this.Estado = estado;
        }

        public override string ToString()
        {
            return Identificacion + ";" + Nombre + ";" + SalarioBase + ";" + Estado;
        }

    }
}
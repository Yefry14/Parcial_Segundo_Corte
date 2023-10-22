using Entity;
using Entity.Enums;
using BLL;

namespace GUI
{
    public partial class EmpleadoForm : Form
    {
        private EmpleadoService empleadoService;
        private List<Empleado> empleados;
        public EmpleadoForm()
        {
            InitializeComponent();
            empleadoService = new EmpleadoService();
            empleados = empleadoService.ObtenerEmpleados();
            this.dataGridView1.DataSource = empleados;
            cmb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_filtroEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_estado.Items.Insert(0, "Seleccionar");
            cmb_filtroEstado.Items.Insert(0, "Seleccionar");

            cmb_estado.SelectedIndex = 0;
            cmb_filtroEstado.SelectedIndex = 0;
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (HayCamposVacios()) { return; }
            if (ElNombreNoEsValido()) { return; }

            Empleado empleado = new Empleado(this.inpt_identificacion.Text, this.inpt_nombre.Text, Decimal.Parse(this.inpt_salarioBase.Text), this.cmb_estado.Text);

            empleadoService.GuardarEmpleado(empleado);
            this.empleados = empleadoService.ObtenerEmpleados();
            dataGridView1.DataSource = this.empleados;
        }

        private bool HayCamposVacios()
        {
            string campo = string.Empty;
            if (this.inpt_identificacion.Text.Equals(string.Empty))
            {
                campo += "Identificación, ";
            }
            if (this.inpt_nombre.Text.Equals(string.Empty))
            {
                campo += "Nombre, ";
            }
            if (this.inpt_salarioBase.Text.Equals(string.Empty))
            {
                campo += "Salario Base, ";
            }
            if (this.cmb_estado.Text.Equals(string.Empty) || this.cmb_estado.Text.Equals("Seleccionar"))
            {
                campo += "Estado, ";
            }

            if (!campo.Equals(string.Empty))
            {
                MessageBox.Show("Los campos " + campo + " no pueden estar vacíos.");
                return true;
            }

            return false;
        }

        private bool ElNombreNoEsValido()
        {
            if (!inpt_nombre.Text.All(char.IsLetter))
            {
                return true;
            }

            return false;
        }

        private void Filtrar()
        {
            List<Empleado> empleadosNombre = new List<Empleado>();
            List<Empleado> empleadosEstado = new List<Empleado>();

            if (!inpt_filtroNombre.Text.Equals(string.Empty))
            {
                foreach (Empleado empleado in this.empleados)
                {
                    if (empleado.Nombre.IndexOf(inpt_filtroNombre.Text) != -1)
                    {
                        empleadosNombre.Add(empleado);

                    }
                }
                this.empleados = empleadosNombre;
            }

            if (!(cmb_filtroEstado.Text.Equals(string.Empty) || cmb_filtroEstado.Text.Equals("Seleccionar")))
            {
                foreach (Empleado empleado in this.empleados)
                {
                    if (empleado.Estado.IndexOf(cmb_filtroEstado.Text) != -1)
                    {
                        empleadosEstado.Add(empleado);

                    }
                }
                this.empleados = empleadosEstado;
            }

            if(cmb_filtroEstado.Text.Equals(string.Empty) && inpt_filtroNombre.Equals(string.Empty))
            {
                this.empleados = empleadoService.ObtenerEmpleados();
                this.dataGridView1.DataSource = this.empleados;
                return;
            }

            this.dataGridView1.DataSource = this.empleados;
            this.empleados = empleadoService.ObtenerEmpleados();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
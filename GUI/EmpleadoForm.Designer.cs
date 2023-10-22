namespace GUI
{
    partial class EmpleadoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.inpt_salarioBase = new System.Windows.Forms.TextBox();
            this.inpt_identificacion = new System.Windows.Forms.TextBox();
            this.inpt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_liquidaciones = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_filtroEstado = new System.Windows.Forms.ComboBox();
            this.inpt_filtroNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.cmb_estado);
            this.panel1.Controls.Add(this.inpt_salarioBase);
            this.panel1.Controls.Add(this.inpt_identificacion);
            this.panel1.Controls.Add(this.inpt_nombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 120);
            this.panel1.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(351, 82);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_estado.Location = new System.Drawing.Point(576, 39);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(179, 23);
            this.cmb_estado.TabIndex = 13;
            // 
            // inpt_salarioBase
            // 
            this.inpt_salarioBase.Location = new System.Drawing.Point(391, 39);
            this.inpt_salarioBase.Name = "inpt_salarioBase";
            this.inpt_salarioBase.Size = new System.Drawing.Size(179, 23);
            this.inpt_salarioBase.TabIndex = 12;
            // 
            // inpt_identificacion
            // 
            this.inpt_identificacion.Location = new System.Drawing.Point(206, 39);
            this.inpt_identificacion.Name = "inpt_identificacion";
            this.inpt_identificacion.Size = new System.Drawing.Size(179, 23);
            this.inpt_identificacion.TabIndex = 11;
            // 
            // inpt_nombre
            // 
            this.inpt_nombre.Location = new System.Drawing.Point(21, 39);
            this.inpt_nombre.Name = "inpt_nombre";
            this.inpt_nombre.Size = new System.Drawing.Size(179, 23);
            this.inpt_nombre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(576, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(391, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 65);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de empleados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.btn_liquidaciones);
            this.panel3.Controls.Add(this.btn_filtrar);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.cmb_filtroEstado);
            this.panel3.Controls.Add(this.inpt_filtroNombre);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 337);
            this.panel3.TabIndex = 3;
            // 
            // btn_liquidaciones
            // 
            this.btn_liquidaciones.Location = new System.Drawing.Point(565, 114);
            this.btn_liquidaciones.Name = "btn_liquidaciones";
            this.btn_liquidaciones.Size = new System.Drawing.Size(138, 125);
            this.btn_liquidaciones.TabIndex = 14;
            this.btn_liquidaciones.Text = "Liquidaciones";
            this.btn_liquidaciones.UseVisualStyleBackColor = true;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(422, 46);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(46, 24);
            this.btn_filtrar.TabIndex = 14;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(422, 219);
            this.dataGridView1.TabIndex = 14;
            // 
            // cmb_filtroEstado
            // 
            this.cmb_filtroEstado.FormattingEnabled = true;
            this.cmb_filtroEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_filtroEstado.Location = new System.Drawing.Point(237, 47);
            this.cmb_filtroEstado.Name = "cmb_filtroEstado";
            this.cmb_filtroEstado.Size = new System.Drawing.Size(179, 23);
            this.cmb_filtroEstado.TabIndex = 13;
            // 
            // inpt_filtroNombre
            // 
            this.inpt_filtroNombre.Location = new System.Drawing.Point(52, 47);
            this.inpt_filtroNombre.Name = "inpt_filtroNombre";
            this.inpt_filtroNombre.Size = new System.Drawing.Size(179, 23);
            this.inpt_filtroNombre.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(237, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nombre";
            // 
            // EmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmpleadoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EmpleadoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_guardar;
        private ComboBox cmb_estado;
        private TextBox inpt_salarioBase;
        private TextBox inpt_identificacion;
        private TextBox inpt_nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private ComboBox cmb_filtroEstado;
        private TextBox inpt_filtroNombre;
        private Label label6;
        private Label label9;
        private Button btn_filtrar;
        private DataGridView dataGridView1;
        private Button btn_liquidaciones;
    }
}
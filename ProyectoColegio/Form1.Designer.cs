namespace ProyectoColegio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtHoraEntrega = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOcupacion = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEquiposFaltantes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(429, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 36);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtHoraEntrega);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEquipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxOcupacion);
            this.groupBox1.Controls.Add(this.comboBoxCurso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 466);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Préstamo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(309, 190);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PlaceholderText = "N° Equipo";
            this.txtNumero.Size = new System.Drawing.Size(80, 23);
            this.txtNumero.TabIndex = 13;
            // 
            // txtHoraEntrega
            // 
            this.txtHoraEntrega.Location = new System.Drawing.Point(6, 256);
            this.txtHoraEntrega.Name = "txtHoraEntrega";
            this.txtHoraEntrega.PlaceholderText = "00:00";
            this.txtHoraEntrega.Size = new System.Drawing.Size(121, 23);
            this.txtHoraEntrega.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hora de Entrega";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(6, 318);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PlaceholderText = "Complementos";
            this.txtObservacion.Size = new System.Drawing.Size(312, 59);
            this.txtObservacion.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Observación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Número";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(6, 190);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.PlaceholderText = "Tipo de equipo";
            this.txtEquipo.Size = new System.Drawing.Size(285, 23);
            this.txtEquipo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Equipo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre del responsable";
            this.txtNombre.Size = new System.Drawing.Size(306, 23);
            this.txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ocupación";
            // 
            // comboBoxOcupacion
            // 
            this.comboBoxOcupacion.FormattingEnabled = true;
            this.comboBoxOcupacion.Items.AddRange(new object[] {
            "Profesor",
            "Alumno"});
            this.comboBoxOcupacion.Location = new System.Drawing.Point(191, 54);
            this.comboBoxOcupacion.Name = "comboBoxOcupacion";
            this.comboBoxOcupacion.Size = new System.Drawing.Size(185, 23);
            this.comboBoxOcupacion.TabIndex = 7;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Items.AddRange(new object[] {
            "7A",
            "7B",
            "7C",
            "8A",
            "8B",
            "8C",
            "1A",
            "1B",
            "1C",
            "2A",
            "2B",
            "2C",
            "3A",
            "3B",
            "3C",
            "4A",
            "4B",
            "4C"});
            this.comboBoxCurso.Location = new System.Drawing.Point(6, 54);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCurso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Curso";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.Location = new System.Drawing.Point(6, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 32);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.AllowUserToAddRows = false;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Ocupacion,
            this.Nombre,
            this.Equipo,
            this.Numero,
            this.HoraEntrega,
            this.HoraDevolucion,
            this.Observación});
            this.dataGridViewPrestamos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(429, 21);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.RowTemplate.Height = 25;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(842, 415);
            this.dataGridViewPrestamos.TabIndex = 4;
            this.dataGridViewPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellClick);
            this.dataGridViewPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellClick);
            this.dataGridViewPrestamos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrestamos_CellContentDoubleClick);
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Ocupacion
            // 
            this.Ocupacion.HeaderText = "Ocupación";
            this.Ocupacion.Name = "Ocupacion";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            // 
            // HoraEntrega
            // 
            this.HoraEntrega.HeaderText = "Hora de Entrega";
            this.HoraEntrega.Name = "HoraEntrega";
            // 
            // HoraDevolucion
            // 
            this.HoraDevolucion.HeaderText = "Hora de Devolución";
            this.HoraDevolucion.Name = "HoraDevolucion";
            // 
            // Observación
            // 
            this.Observación.HeaderText = "Observación";
            this.Observación.Name = "Observación";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(1177, 442);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 36);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(524, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exportar a Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEquiposFaltantes
            // 
            this.txtEquiposFaltantes.AutoSize = true;
            this.txtEquiposFaltantes.Location = new System.Drawing.Point(760, 453);
            this.txtEquiposFaltantes.Name = "txtEquiposFaltantes";
            this.txtEquiposFaltantes.Size = new System.Drawing.Size(0, 15);
            this.txtEquiposFaltantes.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(630, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Equipos Faltantes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 490);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEquiposFaltantes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "      ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEliminar;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private DataGridView dataGridViewPrestamos;
        private Button btnCerrar;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxOcupacion;
        private ComboBox comboBoxCurso;
        private Label label1;
        private TextBox txtObservacion;
        private Label label6;
        private Label label5;
        private TextBox txtEquipo;
        private Label label4;
        private TextBox txtHoraEntrega;
        private Label label7;
        private Button button1;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Ocupacion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn HoraEntrega;
        private DataGridViewTextBoxColumn HoraDevolucion;
        private DataGridViewTextBoxColumn Observación;
        private Label txtEquiposFaltantes;
        private Button button2;
        private TextBox txtNumero;
    }
}
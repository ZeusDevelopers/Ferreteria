namespace PVFP
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbBuscarNombre = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbpuestoE = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContraE = new System.Windows.Forms.TextBox();
            this.txtusuE = new System.Windows.Forms.TextBox();
            this.cmbsexoE = new System.Windows.Forms.ComboBox();
            this.txttelefonoE = new System.Windows.Forms.TextBox();
            this.txtdireE = new System.Windows.Forms.TextBox();
            this.txtapelE = new System.Windows.Forms.TextBox();
            this.txtnombreE = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbpuesto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cmbBuscarNombre);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbpuestoE);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtContraE);
            this.groupBox4.Controls.Add(this.txtusuE);
            this.groupBox4.Controls.Add(this.cmbsexoE);
            this.groupBox4.Controls.Add(this.txttelefonoE);
            this.groupBox4.Controls.Add(this.txtdireE);
            this.groupBox4.Controls.Add(this.txtapelE);
            this.groupBox4.Controls.Add(this.txtnombreE);
            this.groupBox4.Location = new System.Drawing.Point(14, 411);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(628, 364);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Editar/Eliminar";
            this.groupBox4.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 37);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 22);
            this.label17.TabIndex = 39;
            this.label17.Text = "Nombre:";
            // 
            // cmbBuscarNombre
            // 
            this.cmbBuscarNombre.FormattingEnabled = true;
            this.cmbBuscarNombre.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbBuscarNombre.Location = new System.Drawing.Point(222, 32);
            this.cmbBuscarNombre.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBuscarNombre.Name = "cmbBuscarNombre";
            this.cmbBuscarNombre.Size = new System.Drawing.Size(234, 30);
            this.cmbBuscarNombre.TabIndex = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(460, 259);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 86);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(303, 259);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 86);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 35;
            this.label9.Text = "Puesto:";
            // 
            // cmbpuestoE
            // 
            this.cmbpuestoE.FormattingEnabled = true;
            this.cmbpuestoE.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbpuestoE.Location = new System.Drawing.Point(415, 179);
            this.cmbpuestoE.Margin = new System.Windows.Forms.Padding(5);
            this.cmbpuestoE.Name = "cmbpuestoE";
            this.cmbpuestoE.Size = new System.Drawing.Size(164, 30);
            this.cmbpuestoE.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "Contraseña:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Usuario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 272);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Telefono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 22);
            this.label13.TabIndex = 30;
            this.label13.Text = "Direccion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 186);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 29;
            this.label14.Text = "Sexo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 28;
            this.label15.Text = "Apellido:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 22);
            this.label16.TabIndex = 27;
            this.label16.Text = "Nombre:";
            // 
            // txtContraE
            // 
            this.txtContraE.Location = new System.Drawing.Point(415, 135);
            this.txtContraE.Margin = new System.Windows.Forms.Padding(5);
            this.txtContraE.Name = "txtContraE";
            this.txtContraE.Size = new System.Drawing.Size(164, 29);
            this.txtContraE.TabIndex = 26;
            // 
            // txtusuE
            // 
            this.txtusuE.Location = new System.Drawing.Point(415, 91);
            this.txtusuE.Margin = new System.Windows.Forms.Padding(5);
            this.txtusuE.Name = "txtusuE";
            this.txtusuE.Size = new System.Drawing.Size(164, 29);
            this.txtusuE.TabIndex = 25;
            // 
            // cmbsexoE
            // 
            this.cmbsexoE.FormattingEnabled = true;
            this.cmbsexoE.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbsexoE.Location = new System.Drawing.Point(100, 181);
            this.cmbsexoE.Margin = new System.Windows.Forms.Padding(5);
            this.cmbsexoE.Name = "cmbsexoE";
            this.cmbsexoE.Size = new System.Drawing.Size(164, 30);
            this.cmbsexoE.TabIndex = 24;
            // 
            // txttelefonoE
            // 
            this.txttelefonoE.Location = new System.Drawing.Point(100, 267);
            this.txttelefonoE.Margin = new System.Windows.Forms.Padding(5);
            this.txttelefonoE.Name = "txttelefonoE";
            this.txttelefonoE.Size = new System.Drawing.Size(164, 29);
            this.txttelefonoE.TabIndex = 23;
            // 
            // txtdireE
            // 
            this.txtdireE.Location = new System.Drawing.Point(100, 223);
            this.txtdireE.Margin = new System.Windows.Forms.Padding(5);
            this.txtdireE.Name = "txtdireE";
            this.txtdireE.Size = new System.Drawing.Size(164, 29);
            this.txtdireE.TabIndex = 22;
            // 
            // txtapelE
            // 
            this.txtapelE.Location = new System.Drawing.Point(100, 137);
            this.txtapelE.Margin = new System.Windows.Forms.Padding(5);
            this.txtapelE.Name = "txtapelE";
            this.txtapelE.Size = new System.Drawing.Size(164, 29);
            this.txtapelE.TabIndex = 21;
            // 
            // txtnombreE
            // 
            this.txtnombreE.Location = new System.Drawing.Point(100, 93);
            this.txtnombreE.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombreE.Name = "txtnombreE";
            this.txtnombreE.Size = new System.Drawing.Size(164, 29);
            this.txtnombreE.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnagregar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbpuesto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtcontraseña);
            this.groupBox3.Controls.Add(this.txtusuario);
            this.groupBox3.Controls.Add(this.cmbsexo);
            this.groupBox3.Controls.Add(this.txttelefono);
            this.groupBox3.Controls.Add(this.txtdireccion);
            this.groupBox3.Controls.Add(this.txtapellido);
            this.groupBox3.Controls.Add(this.txtnombre);
            this.groupBox3.Location = new System.Drawing.Point(14, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(610, 347);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(338, 239);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(147, 86);
            this.btnagregar.TabIndex = 19;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Puesto:";
            // 
            // cmbpuesto
            // 
            this.cmbpuesto.FormattingEnabled = true;
            this.cmbpuesto.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmbpuesto.Location = new System.Drawing.Point(415, 174);
            this.cmbpuesto.Margin = new System.Windows.Forms.Padding(5);
            this.cmbpuesto.Name = "cmbpuesto";
            this.cmbpuesto.Size = new System.Drawing.Size(164, 30);
            this.cmbpuesto.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(415, 130);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(164, 29);
            this.txtcontraseña.TabIndex = 8;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(415, 86);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(164, 29);
            this.txtusuario.TabIndex = 7;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbsexo.Location = new System.Drawing.Point(100, 130);
            this.cmbsexo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(164, 30);
            this.cmbsexo.TabIndex = 6;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(100, 217);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(164, 29);
            this.txttelefono.TabIndex = 3;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(100, 173);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(164, 29);
            this.txtdireccion.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(100, 86);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(164, 29);
            this.txtapellido.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(100, 42);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 29);
            this.txtnombre.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Sexo,
            this.Direccion,
            this.Telefono,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Puesto});
            this.dataGridView2.Location = new System.Drawing.Point(652, 53);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(885, 666);
            this.dataGridView2.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 36);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(33, 26);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 769);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbBuscarNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbpuestoE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtContraE;
        private System.Windows.Forms.TextBox txtusuE;
        private System.Windows.Forms.ComboBox cmbsexoE;
        private System.Windows.Forms.TextBox txttelefonoE;
        private System.Windows.Forms.TextBox txtdireE;
        private System.Windows.Forms.TextBox txtapelE;
        private System.Windows.Forms.TextBox txtnombreE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
    }
}
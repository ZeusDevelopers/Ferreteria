namespace PVFP
{
    partial class FrmEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradas));
            this.gbxEntrada = new System.Windows.Forms.GroupBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCostoUn = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTotalImporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntradaID = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlugar = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmbtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgrProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabCEntrada = new System.Windows.Forms.TabControl();
            this.RegistrarEntrada = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_tipo_busquedaMostrar = new System.Windows.Forms.ComboBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clmentNumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmentProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntTotalCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvEntDetalle = new System.Windows.Forms.DataGridView();
            this.btnVerEntradas = new System.Windows.Forms.Button();
            this.gbxEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabCEntrada.SuspendLayout();
            this.RegistrarEntrada.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEntrada
            // 
            this.gbxEntrada.Controls.Add(this.lblIndex);
            this.gbxEntrada.Controls.Add(this.lblImporte);
            this.gbxEntrada.Controls.Add(this.label8);
            this.gbxEntrada.Controls.Add(this.label7);
            this.gbxEntrada.Controls.Add(this.label3);
            this.gbxEntrada.Controls.Add(this.btnEditar);
            this.gbxEntrada.Controls.Add(this.txtCostoUn);
            this.gbxEntrada.Controls.Add(this.txtCantidad);
            this.gbxEntrada.Controls.Add(this.txtTotalImporte);
            this.gbxEntrada.Controls.Add(this.label6);
            this.gbxEntrada.Controls.Add(this.txtIVA);
            this.gbxEntrada.Controls.Add(this.label1);
            this.gbxEntrada.Controls.Add(this.txtEntradaID);
            this.gbxEntrada.Controls.Add(this.btnMenu);
            this.gbxEntrada.Controls.Add(this.txtTotalCompra);
            this.gbxEntrada.Controls.Add(this.label5);
            this.gbxEntrada.Controls.Add(this.dgvProductos);
            this.gbxEntrada.Controls.Add(this.btnComprar);
            this.gbxEntrada.Controls.Add(this.label4);
            this.gbxEntrada.Controls.Add(this.btnAgrProductos);
            this.gbxEntrada.Controls.Add(this.label2);
            this.gbxEntrada.Controls.Add(this.cmbProveedores);
            this.gbxEntrada.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEntrada.Location = new System.Drawing.Point(30, 17);
            this.gbxEntrada.Name = "gbxEntrada";
            this.gbxEntrada.Size = new System.Drawing.Size(1009, 476);
            this.gbxEntrada.TabIndex = 0;
            this.gbxEntrada.TabStop = false;
            this.gbxEntrada.Text = "Entrada";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(957, 88);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(22, 22);
            this.lblIndex.TabIndex = 29;
            this.lblIndex.Text = "...";
            this.lblIndex.Visible = false;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(750, 82);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(22, 22);
            this.lblImporte.TabIndex = 28;
            this.lblImporte.Text = "...";
            this.lblImporte.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Importe";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Costo Unitario";
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad";
            this.label3.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(853, 69);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 53);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCostoUn
            // 
            this.txtCostoUn.Location = new System.Drawing.Point(470, 81);
            this.txtCostoUn.Name = "txtCostoUn";
            this.txtCostoUn.Size = new System.Drawing.Size(125, 29);
            this.txtCostoUn.TabIndex = 22;
            this.txtCostoUn.Text = "0";
            this.txtCostoUn.Visible = false;
            this.txtCostoUn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUn_KeyPress);
            this.txtCostoUn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCostoUn_KeyUp);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(194, 81);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 29);
            this.txtCantidad.TabIndex = 21;
            this.txtCantidad.Text = "0";
            this.txtCantidad.Visible = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // txtTotalImporte
            // 
            this.txtTotalImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalImporte.Location = new System.Drawing.Point(559, 431);
            this.txtTotalImporte.Name = "txtTotalImporte";
            this.txtTotalImporte.ReadOnly = true;
            this.txtTotalImporte.Size = new System.Drawing.Size(124, 24);
            this.txtTotalImporte.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Importe";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(387, 431);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(124, 24);
            this.txtIVA.TabIndex = 16;
            this.txtIVA.Text = "0.16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "I.V.A.";
            // 
            // txtEntradaID
            // 
            this.txtEntradaID.Location = new System.Drawing.Point(153, 31);
            this.txtEntradaID.Name = "txtEntradaID";
            this.txtEntradaID.Size = new System.Drawing.Size(150, 29);
            this.txtEntradaID.TabIndex = 14;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(30, 321);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 53);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(224, 431);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(124, 24);
            this.txtTotalCompra.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Compra";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProducto,
            this.clmCantidad,
            this.clmCostoUnitario,
            this.clmTotal,
            this.clmlugar,
            this.clmBorrar,
            this.clmbtnEditar});
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductos.Location = new System.Drawing.Point(161, 143);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(833, 231);
            this.dgvProductos.TabIndex = 10;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            this.clmProducto.Width = 200;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmCostoUnitario
            // 
            this.clmCostoUnitario.HeaderText = "CostoUnitario";
            this.clmCostoUnitario.Name = "clmCostoUnitario";
            this.clmCostoUnitario.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Importe";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // clmlugar
            // 
            this.clmlugar.HeaderText = "Lugar";
            this.clmlugar.Items.AddRange(new object[] {
            "Piso",
            "Almacen"});
            this.clmlugar.Name = "clmlugar";
            // 
            // clmBorrar
            // 
            this.clmBorrar.HeaderText = "Quitar";
            this.clmBorrar.Name = "clmBorrar";
            this.clmBorrar.ReadOnly = true;
            // 
            // clmbtnEditar
            // 
            this.clmbtnEditar.HeaderText = "Editar";
            this.clmbtnEditar.Name = "clmbtnEditar";
            this.clmbtnEditar.ReadOnly = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(30, 237);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(98, 53);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Realizar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Num de Factura";
            // 
            // btnAgrProductos
            // 
            this.btnAgrProductos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrProductos.Location = new System.Drawing.Point(30, 149);
            this.btnAgrProductos.Name = "btnAgrProductos";
            this.btnAgrProductos.Size = new System.Drawing.Size(98, 53);
            this.btnAgrProductos.TabIndex = 6;
            this.btnAgrProductos.Text = "Agregar Productos";
            this.btnAgrProductos.UseVisualStyleBackColor = true;
            this.btnAgrProductos.Click += new System.EventHandler(this.btnAgrProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(408, 33);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(306, 30);
            this.cmbProveedores.TabIndex = 0;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            this.cmbProveedores.Click += new System.EventHandler(this.cmbProveedores_Click);
            // 
            // tabCEntrada
            // 
            this.tabCEntrada.Controls.Add(this.RegistrarEntrada);
            this.tabCEntrada.Controls.Add(this.tabPage2);
            this.tabCEntrada.Location = new System.Drawing.Point(0, 33);
            this.tabCEntrada.Name = "tabCEntrada";
            this.tabCEntrada.SelectedIndex = 0;
            this.tabCEntrada.Size = new System.Drawing.Size(1062, 526);
            this.tabCEntrada.TabIndex = 22;
            // 
            // RegistrarEntrada
            // 
            this.RegistrarEntrada.Controls.Add(this.gbxEntrada);
            this.RegistrarEntrada.Location = new System.Drawing.Point(4, 22);
            this.RegistrarEntrada.Name = "RegistrarEntrada";
            this.RegistrarEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrarEntrada.Size = new System.Drawing.Size(1054, 500);
            this.RegistrarEntrada.TabIndex = 0;
            this.RegistrarEntrada.Text = "Registrar Entrada";
            this.RegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_tipo_busquedaMostrar);
            this.tabPage2.Controls.Add(this.Btn_Buscar);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.dgvEntradas);
            this.tabPage2.Controls.Add(this.btnVerEntradas);
            this.tabPage2.Controls.Add(this.dgvEntDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_tipo_busquedaMostrar
            // 
            this.cmb_tipo_busquedaMostrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_tipo_busquedaMostrar.FormattingEnabled = true;
            this.cmb_tipo_busquedaMostrar.Items.AddRange(new object[] {
            "Numero de Factura",
            "Fecha"});
            this.cmb_tipo_busquedaMostrar.Location = new System.Drawing.Point(61, 39);
            this.cmb_tipo_busquedaMostrar.Name = "cmb_tipo_busquedaMostrar";
            this.cmb_tipo_busquedaMostrar.Size = new System.Drawing.Size(179, 30);
            this.cmb_tipo_busquedaMostrar.TabIndex = 105;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Buscar.Location = new System.Drawing.Point(693, 35);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(119, 34);
            this.Btn_Buscar.TabIndex = 104;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(390, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(289, 27);
            this.txtBuscar.TabIndex = 102;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(282, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 18);
            this.label19.TabIndex = 103;
            this.label19.Text = "Ingrese texto";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmentNumFactura,
            this.clmentProveedor,
            this.clmEntFecha,
            this.clmEntTotalCompra,
            this.clmEntEmpleado,
            this.clmEntVer});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntradas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntradas.Location = new System.Drawing.Point(61, 112);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(767, 355);
            this.dgvEntradas.TabIndex = 0;
            this.dgvEntradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1055, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.xToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(33, 26);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click_1);
            // 
            // clmentNumFactura
            // 
            this.clmentNumFactura.HeaderText = "Numero de factura";
            this.clmentNumFactura.Name = "clmentNumFactura";
            this.clmentNumFactura.ReadOnly = true;
            this.clmentNumFactura.Width = 80;
            // 
            // clmentProveedor
            // 
            this.clmentProveedor.HeaderText = "Proveedor";
            this.clmentProveedor.Name = "clmentProveedor";
            this.clmentProveedor.ReadOnly = true;
            this.clmentProveedor.Width = 81;
            // 
            // clmEntFecha
            // 
            this.clmEntFecha.HeaderText = "Fecha";
            this.clmEntFecha.Name = "clmEntFecha";
            this.clmEntFecha.ReadOnly = true;
            this.clmEntFecha.Width = 62;
            // 
            // clmEntTotalCompra
            // 
            this.clmEntTotalCompra.HeaderText = "Importe Total";
            this.clmEntTotalCompra.Name = "clmEntTotalCompra";
            this.clmEntTotalCompra.ReadOnly = true;
            this.clmEntTotalCompra.Width = 87;
            // 
            // clmEntEmpleado
            // 
            this.clmEntEmpleado.HeaderText = "Empleado";
            this.clmEntEmpleado.Name = "clmEntEmpleado";
            this.clmEntEmpleado.ReadOnly = true;
            this.clmEntEmpleado.Width = 79;
            // 
            // clmEntVer
            // 
            this.clmEntVer.HeaderText = "Ver Detalle";
            this.clmEntVer.Name = "clmEntVer";
            this.clmEntVer.ReadOnly = true;
            this.clmEntVer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEntVer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEntVer.Width = 78;
            // 
            // dgvEntDetalle
            // 
            this.dgvEntDetalle.AllowUserToAddRows = false;
            this.dgvEntDetalle.AllowUserToDeleteRows = false;
            this.dgvEntDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntDetalle.Location = new System.Drawing.Point(61, 103);
            this.dgvEntDetalle.Name = "dgvEntDetalle";
            this.dgvEntDetalle.ReadOnly = true;
            this.dgvEntDetalle.Size = new System.Drawing.Size(651, 262);
            this.dgvEntDetalle.TabIndex = 106;
            this.dgvEntDetalle.Visible = false;
            // 
            // btnVerEntradas
            // 
            this.btnVerEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEntradas.Location = new System.Drawing.Point(693, 27);
            this.btnVerEntradas.Name = "btnVerEntradas";
            this.btnVerEntradas.Size = new System.Drawing.Size(108, 52);
            this.btnVerEntradas.TabIndex = 107;
            this.btnVerEntradas.Text = "Volver Entradas";
            this.btnVerEntradas.UseVisualStyleBackColor = true;
            this.btnVerEntradas.Visible = false;
            this.btnVerEntradas.Click += new System.EventHandler(this.btnVerEntradas_Click);
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabCEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntradas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FrmEntradas";
            this.Load += new System.EventHandler(this.FrmEntradas_Load);
            this.gbxEntrada.ResumeLayout(false);
            this.gbxEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabCEntrada.ResumeLayout(false);
            this.RegistrarEntrada.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEntrada;
        private System.Windows.Forms.Button btnAgrProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtEntradaID;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtTotalImporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtCostoUn;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmlugar;
        private System.Windows.Forms.DataGridViewButtonColumn clmBorrar;
        private System.Windows.Forms.DataGridViewButtonColumn clmbtnEditar;
        private System.Windows.Forms.TabControl tabCEntrada;
        private System.Windows.Forms.TabPage RegistrarEntrada;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.ComboBox cmb_tipo_busquedaMostrar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmentNumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmentProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntTotalCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn clmEntVer;
        private System.Windows.Forms.DataGridView dgvEntDetalle;
        private System.Windows.Forms.Button btnVerEntradas;
    }
}
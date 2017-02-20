namespace PVFP
{
    partial class frmProductos
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
            this.tabControlALTA = new System.Windows.Forms.TabControl();
            this.tabPAlta = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxTipoCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecioMayore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.cmbxUM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Txtcodigobarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.tabPMostrar = new System.Windows.Forms.TabPage();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.tabPModificar = new System.Windows.Forms.TabPage();
            this.cmbmodProdID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbxmodTipoCargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmodPrecioMayoreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmodPrecioVenta = new System.Windows.Forms.TextBox();
            this.cmbxmodUM = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmodNombre = new System.Windows.Forms.TextBox();
            this.txtModCodigoBarras = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtmodFolio = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmodPrecioCosto = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtModCantidad = new System.Windows.Forms.TextBox();
            this.tabControlALTA.SuspendLayout();
            this.tabPAlta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabPModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlALTA
            // 
            this.tabControlALTA.Controls.Add(this.tabPAlta);
            this.tabControlALTA.Controls.Add(this.tabPMostrar);
            this.tabControlALTA.Controls.Add(this.tabPModificar);
            this.tabControlALTA.Location = new System.Drawing.Point(1, 31);
            this.tabControlALTA.Name = "tabControlALTA";
            this.tabControlALTA.SelectedIndex = 0;
            this.tabControlALTA.Size = new System.Drawing.Size(1271, 716);
            this.tabControlALTA.TabIndex = 51;
            // 
            // tabPAlta
            // 
            this.tabPAlta.Controls.Add(this.groupBox1);
            this.tabPAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPAlta.Name = "tabPAlta";
            this.tabPAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAlta.Size = new System.Drawing.Size(1263, 690);
            this.tabPAlta.TabIndex = 0;
            this.tabPAlta.Text = "ALTA";
            this.tabPAlta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.cmbxTipoCargo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtPrecioMayore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.cmbxUM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.Txtcodigobarras);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecioCosto);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(889, 652);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // cmbxTipoCargo
            // 
            this.cmbxTipoCargo.FormattingEnabled = true;
            this.cmbxTipoCargo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxTipoCargo.Location = new System.Drawing.Point(341, 246);
            this.cmbxTipoCargo.Name = "cmbxTipoCargo";
            this.cmbxTipoCargo.Size = new System.Drawing.Size(181, 21);
            this.cmbxTipoCargo.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(241, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 77;
            this.label8.Text = "Tipo Cargo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(215, 375);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 22);
            this.label20.TabIndex = 76;
            this.label20.Text = "Precio Mayoreo";
            // 
            // txtPrecioMayore
            // 
            this.txtPrecioMayore.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioMayore.Location = new System.Drawing.Point(341, 374);
            this.txtPrecioMayore.Name = "txtPrecioMayore";
            this.txtPrecioMayore.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioMayore.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(237, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioVenta.Location = new System.Drawing.Point(341, 332);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioVenta.TabIndex = 73;
            // 
            // cmbxUM
            // 
            this.cmbxUM.FormattingEnabled = true;
            this.cmbxUM.Items.AddRange(new object[] {
            "Por Unidad/Pza",
            "A Granel (Usa Decimal)",
            "Como Paquete (Kit)",
            "Metro"});
            this.cmbxUM.Location = new System.Drawing.Point(343, 202);
            this.cmbxUM.Name = "cmbxUM";
            this.cmbxUM.Size = new System.Drawing.Size(181, 21);
            this.cmbxUM.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(257, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtNombre.Location = new System.Drawing.Point(341, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 27);
            this.txtNombre.TabIndex = 70;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.ImageIndex = 0;
            this.BtnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuardar.Location = new System.Drawing.Point(341, 497);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 74);
            this.BtnGuardar.TabIndex = 68;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // Txtcodigobarras
            // 
            this.Txtcodigobarras.Font = new System.Drawing.Font("Calibri", 12F);
            this.Txtcodigobarras.Location = new System.Drawing.Point(341, 61);
            this.Txtcodigobarras.Name = "Txtcodigobarras";
            this.Txtcodigobarras.Size = new System.Drawing.Size(254, 27);
            this.Txtcodigobarras.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(210, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Codigo de Barra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(279, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 60;
            this.label7.Text = "Folio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(257, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Se vende";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFolio.Location = new System.Drawing.Point(341, 103);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(152, 27);
            this.txtFolio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(239, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioCosto.Location = new System.Drawing.Point(343, 285);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioCosto.TabIndex = 4;
            // 
            // tabPMostrar
            // 
            this.tabPMostrar.Controls.Add(this.Btn_Buscar);
            this.tabPMostrar.Controls.Add(this.txtBuscar);
            this.tabPMostrar.Controls.Add(this.label19);
            this.tabPMostrar.Controls.Add(this.dgvProducto);
            this.tabPMostrar.Location = new System.Drawing.Point(4, 22);
            this.tabPMostrar.Name = "tabPMostrar";
            this.tabPMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMostrar.Size = new System.Drawing.Size(1263, 690);
            this.tabPMostrar.TabIndex = 2;
            this.tabPMostrar.Text = "MOSTRAR";
            this.tabPMostrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Buscar.Location = new System.Drawing.Point(405, 32);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(119, 34);
            this.Btn_Buscar.TabIndex = 57;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(99, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(289, 27);
            this.txtBuscar.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(19, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 18);
            this.label19.TabIndex = 56;
            this.label19.Text = "Nombre";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(19, 94);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(1202, 388);
            this.dgvProducto.TabIndex = 0;
            // 
            // tabPModificar
            // 
            this.tabPModificar.Controls.Add(this.label18);
            this.tabPModificar.Controls.Add(this.txtModCantidad);
            this.tabPModificar.Controls.Add(this.cmbmodProdID);
            this.tabPModificar.Controls.Add(this.label16);
            this.tabPModificar.Controls.Add(this.cmbxmodTipoCargo);
            this.tabPModificar.Controls.Add(this.label6);
            this.tabPModificar.Controls.Add(this.label9);
            this.tabPModificar.Controls.Add(this.txtmodPrecioMayoreo);
            this.tabPModificar.Controls.Add(this.label10);
            this.tabPModificar.Controls.Add(this.txtmodPrecioVenta);
            this.tabPModificar.Controls.Add(this.cmbxmodUM);
            this.tabPModificar.Controls.Add(this.label11);
            this.tabPModificar.Controls.Add(this.txtmodNombre);
            this.tabPModificar.Controls.Add(this.txtModCodigoBarras);
            this.tabPModificar.Controls.Add(this.label12);
            this.tabPModificar.Controls.Add(this.label13);
            this.tabPModificar.Controls.Add(this.label14);
            this.tabPModificar.Controls.Add(this.txtmodFolio);
            this.tabPModificar.Controls.Add(this.label15);
            this.tabPModificar.Controls.Add(this.txtmodPrecioCosto);
            this.tabPModificar.Controls.Add(this.btnEliminar);
            this.tabPModificar.Controls.Add(this.btnModificar);
            this.tabPModificar.Location = new System.Drawing.Point(4, 22);
            this.tabPModificar.Name = "tabPModificar";
            this.tabPModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPModificar.Size = new System.Drawing.Size(1263, 690);
            this.tabPModificar.TabIndex = 1;
            this.tabPModificar.Text = "MODIFICAR";
            this.tabPModificar.UseVisualStyleBackColor = true;
            // 
            // cmbmodProdID
            // 
            this.cmbmodProdID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmodProdID.FormattingEnabled = true;
            this.cmbmodProdID.Location = new System.Drawing.Point(395, 60);
            this.cmbmodProdID.Name = "cmbmodProdID";
            this.cmbmodProdID.Size = new System.Drawing.Size(181, 27);
            this.cmbmodProdID.TabIndex = 96;
            this.cmbmodProdID.SelectedIndexChanged += new System.EventHandler(this.cmbmodProdID_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(307, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 22);
            this.label16.TabIndex = 95;
            this.label16.Text = "Nombre";
            // 
            // cmbxmodTipoCargo
            // 
            this.cmbxmodTipoCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxmodTipoCargo.FormattingEnabled = true;
            this.cmbxmodTipoCargo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxmodTipoCargo.Location = new System.Drawing.Point(395, 344);
            this.cmbxmodTipoCargo.Name = "cmbxmodTipoCargo";
            this.cmbxmodTipoCargo.Size = new System.Drawing.Size(181, 27);
            this.cmbxmodTipoCargo.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(295, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 93;
            this.label6.Text = "Tipo Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(269, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 92;
            this.label9.Text = "Precio Mayoreo";
            // 
            // txtmodPrecioMayoreo
            // 
            this.txtmodPrecioMayoreo.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtmodPrecioMayoreo.Location = new System.Drawing.Point(395, 424);
            this.txtmodPrecioMayoreo.Name = "txtmodPrecioMayoreo";
            this.txtmodPrecioMayoreo.Size = new System.Drawing.Size(135, 27);
            this.txtmodPrecioMayoreo.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(291, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 90;
            this.label10.Text = "Precio Venta";
            // 
            // txtmodPrecioVenta
            // 
            this.txtmodPrecioVenta.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtmodPrecioVenta.Location = new System.Drawing.Point(395, 382);
            this.txtmodPrecioVenta.Name = "txtmodPrecioVenta";
            this.txtmodPrecioVenta.Size = new System.Drawing.Size(135, 27);
            this.txtmodPrecioVenta.TabIndex = 89;
            // 
            // cmbxmodUM
            // 
            this.cmbxmodUM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxmodUM.FormattingEnabled = true;
            this.cmbxmodUM.Items.AddRange(new object[] {
            "Por Unidad/Pza",
            "A Granel (Usa Decimal)",
            "Como Paquete (Kit)",
            "Metro"});
            this.cmbxmodUM.Location = new System.Drawing.Point(397, 252);
            this.cmbxmodUM.Name = "cmbxmodUM";
            this.cmbxmodUM.Size = new System.Drawing.Size(181, 27);
            this.cmbxmodUM.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(311, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 22);
            this.label11.TabIndex = 87;
            this.label11.Text = "Nombre";
            // 
            // txtmodNombre
            // 
            this.txtmodNombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtmodNombre.Location = new System.Drawing.Point(395, 204);
            this.txtmodNombre.Name = "txtmodNombre";
            this.txtmodNombre.Size = new System.Drawing.Size(204, 27);
            this.txtmodNombre.TabIndex = 86;
            // 
            // txtModCodigoBarras
            // 
            this.txtModCodigoBarras.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtModCodigoBarras.Location = new System.Drawing.Point(395, 111);
            this.txtModCodigoBarras.Name = "txtModCodigoBarras";
            this.txtModCodigoBarras.Size = new System.Drawing.Size(254, 27);
            this.txtModCodigoBarras.TabIndex = 81;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(264, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 22);
            this.label12.TabIndex = 83;
            this.label12.Text = "Codigo de Barra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(333, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 22);
            this.label13.TabIndex = 85;
            this.label13.Text = "Folio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(311, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 82;
            this.label14.Text = "Se vende";
            // 
            // txtmodFolio
            // 
            this.txtmodFolio.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtmodFolio.Location = new System.Drawing.Point(395, 153);
            this.txtmodFolio.Name = "txtmodFolio";
            this.txtmodFolio.Size = new System.Drawing.Size(152, 27);
            this.txtmodFolio.TabIndex = 80;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(291, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 22);
            this.label15.TabIndex = 84;
            this.label15.Text = "Precio Costo";
            // 
            // txtmodPrecioCosto
            // 
            this.txtmodPrecioCosto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtmodPrecioCosto.Location = new System.Drawing.Point(395, 293);
            this.txtmodPrecioCosto.Name = "txtmodPrecioCosto";
            this.txtmodPrecioCosto.Size = new System.Drawing.Size(135, 27);
            this.txtmodPrecioCosto.TabIndex = 79;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(411, 520);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 74);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(241, 520);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 74);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(215, 421);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 22);
            this.label17.TabIndex = 80;
            this.label17.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(341, 420);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(135, 27);
            this.txtCantidad.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(269, 468);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 22);
            this.label18.TabIndex = 98;
            this.label18.Text = "Cantidad";
            // 
            // txtModCantidad
            // 
            this.txtModCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtModCantidad.Location = new System.Drawing.Point(395, 467);
            this.txtModCantidad.Name = "txtModCantidad";
            this.txtModCantidad.Size = new System.Drawing.Size(135, 27);
            this.txtModCantidad.TabIndex = 97;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 733);
            this.Controls.Add(this.tabControlALTA);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.tabControlALTA.ResumeLayout(false);
            this.tabPAlta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPMostrar.ResumeLayout(false);
            this.tabPMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPModificar.ResumeLayout(false);
            this.tabPModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlALTA;
        private System.Windows.Forms.TabPage tabPAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxTipoCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPrecioMayore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ComboBox cmbxUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox Txtcodigobarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TabPage tabPMostrar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TabPage tabPModificar;
        private System.Windows.Forms.ComboBox cmbmodProdID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbxmodTipoCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmodPrecioMayoreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmodPrecioVenta;
        private System.Windows.Forms.ComboBox cmbxmodUM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmodNombre;
        private System.Windows.Forms.TextBox txtModCodigoBarras;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtmodFolio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtmodPrecioCosto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtModCantidad;
    }
}
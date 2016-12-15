namespace PVFP
{
    partial class FrmAltaProductos
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostoCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPMostrar = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.clmProducID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPModificar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmodUM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmodFolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmodTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmodCostoCompra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmodNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmodProductoID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmodDescripcion = new System.Windows.Forms.TextBox();
            this.cmbmodCategoria = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbmodNombre = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tabControlALTA.SuspendLayout();
            this.tabPAlta.SuspendLayout();
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
            this.tabControlALTA.Location = new System.Drawing.Point(3, 0);
            this.tabControlALTA.Name = "tabControlALTA";
            this.tabControlALTA.SelectedIndex = 0;
            this.tabControlALTA.Size = new System.Drawing.Size(686, 362);
            this.tabControlALTA.TabIndex = 0;
            // 
            // tabPAlta
            // 
            this.tabPAlta.Controls.Add(this.label8);
            this.tabPAlta.Controls.Add(this.txtUM);
            this.tabPAlta.Controls.Add(this.label7);
            this.tabPAlta.Controls.Add(this.txtFolio);
            this.tabPAlta.Controls.Add(this.label);
            this.tabPAlta.Controls.Add(this.cmbTipo);
            this.tabPAlta.Controls.Add(this.label5);
            this.tabPAlta.Controls.Add(this.txtCostoCompra);
            this.tabPAlta.Controls.Add(this.label4);
            this.tabPAlta.Controls.Add(this.txtNombre);
            this.tabPAlta.Controls.Add(this.label2);
            this.tabPAlta.Controls.Add(this.txtProductoID);
            this.tabPAlta.Controls.Add(this.btnGuardar);
            this.tabPAlta.Controls.Add(this.label3);
            this.tabPAlta.Controls.Add(this.label1);
            this.tabPAlta.Controls.Add(this.txtdescripcion);
            this.tabPAlta.Controls.Add(this.cmbCategoria);
            this.tabPAlta.Location = new System.Drawing.Point(4, 22);
            this.tabPAlta.Name = "tabPAlta";
            this.tabPAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPAlta.Size = new System.Drawing.Size(678, 336);
            this.tabPAlta.TabIndex = 0;
            this.tabPAlta.Text = "ALTA";
            this.tabPAlta.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Unidad de medida";
            // 
            // txtUM
            // 
            this.txtUM.Location = new System.Drawing.Point(443, 174);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(122, 20);
            this.txtUM.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Folio";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(52, 174);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(122, 20);
            this.txtFolio.TabIndex = 59;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(440, 95);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(28, 13);
            this.label.TabIndex = 58;
            this.label.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(399, 111);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(146, 21);
            this.cmbTipo.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Costo_Compra";
            // 
            // txtCostoCompra
            // 
            this.txtCostoCompra.Location = new System.Drawing.Point(224, 112);
            this.txtCostoCompra.Name = "txtCostoCompra";
            this.txtCostoCompra.Size = new System.Drawing.Size(122, 20);
            this.txtCostoCompra.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 20);
            this.txtNombre.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "ProductoID";
            // 
            // txtProductoID
            // 
            this.txtProductoID.Location = new System.Drawing.Point(52, 45);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.Size = new System.Drawing.Size(122, 20);
            this.txtProductoID.TabIndex = 51;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 58);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Categoria";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(215, 173);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(198, 20);
            this.txtdescripcion.TabIndex = 16;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(39, 111);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(146, 21);
            this.cmbCategoria.TabIndex = 14;
            // 
            // tabPMostrar
            // 
            this.tabPMostrar.Controls.Add(this.dgvProducto);
            this.tabPMostrar.Location = new System.Drawing.Point(4, 22);
            this.tabPMostrar.Name = "tabPMostrar";
            this.tabPMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMostrar.Size = new System.Drawing.Size(678, 336);
            this.tabPMostrar.TabIndex = 2;
            this.tabPMostrar.Text = "MOSTRAR";
            this.tabPMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProducID,
            this.clmNombre,
            this.clmCategoria_ID,
            this.clmCostoCompra,
            this.clmTipo_ID,
            this.clmFolio,
            this.clmDescripcion,
            this.clmUm});
            this.dgvProducto.Location = new System.Drawing.Point(19, 16);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(641, 283);
            this.dgvProducto.TabIndex = 0;
            // 
            // clmProducID
            // 
            this.clmProducID.HeaderText = "Producto ID";
            this.clmProducID.Name = "clmProducID";
            this.clmProducID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCategoria_ID
            // 
            this.clmCategoria_ID.HeaderText = "Categoria_ID";
            this.clmCategoria_ID.Name = "clmCategoria_ID";
            this.clmCategoria_ID.ReadOnly = true;
            // 
            // clmCostoCompra
            // 
            this.clmCostoCompra.HeaderText = "CostoCompra";
            this.clmCostoCompra.Name = "clmCostoCompra";
            this.clmCostoCompra.ReadOnly = true;
            // 
            // clmTipo_ID
            // 
            this.clmTipo_ID.HeaderText = "Tipo_ID";
            this.clmTipo_ID.Name = "clmTipo_ID";
            this.clmTipo_ID.ReadOnly = true;
            // 
            // clmFolio
            // 
            this.clmFolio.HeaderText = "Folio";
            this.clmFolio.Name = "clmFolio";
            this.clmFolio.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmUm
            // 
            this.clmUm.HeaderText = "UM";
            this.clmUm.Name = "clmUm";
            this.clmUm.ReadOnly = true;
            // 
            // tabPModificar
            // 
            this.tabPModificar.Controls.Add(this.label6);
            this.tabPModificar.Controls.Add(this.txtmodUM);
            this.tabPModificar.Controls.Add(this.label9);
            this.tabPModificar.Controls.Add(this.txtmodFolio);
            this.tabPModificar.Controls.Add(this.label10);
            this.tabPModificar.Controls.Add(this.cmbmodTipo);
            this.tabPModificar.Controls.Add(this.label11);
            this.tabPModificar.Controls.Add(this.txtmodCostoCompra);
            this.tabPModificar.Controls.Add(this.label12);
            this.tabPModificar.Controls.Add(this.txtmodNombre);
            this.tabPModificar.Controls.Add(this.label13);
            this.tabPModificar.Controls.Add(this.txtmodProductoID);
            this.tabPModificar.Controls.Add(this.label14);
            this.tabPModificar.Controls.Add(this.label15);
            this.tabPModificar.Controls.Add(this.txtmodDescripcion);
            this.tabPModificar.Controls.Add(this.cmbmodCategoria);
            this.tabPModificar.Controls.Add(this.btnEliminar);
            this.tabPModificar.Controls.Add(this.label17);
            this.tabPModificar.Controls.Add(this.cmbmodNombre);
            this.tabPModificar.Controls.Add(this.btnModificar);
            this.tabPModificar.Location = new System.Drawing.Point(4, 22);
            this.tabPModificar.Name = "tabPModificar";
            this.tabPModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPModificar.Size = new System.Drawing.Size(678, 336);
            this.tabPModificar.TabIndex = 1;
            this.tabPModificar.Text = "MODIFICAR";
            this.tabPModificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Unidad de medida";
            // 
            // txtmodUM
            // 
            this.txtmodUM.Location = new System.Drawing.Point(427, 221);
            this.txtmodUM.Name = "txtmodUM";
            this.txtmodUM.Size = new System.Drawing.Size(122, 20);
            this.txtmodUM.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Folio";
            // 
            // txtmodFolio
            // 
            this.txtmodFolio.Location = new System.Drawing.Point(36, 221);
            this.txtmodFolio.Name = "txtmodFolio";
            this.txtmodFolio.Size = new System.Drawing.Size(122, 20);
            this.txtmodFolio.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Tipo";
            // 
            // cmbmodTipo
            // 
            this.cmbmodTipo.FormattingEnabled = true;
            this.cmbmodTipo.Location = new System.Drawing.Point(383, 158);
            this.cmbmodTipo.Name = "cmbmodTipo";
            this.cmbmodTipo.Size = new System.Drawing.Size(146, 21);
            this.cmbmodTipo.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Costo_Compra";
            // 
            // txtmodCostoCompra
            // 
            this.txtmodCostoCompra.Location = new System.Drawing.Point(208, 159);
            this.txtmodCostoCompra.Name = "txtmodCostoCompra";
            this.txtmodCostoCompra.Size = new System.Drawing.Size(122, 20);
            this.txtmodCostoCompra.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Nombre";
            // 
            // txtmodNombre
            // 
            this.txtmodNombre.Location = new System.Drawing.Point(199, 92);
            this.txtmodNombre.Name = "txtmodNombre";
            this.txtmodNombre.Size = new System.Drawing.Size(233, 20);
            this.txtmodNombre.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "ProductoID";
            // 
            // txtmodProductoID
            // 
            this.txtmodProductoID.Location = new System.Drawing.Point(36, 92);
            this.txtmodProductoID.Name = "txtmodProductoID";
            this.txtmodProductoID.Size = new System.Drawing.Size(122, 20);
            this.txtmodProductoID.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Descripcion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Categoria";
            // 
            // txtmodDescripcion
            // 
            this.txtmodDescripcion.Location = new System.Drawing.Point(199, 220);
            this.txtmodDescripcion.Name = "txtmodDescripcion";
            this.txtmodDescripcion.Size = new System.Drawing.Size(198, 20);
            this.txtmodDescripcion.TabIndex = 64;
            // 
            // cmbmodCategoria
            // 
            this.cmbmodCategoria.FormattingEnabled = true;
            this.cmbmodCategoria.Location = new System.Drawing.Point(23, 158);
            this.cmbmodCategoria.Name = "cmbmodCategoria";
            this.cmbmodCategoria.Size = new System.Drawing.Size(146, 21);
            this.cmbmodCategoria.TabIndex = 63;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(354, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 58);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(146, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Nombre";
            // 
            // cmbmodNombre
            // 
            this.cmbmodNombre.FormattingEnabled = true;
            this.cmbmodNombre.Location = new System.Drawing.Point(115, 34);
            this.cmbmodNombre.Name = "cmbmodNombre";
            this.cmbmodNombre.Size = new System.Drawing.Size(146, 21);
            this.cmbmodNombre.TabIndex = 51;
            this.cmbmodNombre.SelectedIndexChanged += new System.EventHandler(this.cmbmodDescripcion_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(199, 263);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 58);
            this.btnModificar.TabIndex = 48;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 374);
            this.Controls.Add(this.tabControlALTA);
            this.Name = "FrmAltaProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmAltaProductos_Load);
            this.tabControlALTA.ResumeLayout(false);
            this.tabPAlta.ResumeLayout(false);
            this.tabPAlta.PerformLayout();
            this.tabPMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPModificar.ResumeLayout(false);
            this.tabPModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlALTA;
        private System.Windows.Forms.TabPage tabPAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TabPage tabPModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabPMostrar;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostoCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmodUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmodFolio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmodTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmodCostoCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmodNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmodProductoID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtmodDescripcion;
        private System.Windows.Forms.ComboBox cmbmodCategoria;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbmodNombre;
    }
}
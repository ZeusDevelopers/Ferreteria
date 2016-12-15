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
            this.gbxEntrada = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaID = new System.Windows.Forms.TextBox();
            this.btnAgrProductos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.gbxEntCompra = new System.Windows.Forms.GroupBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnAgrPG = new System.Windows.Forms.Button();
            this.lblTotProd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalProducto = new System.Windows.Forms.TextBox();
            this.txtCostoUnit = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnCalTotProd = new System.Windows.Forms.Button();
            this.gbxEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbxEntCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEntrada
            // 
            this.gbxEntrada.Controls.Add(this.btnMenu);
            this.gbxEntrada.Controls.Add(this.txtTotalCompra);
            this.gbxEntrada.Controls.Add(this.label5);
            this.gbxEntrada.Controls.Add(this.dgvProductos);
            this.gbxEntrada.Controls.Add(this.btnComprar);
            this.gbxEntrada.Controls.Add(this.label4);
            this.gbxEntrada.Controls.Add(this.txtEntradaID);
            this.gbxEntrada.Controls.Add(this.btnAgrProductos);
            this.gbxEntrada.Controls.Add(this.label2);
            this.gbxEntrada.Controls.Add(this.cmbProveedores);
            this.gbxEntrada.Location = new System.Drawing.Point(43, 32);
            this.gbxEntrada.Name = "gbxEntrada";
            this.gbxEntrada.Size = new System.Drawing.Size(744, 428);
            this.gbxEntrada.TabIndex = 0;
            this.gbxEntrada.TabStop = false;
            this.gbxEntrada.Text = "Entrada";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtTotalCompra.Location = new System.Drawing.Point(580, 388);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(124, 24);
            this.txtTotalCompra.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 392);
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
            this.clmBorrar});
            this.dgvProductos.Location = new System.Drawing.Point(163, 118);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(541, 231);
            this.dgvProductos.TabIndex = 10;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
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
            this.clmTotal.HeaderText = "TotalProducto";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // clmBorrar
            // 
            this.clmBorrar.HeaderText = "Quitar";
            this.clmBorrar.Name = "clmBorrar";
            this.clmBorrar.ReadOnly = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entrada_ID";
            // 
            // txtEntradaID
            // 
            this.txtEntradaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaID.Location = new System.Drawing.Point(126, 33);
            this.txtEntradaID.Name = "txtEntradaID";
            this.txtEntradaID.ReadOnly = true;
            this.txtEntradaID.Size = new System.Drawing.Size(124, 24);
            this.txtEntradaID.TabIndex = 7;
            // 
            // btnAgrProductos
            // 
            this.btnAgrProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(408, 33);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(306, 26);
            this.cmbProveedores.TabIndex = 0;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            this.cmbProveedores.Click += new System.EventHandler(this.cmbProveedores_Click);
            // 
            // gbxEntCompra
            // 
            this.gbxEntCompra.Controls.Add(this.btnCalTotProd);
            this.gbxEntCompra.Controls.Add(this.btnTerminar);
            this.gbxEntCompra.Controls.Add(this.btnAgrPG);
            this.gbxEntCompra.Controls.Add(this.lblTotProd);
            this.gbxEntCompra.Controls.Add(this.label7);
            this.gbxEntCompra.Controls.Add(this.label6);
            this.gbxEntCompra.Controls.Add(this.txtTotalProducto);
            this.gbxEntCompra.Controls.Add(this.txtCostoUnit);
            this.gbxEntCompra.Controls.Add(this.txtCantidad);
            this.gbxEntCompra.Controls.Add(this.label1);
            this.gbxEntCompra.Controls.Add(this.cmbProducto);
            this.gbxEntCompra.Location = new System.Drawing.Point(206, 16);
            this.gbxEntCompra.Name = "gbxEntCompra";
            this.gbxEntCompra.Size = new System.Drawing.Size(411, 428);
            this.gbxEntCompra.TabIndex = 1;
            this.gbxEntCompra.TabStop = false;
            this.gbxEntCompra.Text = "Comprar";
            this.gbxEntCompra.Visible = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(245, 255);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(98, 53);
            this.btnTerminar.TabIndex = 15;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnAgrPG
            // 
            this.btnAgrPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrPG.Location = new System.Drawing.Point(245, 154);
            this.btnAgrPG.Name = "btnAgrPG";
            this.btnAgrPG.Size = new System.Drawing.Size(98, 53);
            this.btnAgrPG.TabIndex = 14;
            this.btnAgrPG.Text = "Agregar Productos";
            this.btnAgrPG.UseVisualStyleBackColor = true;
            this.btnAgrPG.Click += new System.EventHandler(this.btnAgrPG_Click);
            // 
            // lblTotProd
            // 
            this.lblTotProd.AutoSize = true;
            this.lblTotProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotProd.Location = new System.Drawing.Point(29, 298);
            this.lblTotProd.Name = "lblTotProd";
            this.lblTotProd.Size = new System.Drawing.Size(126, 20);
            this.lblTotProd.TabIndex = 13;
            this.lblTotProd.Text = "Total Producto";
            this.lblTotProd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Costo Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // txtTotalProducto
            // 
            this.txtTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProducto.Location = new System.Drawing.Point(33, 337);
            this.txtTotalProducto.Name = "txtTotalProducto";
            this.txtTotalProducto.ReadOnly = true;
            this.txtTotalProducto.Size = new System.Drawing.Size(124, 26);
            this.txtTotalProducto.TabIndex = 10;
            this.txtTotalProducto.Visible = false;
            // 
            // txtCostoUnit
            // 
            this.txtCostoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnit.Location = new System.Drawing.Point(35, 193);
            this.txtCostoUnit.Name = "txtCostoUnit";
            this.txtCostoUnit.Size = new System.Drawing.Size(100, 26);
            this.txtCostoUnit.TabIndex = 9;
            this.txtCostoUnit.Text = "0";
            this.txtCostoUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnit_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(35, 134);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 26);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "0";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(31, 71);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(247, 28);
            this.cmbProducto.TabIndex = 0;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.Click += new System.EventHandler(this.cmbProducto_Click);
            // 
            // btnCalTotProd
            // 
            this.btnCalTotProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTotProd.Location = new System.Drawing.Point(35, 242);
            this.btnCalTotProd.Name = "btnCalTotProd";
            this.btnCalTotProd.Size = new System.Drawing.Size(131, 53);
            this.btnCalTotProd.TabIndex = 16;
            this.btnCalTotProd.Text = "Calcular total Producto";
            this.btnCalTotProd.UseVisualStyleBackColor = true;
            this.btnCalTotProd.Click += new System.EventHandler(this.btnCalTotProd_Click);
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.gbxEntCompra);
            this.Controls.Add(this.gbxEntrada);
            this.Name = "FrmEntradas";
            this.Text = "FrmEntradas";
            this.Load += new System.EventHandler(this.FrmEntradas_Load);
            this.gbxEntrada.ResumeLayout(false);
            this.gbxEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbxEntCompra.ResumeLayout(false);
            this.gbxEntCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEntrada;
        private System.Windows.Forms.Button btnAgrProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.GroupBox gbxEntCompra;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaID;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewButtonColumn clmBorrar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAgrPG;
        private System.Windows.Forms.Label lblTotProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalProducto;
        private System.Windows.Forms.TextBox txtCostoUnit;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCalTotProd;
    }
}
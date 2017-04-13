namespace PVFP
{
    partial class frmEntradasDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradasDetalle));
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.Cmb_tipo_busqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioAnterior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(339, 326);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(98, 53);
            this.btnTerminar.TabIndex = 26;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnAgrPG
            // 
            this.btnAgrPG.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrPG.Location = new System.Drawing.Point(219, 326);
            this.btnAgrPG.Name = "btnAgrPG";
            this.btnAgrPG.Size = new System.Drawing.Size(98, 53);
            this.btnAgrPG.TabIndex = 25;
            this.btnAgrPG.Text = "Agregar Productos";
            this.btnAgrPG.UseVisualStyleBackColor = true;
            this.btnAgrPG.Click += new System.EventHandler(this.btnAgrPG_Click);
            // 
            // lblTotProd
            // 
            this.lblTotProd.AutoSize = true;
            this.lblTotProd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotProd.Location = new System.Drawing.Point(46, 313);
            this.lblTotProd.Name = "lblTotProd";
            this.lblTotProd.Size = new System.Drawing.Size(71, 22);
            this.lblTotProd.TabIndex = 24;
            this.lblTotProd.Text = "Importe";
            this.lblTotProd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Costo Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad";
            // 
            // txtTotalProducto
            // 
            this.txtTotalProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProducto.Location = new System.Drawing.Point(46, 338);
            this.txtTotalProducto.Name = "txtTotalProducto";
            this.txtTotalProducto.ReadOnly = true;
            this.txtTotalProducto.Size = new System.Drawing.Size(141, 29);
            this.txtTotalProducto.TabIndex = 21;
            this.txtTotalProducto.Visible = false;
            // 
            // txtCostoUnit
            // 
            this.txtCostoUnit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnit.Location = new System.Drawing.Point(46, 277);
            this.txtCostoUnit.Name = "txtCostoUnit";
            this.txtCostoUnit.Size = new System.Drawing.Size(145, 29);
            this.txtCostoUnit.TabIndex = 20;
            this.txtCostoUnit.Text = "0";
            this.txtCostoUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnit_KeyPress);
            this.txtCostoUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCostoUnit_KeyUp);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(42, 214);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 29);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Text = "0";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(96, 91);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(334, 30);
            this.cmbProducto.TabIndex = 17;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.Click += new System.EventHandler(this.cmbProducto_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(155, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 113;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txtcodigo.Font = new System.Drawing.Font("Arial", 14F);
            this.Txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.Txtcodigo.Location = new System.Drawing.Point(32, 90);
            this.Txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(395, 29);
            this.Txtcodigo.TabIndex = 112;
            // 
            // Cmb_tipo_busqueda
            // 
            this.Cmb_tipo_busqueda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_tipo_busqueda.Font = new System.Drawing.Font("Arial", 14F);
            this.Cmb_tipo_busqueda.FormattingEnabled = true;
            this.Cmb_tipo_busqueda.Items.AddRange(new object[] {
            "Codigo",
            "Folio",
            "Nombre"});
            this.Cmb_tipo_busqueda.Location = new System.Drawing.Point(32, 36);
            this.Cmb_tipo_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_tipo_busqueda.Name = "Cmb_tipo_busqueda";
            this.Cmb_tipo_busqueda.Size = new System.Drawing.Size(205, 30);
            this.Cmb_tipo_busqueda.TabIndex = 111;
            this.Cmb_tipo_busqueda.SelectedIndexChanged += new System.EventHandler(this.Cmb_tipo_busqueda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 114;
            this.label2.Text = "Costo Anterior";
            // 
            // lblPrecioAnterior
            // 
            this.lblPrecioAnterior.AutoSize = true;
            this.lblPrecioAnterior.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAnterior.Location = new System.Drawing.Point(263, 254);
            this.lblPrecioAnterior.Name = "lblPrecioAnterior";
            this.lblPrecioAnterior.Size = new System.Drawing.Size(22, 22);
            this.lblPrecioAnterior.TabIndex = 115;
            this.lblPrecioAnterior.Text = "...";
            // 
            // frmEntradasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 392);
            this.Controls.Add(this.lblPrecioAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.Cmb_tipo_busqueda);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnAgrPG);
            this.Controls.Add(this.lblTotProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalProducto);
            this.Controls.Add(this.txtCostoUnit);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntradasDetalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmEntradasDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnAgrPG;
        private System.Windows.Forms.Label lblTotProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalProducto;
        private System.Windows.Forms.TextBox txtCostoUnit;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.ComboBox Cmb_tipo_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioAnterior;
    }
}
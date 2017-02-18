namespace PVFP
{
    partial class FrmPuntoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoVenta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.Lbl_codprd = new System.Windows.Forms.Label();
            this.GbVenta = new System.Windows.Forms.GroupBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.Lbl_tarjeta = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.Lbl_cambio = new System.Windows.Forms.Label();
            this.LblCambio = new System.Windows.Forms.Label();
            this.Btn_Aceptar_pago = new System.Windows.Forms.Button();
            this.Txt_efectivo = new System.Windows.Forms.TextBox();
            this.LblPago = new System.Windows.Forms.Label();
            this.Lbltotal = new System.Windows.Forms.Label();
            this.Lbl_txtTotal = new System.Windows.Forms.Label();
            this.Lblsubtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_total_final = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_comprar = new System.Windows.Forms.Button();
            this.Btn_cantidad = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Gb_Venta = new System.Windows.Forms.GroupBox();
            this.btn_abrir_cajon = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.GbVenta.SuspendLayout();
            this.Gb_Venta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.xToolStripMenuItem, "xToolStripMenuItem");
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Importe});
            resources.ApplyResources(this.DgvVentas, "DgvVentas");
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.RowTemplate.Height = 28;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellClick);
            this.DgvVentas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvVentas_RowsAdded);
            // 
            // Codigo
            // 
            resources.ApplyResources(this.Codigo, "Codigo");
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            resources.ApplyResources(this.Producto, "Producto");
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            resources.ApplyResources(this.Cantidad, "Cantidad");
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            resources.ApplyResources(this.Precio, "Precio");
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            resources.ApplyResources(this.Importe, "Importe");
            this.Importe.Name = "Importe";
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.Txtcodigo, "Txtcodigo");
            this.Txtcodigo.ForeColor = System.Drawing.Color.Silver;
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.TextChanged += new System.EventHandler(this.Txtcodigo_TextChanged);
            this.Txtcodigo.Enter += new System.EventHandler(this.Txtcodigo_Enter);
            this.Txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcodigo_KeyPress);
            this.Txtcodigo.Leave += new System.EventHandler(this.Txtcodigo_Leave);
            // 
            // Lbl_codprd
            // 
            resources.ApplyResources(this.Lbl_codprd, "Lbl_codprd");
            this.Lbl_codprd.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codprd.ForeColor = System.Drawing.Color.White;
            this.Lbl_codprd.Name = "Lbl_codprd";
            // 
            // GbVenta
            // 
            resources.ApplyResources(this.GbVenta, "GbVenta");
            this.GbVenta.Controls.Add(this.btncerrar);
            this.GbVenta.Controls.Add(this.Lbl_tarjeta);
            this.GbVenta.Controls.Add(this.BtnCancelar);
            this.GbVenta.Controls.Add(this.Lbl_cambio);
            this.GbVenta.Controls.Add(this.LblCambio);
            this.GbVenta.Controls.Add(this.Btn_Aceptar_pago);
            this.GbVenta.Controls.Add(this.Txt_efectivo);
            this.GbVenta.Controls.Add(this.LblPago);
            this.GbVenta.Controls.Add(this.Lbltotal);
            this.GbVenta.Controls.Add(this.Lbl_txtTotal);
            this.GbVenta.Name = "GbVenta";
            this.GbVenta.TabStop = false;
            // 
            // btncerrar
            // 
            resources.ApplyResources(this.btncerrar, "btncerrar");
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Lbl_tarjeta
            // 
            resources.ApplyResources(this.Lbl_tarjeta, "Lbl_tarjeta");
            this.Lbl_tarjeta.Name = "Lbl_tarjeta";
            // 
            // BtnCancelar
            // 
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Lbl_cambio
            // 
            resources.ApplyResources(this.Lbl_cambio, "Lbl_cambio");
            this.Lbl_cambio.Name = "Lbl_cambio";
            // 
            // LblCambio
            // 
            resources.ApplyResources(this.LblCambio, "LblCambio");
            this.LblCambio.Name = "LblCambio";
            // 
            // Btn_Aceptar_pago
            // 
            resources.ApplyResources(this.Btn_Aceptar_pago, "Btn_Aceptar_pago");
            this.Btn_Aceptar_pago.Name = "Btn_Aceptar_pago";
            this.Btn_Aceptar_pago.UseVisualStyleBackColor = true;
            this.Btn_Aceptar_pago.Click += new System.EventHandler(this.Btn_Aceptar_pago_Click);
            // 
            // Txt_efectivo
            // 
            this.Txt_efectivo.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.Txt_efectivo, "Txt_efectivo");
            this.Txt_efectivo.ForeColor = System.Drawing.Color.Silver;
            this.Txt_efectivo.Name = "Txt_efectivo";
            this.Txt_efectivo.TextChanged += new System.EventHandler(this.Txt_efectivo_TextChanged);
            this.Txt_efectivo.Enter += new System.EventHandler(this.Txt_efectivo_Enter);
            this.Txt_efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_efectivo_KeyPress);
            // 
            // LblPago
            // 
            resources.ApplyResources(this.LblPago, "LblPago");
            this.LblPago.Name = "LblPago";
            // 
            // Lbltotal
            // 
            resources.ApplyResources(this.Lbltotal, "Lbltotal");
            this.Lbltotal.Name = "Lbltotal";
            // 
            // Lbl_txtTotal
            // 
            resources.ApplyResources(this.Lbl_txtTotal, "Lbl_txtTotal");
            this.Lbl_txtTotal.Name = "Lbl_txtTotal";
            // 
            // Lblsubtotal
            // 
            resources.ApplyResources(this.Lblsubtotal, "Lblsubtotal");
            this.Lblsubtotal.BackColor = System.Drawing.Color.Transparent;
            this.Lblsubtotal.ForeColor = System.Drawing.Color.White;
            this.Lblsubtotal.Name = "Lblsubtotal";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Name = "label4";
            // 
            // lbliva
            // 
            resources.ApplyResources(this.lbliva, "lbliva");
            this.lbliva.BackColor = System.Drawing.Color.Transparent;
            this.lbliva.ForeColor = System.Drawing.Color.White;
            this.lbliva.Name = "lbliva";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Name = "label5";
            // 
            // Lbl_total_final
            // 
            resources.ApplyResources(this.Lbl_total_final, "Lbl_total_final");
            this.Lbl_total_final.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_total_final.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_total_final.Name = "Lbl_total_final";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Name = "label7";
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Btn_limpiar, "Btn_limpiar");
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_Buscar
            // 
            resources.ApplyResources(this.Btn_Buscar, "Btn_Buscar");
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_comprar
            // 
            this.Btn_comprar.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Btn_comprar, "Btn_comprar");
            this.Btn_comprar.Name = "Btn_comprar";
            this.Btn_comprar.UseVisualStyleBackColor = false;
            this.Btn_comprar.Click += new System.EventHandler(this.Btn_comprar_Click);
            // 
            // Btn_cantidad
            // 
            this.Btn_cantidad.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Btn_cantidad, "Btn_cantidad");
            this.Btn_cantidad.Name = "Btn_cantidad";
            this.Btn_cantidad.UseVisualStyleBackColor = false;
            this.Btn_cantidad.Click += new System.EventHandler(this.Btn_cantidad_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Btn_eliminar, "Btn_eliminar");
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Gb_Venta
            // 
            this.Gb_Venta.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Venta.Controls.Add(this.lbliva);
            this.Gb_Venta.Controls.Add(this.label4);
            this.Gb_Venta.Controls.Add(this.Lblsubtotal);
            this.Gb_Venta.Controls.Add(this.label5);
            this.Gb_Venta.Controls.Add(this.label7);
            this.Gb_Venta.Controls.Add(this.Lbl_total_final);
            resources.ApplyResources(this.Gb_Venta, "Gb_Venta");
            this.Gb_Venta.Name = "Gb_Venta";
            this.Gb_Venta.TabStop = false;
            // 
            // btn_abrir_cajon
            // 
            this.btn_abrir_cajon.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.btn_abrir_cajon, "btn_abrir_cajon");
            this.btn_abrir_cajon.Name = "btn_abrir_cajon";
            this.btn_abrir_cajon.UseVisualStyleBackColor = false;
            this.btn_abrir_cajon.Click += new System.EventHandler(this.btn_abrir_cajon_Click);
            // 
            // FrmPuntoVenta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PVFP.Properties.Resources.venta_bg;
            this.ControlBox = false;
            this.Controls.Add(this.btn_abrir_cajon);
            this.Controls.Add(this.Gb_Venta);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_cantidad);
            this.Controls.Add(this.Lbl_codprd);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.GbVenta);
            this.Controls.Add(this.Btn_comprar);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPuntoVenta";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPuntoVenta_FormClosed);
            this.Load += new System.EventHandler(this.FrmPuntoVenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.GbVenta.ResumeLayout(false);
            this.GbVenta.PerformLayout();
            this.Gb_Venta.ResumeLayout(false);
            this.Gb_Venta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label Lbl_codprd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button Btn_comprar;
        private System.Windows.Forms.GroupBox GbVenta;
        private System.Windows.Forms.Label Lbltotal;
        private System.Windows.Forms.Label Lbl_txtTotal;
        private System.Windows.Forms.Label Lblsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_efectivo;
        private System.Windows.Forms.Label LblPago;
        private System.Windows.Forms.Button Btn_Aceptar_pago;
        private System.Windows.Forms.Label Lbl_cambio;
        private System.Windows.Forms.Label LblCambio;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_total_final;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_tarjeta;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button Btn_cantidad;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gb_Venta;
        private System.Windows.Forms.Button btn_abrir_cajon;
    }
}
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_comprar = new System.Windows.Forms.Button();
            this.GbVenta = new System.Windows.Forms.GroupBox();
            this.Lbl_cambio = new System.Windows.Forms.Label();
            this.LblCambio = new System.Windows.Forms.Label();
            this.Btn_Aceptar_pago = new System.Windows.Forms.Button();
            this.Txt_efectivo = new System.Windows.Forms.TextBox();
            this.LblPago = new System.Windows.Forms.Label();
            this.Lbltotal = new System.Windows.Forms.Label();
            this.Lbl_txtTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GbVenta.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Importe});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            resources.ApplyResources(this.Btn_Buscar, "Btn_Buscar");
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.Txtcodigo, "Txtcodigo");
            this.Txtcodigo.ForeColor = System.Drawing.Color.Silver;
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Enter += new System.EventHandler(this.Txtcodigo_Enter);
            this.Txtcodigo.Leave += new System.EventHandler(this.Txtcodigo_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Btn_comprar
            // 
            this.Btn_comprar.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Btn_comprar, "Btn_comprar");
            this.Btn_comprar.Name = "Btn_comprar";
            this.Btn_comprar.UseVisualStyleBackColor = false;
            this.Btn_comprar.Click += new System.EventHandler(this.Btn_comprar_Click);
            // 
            // GbVenta
            // 
            this.GbVenta.Controls.Add(this.BtnCancelar);
            this.GbVenta.Controls.Add(this.Lbl_cambio);
            this.GbVenta.Controls.Add(this.LblCambio);
            this.GbVenta.Controls.Add(this.Btn_Aceptar_pago);
            this.GbVenta.Controls.Add(this.Txt_efectivo);
            this.GbVenta.Controls.Add(this.LblPago);
            this.GbVenta.Controls.Add(this.Lbltotal);
            this.GbVenta.Controls.Add(this.Lbl_txtTotal);
            resources.ApplyResources(this.GbVenta, "GbVenta");
            this.GbVenta.Name = "GbVenta";
            this.GbVenta.TabStop = false;
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
            // 
            // Txt_efectivo
            // 
            this.Txt_efectivo.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.Txt_efectivo, "Txt_efectivo");
            this.Txt_efectivo.ForeColor = System.Drawing.Color.Silver;
            this.Txt_efectivo.Name = "Txt_efectivo";
            this.Txt_efectivo.Enter += new System.EventHandler(this.Txt_efectivo_Enter);
            this.Txt_efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_efectivo_KeyPress);
            this.Txt_efectivo.Leave += new System.EventHandler(this.Txt_efectivo_Leave);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // BtnCancelar
            // 
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmPuntoVenta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GbVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_comprar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPuntoVenta";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GbVenta.ResumeLayout(false);
            this.GbVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button Btn_comprar;
        private System.Windows.Forms.GroupBox GbVenta;
        private System.Windows.Forms.Label Lbltotal;
        private System.Windows.Forms.Label Lbl_txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_efectivo;
        private System.Windows.Forms.Label LblPago;
        private System.Windows.Forms.Button Btn_Aceptar_pago;
        private System.Windows.Forms.Label Lbl_cambio;
        private System.Windows.Forms.Label LblCambio;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
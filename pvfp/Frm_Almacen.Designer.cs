namespace Ferreteria
{
    partial class Frm_Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Almacen));
            this.Gbx_almacen = new System.Windows.Forms.GroupBox();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_pasar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.Lblproducto = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.Cmb_cambio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_resul = new System.Windows.Forms.DataGridView();
            this.Btn_previous = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.Gbx_almacen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbx_almacen
            // 
            this.Gbx_almacen.Controls.Add(this.lblcantidad);
            this.Gbx_almacen.Controls.Add(this.Btn_seleccionar);
            this.Gbx_almacen.Controls.Add(this.Btn_pasar);
            this.Gbx_almacen.Controls.Add(this.label1);
            this.Gbx_almacen.Controls.Add(this.txtcantidad);
            this.Gbx_almacen.Controls.Add(this.Lblproducto);
            this.Gbx_almacen.Controls.Add(this.txt_producto);
            this.Gbx_almacen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbx_almacen.Location = new System.Drawing.Point(21, 137);
            this.Gbx_almacen.Name = "Gbx_almacen";
            this.Gbx_almacen.Size = new System.Drawing.Size(968, 246);
            this.Gbx_almacen.TabIndex = 0;
            this.Gbx_almacen.TabStop = false;
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_seleccionar.Image")));
            this.Btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_seleccionar.Location = new System.Drawing.Point(619, 73);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(213, 47);
            this.Btn_seleccionar.TabIndex = 32;
            this.Btn_seleccionar.Text = "Buscar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Btn_pasar
            // 
            this.Btn_pasar.Location = new System.Drawing.Point(285, 176);
            this.Btn_pasar.Name = "Btn_pasar";
            this.Btn_pasar.Size = new System.Drawing.Size(124, 45);
            this.Btn_pasar.TabIndex = 4;
            this.Btn_pasar.Text = "Pasar";
            this.Btn_pasar.UseVisualStyleBackColor = true;
            this.Btn_pasar.Click += new System.EventHandler(this.Btn_pasar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(188, 128);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(221, 40);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // Lblproducto
            // 
            this.Lblproducto.AutoSize = true;
            this.Lblproducto.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblproducto.Location = new System.Drawing.Point(55, 76);
            this.Lblproducto.Name = "Lblproducto";
            this.Lblproducto.Size = new System.Drawing.Size(127, 32);
            this.Lblproducto.TabIndex = 1;
            this.Lblproducto.Text = "Producto";
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.Location = new System.Drawing.Point(188, 76);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(425, 40);
            this.txt_producto.TabIndex = 0;
            // 
            // Cmb_cambio
            // 
            this.Cmb_cambio.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_cambio.FormattingEnabled = true;
            this.Cmb_cambio.Items.AddRange(new object[] {
            "Almacen a Piso",
            "Piso a Almacen"});
            this.Cmb_cambio.Location = new System.Drawing.Point(321, 86);
            this.Cmb_cambio.Name = "Cmb_cambio";
            this.Cmb_cambio.Size = new System.Drawing.Size(288, 40);
            this.Cmb_cambio.TabIndex = 1;
            this.Cmb_cambio.SelectedIndexChanged += new System.EventHandler(this.Cmb_cambio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tipo de traspaso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_resul);
            this.groupBox1.Location = new System.Drawing.Point(21, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 408);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // dgv_resul
            // 
            this.dgv_resul.AllowUserToAddRows = false;
            this.dgv_resul.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resul.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_resul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resul.Location = new System.Drawing.Point(3, 22);
            this.dgv_resul.Name = "dgv_resul";
            this.dgv_resul.RowTemplate.Height = 28;
            this.dgv_resul.Size = new System.Drawing.Size(962, 383);
            this.dgv_resul.TabIndex = 1;
            // 
            // Btn_previous
            // 
            this.Btn_previous.Image = global::Ferreteria.Properties.Resources.transfer2;
            this.Btn_previous.Location = new System.Drawing.Point(535, 389);
            this.Btn_previous.Name = "Btn_previous";
            this.Btn_previous.Size = new System.Drawing.Size(147, 59);
            this.Btn_previous.TabIndex = 35;
            this.Btn_previous.UseVisualStyleBackColor = true;
            this.Btn_previous.Click += new System.EventHandler(this.Btn_previous_Click);
            // 
            // txtcant
            // 
            this.txtcant.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcant.Location = new System.Drawing.Point(688, 395);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(75, 40);
            this.txtcant.TabIndex = 37;
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Font = new System.Drawing.Font("Arial", 16F);
            this.lblcant.Location = new System.Drawing.Point(769, 398);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(42, 36);
            this.lblcant.TabIndex = 33;
            this.lblcant.Text = "/0";
            // 
            // btnext
            // 
            this.btnext.Image = global::Ferreteria.Properties.Resources.right;
            this.btnext.Location = new System.Drawing.Point(831, 389);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(147, 59);
            this.btnext.TabIndex = 38;
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(427, 131);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(127, 32);
            this.lblcantidad.TabIndex = 33;
            this.lblcantidad.Text = "Cantidad";
            this.lblcantidad.Visible = false;
            // 
            // Frm_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 844);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.Btn_previous);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_cambio);
            this.Controls.Add(this.Gbx_almacen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Almacen";
            this.Load += new System.EventHandler(this.Frm_Almacen_Load);
            this.Gbx_almacen.ResumeLayout(false);
            this.Gbx_almacen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_almacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label Lblproducto;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Button Btn_pasar;
        private System.Windows.Forms.ComboBox Cmb_cambio;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_resul;
        private System.Windows.Forms.Button Btn_previous;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Label lblcantidad;
    }
}
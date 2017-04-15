namespace Ferreteria
{
    partial class Frm_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Devolucion));
            this.GrBx_Fecha = new System.Windows.Forms.GroupBox();
            this.Rbtn_fecha = new System.Windows.Forms.RadioButton();
            this.Dtpfechinicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechinicio = new System.Windows.Forms.Label();
            this.Gb_No_Venta = new System.Windows.Forms.GroupBox();
            this.LblNumventa = new System.Windows.Forms.Label();
            this.Rbtn_venta = new System.Windows.Forms.RadioButton();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txtintervalo = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.Btn_anteriro = new System.Windows.Forms.Button();
            this.GrBx_Fecha.SuspendLayout();
            this.Gb_No_Venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrBx_Fecha
            // 
            this.GrBx_Fecha.Controls.Add(this.Rbtn_fecha);
            this.GrBx_Fecha.Controls.Add(this.Dtpfechinicio);
            this.GrBx_Fecha.Controls.Add(this.Lbl_fechinicio);
            this.GrBx_Fecha.Location = new System.Drawing.Point(21, 12);
            this.GrBx_Fecha.Name = "GrBx_Fecha";
            this.GrBx_Fecha.Size = new System.Drawing.Size(646, 71);
            this.GrBx_Fecha.TabIndex = 6;
            this.GrBx_Fecha.TabStop = false;
            this.GrBx_Fecha.Text = "Fecha";
            // 
            // Rbtn_fecha
            // 
            this.Rbtn_fecha.AutoSize = true;
            this.Rbtn_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_fecha.Location = new System.Drawing.Point(14, 25);
            this.Rbtn_fecha.Name = "Rbtn_fecha";
            this.Rbtn_fecha.Size = new System.Drawing.Size(119, 36);
            this.Rbtn_fecha.TabIndex = 7;
            this.Rbtn_fecha.TabStop = true;
            this.Rbtn_fecha.Text = "Fecha";
            this.Rbtn_fecha.UseVisualStyleBackColor = true;
            this.Rbtn_fecha.CheckedChanged += new System.EventHandler(this.Rbtn_fecha_CheckedChanged);
            // 
            // Dtpfechinicio
            // 
            this.Dtpfechinicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Dtpfechinicio.Location = new System.Drawing.Point(258, 35);
            this.Dtpfechinicio.Name = "Dtpfechinicio";
            this.Dtpfechinicio.Size = new System.Drawing.Size(294, 26);
            this.Dtpfechinicio.TabIndex = 0;
            // 
            // Lbl_fechinicio
            // 
            this.Lbl_fechinicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_fechinicio.AutoSize = true;
            this.Lbl_fechinicio.Location = new System.Drawing.Point(158, 37);
            this.Lbl_fechinicio.Name = "Lbl_fechinicio";
            this.Lbl_fechinicio.Size = new System.Drawing.Size(95, 20);
            this.Lbl_fechinicio.TabIndex = 1;
            this.Lbl_fechinicio.Text = "Fecha Inicio";
            // 
            // Gb_No_Venta
            // 
            this.Gb_No_Venta.Controls.Add(this.LblNumventa);
            this.Gb_No_Venta.Controls.Add(this.Rbtn_venta);
            this.Gb_No_Venta.Controls.Add(this.TxtVenta);
            this.Gb_No_Venta.Location = new System.Drawing.Point(21, 89);
            this.Gb_No_Venta.Name = "Gb_No_Venta";
            this.Gb_No_Venta.Size = new System.Drawing.Size(646, 78);
            this.Gb_No_Venta.TabIndex = 34;
            this.Gb_No_Venta.TabStop = false;
            this.Gb_No_Venta.Text = "Venta";
            // 
            // LblNumventa
            // 
            this.LblNumventa.AutoSize = true;
            this.LblNumventa.Location = new System.Drawing.Point(172, 37);
            this.LblNumventa.Name = "LblNumventa";
            this.LblNumventa.Size = new System.Drawing.Size(80, 20);
            this.LblNumventa.TabIndex = 1;
            this.LblNumventa.Text = "No. Venta";
            // 
            // Rbtn_venta
            // 
            this.Rbtn_venta.AutoSize = true;
            this.Rbtn_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_venta.Location = new System.Drawing.Point(14, 28);
            this.Rbtn_venta.Name = "Rbtn_venta";
            this.Rbtn_venta.Size = new System.Drawing.Size(115, 36);
            this.Rbtn_venta.TabIndex = 8;
            this.Rbtn_venta.TabStop = true;
            this.Rbtn_venta.Text = "Venta";
            this.Rbtn_venta.UseVisualStyleBackColor = true;
            this.Rbtn_venta.CheckedChanged += new System.EventHandler(this.Rbtn_venta_CheckedChanged);
            // 
            // TxtVenta
            // 
            this.TxtVenta.Location = new System.Drawing.Point(258, 34);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(169, 26);
            this.TxtVenta.TabIndex = 0;
            this.TxtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVenta_KeyPress);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Buscar.Location = new System.Drawing.Point(18, 208);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(262, 45);
            this.Btn_Buscar.TabIndex = 40;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txtintervalo
            // 
            this.txtintervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtintervalo.Location = new System.Drawing.Point(816, 205);
            this.txtintervalo.Name = "txtintervalo";
            this.txtintervalo.Size = new System.Drawing.Size(58, 39);
            this.txtintervalo.TabIndex = 37;
            this.txtintervalo.Text = "0";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(880, 208);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(39, 32);
            this.LblCantidad.TabIndex = 36;
            this.LblCantidad.Text = "/0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 485);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = global::Ferreteria.Properties.Resources.transfer2;
            this.btn_siguiente.Location = new System.Drawing.Point(702, 195);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(108, 58);
            this.btn_siguiente.TabIndex = 39;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_anteriro_Click);
            // 
            // Btn_anteriro
            // 
            this.Btn_anteriro.Image = global::Ferreteria.Properties.Resources.right;
            this.Btn_anteriro.Location = new System.Drawing.Point(930, 195);
            this.Btn_anteriro.Name = "Btn_anteriro";
            this.Btn_anteriro.Size = new System.Drawing.Size(108, 58);
            this.Btn_anteriro.TabIndex = 38;
            this.Btn_anteriro.UseVisualStyleBackColor = true;
            this.Btn_anteriro.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // Frm_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 768);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.Btn_anteriro);
            this.Controls.Add(this.txtintervalo);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gb_No_Venta);
            this.Controls.Add(this.GrBx_Fecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Frm_Devolucion_Load);
            this.GrBx_Fecha.ResumeLayout(false);
            this.GrBx_Fecha.PerformLayout();
            this.Gb_No_Venta.ResumeLayout(false);
            this.Gb_No_Venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBx_Fecha;
        private System.Windows.Forms.DateTimePicker Dtpfechinicio;
        private System.Windows.Forms.Label Lbl_fechinicio;
        private System.Windows.Forms.GroupBox Gb_No_Venta;
        private System.Windows.Forms.Label LblNumventa;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button Btn_anteriro;
        private System.Windows.Forms.TextBox txtintervalo;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Rbtn_fecha;
        private System.Windows.Forms.RadioButton Rbtn_venta;
    }
}
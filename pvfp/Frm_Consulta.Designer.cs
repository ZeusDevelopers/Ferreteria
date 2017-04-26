namespace PVFP
{
    partial class Frm_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Consulta));
            this.Dtpfechinicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechinicio = new System.Windows.Forms.Label();
            this.LblFechFin = new System.Windows.Forms.Label();
            this.DtpFechafianl = new System.Windows.Forms.DateTimePicker();
            this.GrBx_Fecha = new System.Windows.Forms.GroupBox();
            this.chckfecha = new System.Windows.Forms.CheckBox();
            this.RadBtn_fechintervalo = new System.Windows.Forms.RadioButton();
            this.RadBtn_fechaini = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.txtintervalo = new System.Windows.Forms.TextBox();
            this.Btn_anteriro = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Gb_No_Venta = new System.Windows.Forms.GroupBox();
            this.chckventa = new System.Windows.Forms.CheckBox();
            this.LblNumventa = new System.Windows.Forms.Label();
            this.TxtVenta = new System.Windows.Forms.TextBox();
            this.gbempleado = new System.Windows.Forms.GroupBox();
            this.Cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.chck_empleado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo_form = new System.Windows.Forms.Button();
            this.GrBx_Fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gb_No_Venta.SuspendLayout();
            this.gbempleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtpfechinicio
            // 
            this.Dtpfechinicio.Location = new System.Drawing.Point(400, 22);
            this.Dtpfechinicio.Name = "Dtpfechinicio";
            this.Dtpfechinicio.Size = new System.Drawing.Size(294, 26);
            this.Dtpfechinicio.TabIndex = 0;
            // 
            // Lbl_fechinicio
            // 
            this.Lbl_fechinicio.AutoSize = true;
            this.Lbl_fechinicio.Location = new System.Drawing.Point(300, 24);
            this.Lbl_fechinicio.Name = "Lbl_fechinicio";
            this.Lbl_fechinicio.Size = new System.Drawing.Size(95, 20);
            this.Lbl_fechinicio.TabIndex = 1;
            this.Lbl_fechinicio.Text = "Fecha Inicio";
            // 
            // LblFechFin
            // 
            this.LblFechFin.AutoSize = true;
            this.LblFechFin.Location = new System.Drawing.Point(303, 61);
            this.LblFechFin.Name = "LblFechFin";
            this.LblFechFin.Size = new System.Drawing.Size(92, 20);
            this.LblFechFin.TabIndex = 3;
            this.LblFechFin.Text = "Fecha Final";
            this.LblFechFin.Visible = false;
            // 
            // DtpFechafianl
            // 
            this.DtpFechafianl.Location = new System.Drawing.Point(400, 59);
            this.DtpFechafianl.Name = "DtpFechafianl";
            this.DtpFechafianl.Size = new System.Drawing.Size(294, 26);
            this.DtpFechafianl.TabIndex = 2;
            this.DtpFechafianl.Visible = false;
            this.DtpFechafianl.ValueChanged += new System.EventHandler(this.DtpFechafianl_ValueChanged);
            // 
            // GrBx_Fecha
            // 
            this.GrBx_Fecha.Controls.Add(this.chckfecha);
            this.GrBx_Fecha.Controls.Add(this.RadBtn_fechintervalo);
            this.GrBx_Fecha.Controls.Add(this.RadBtn_fechaini);
            this.GrBx_Fecha.Controls.Add(this.Dtpfechinicio);
            this.GrBx_Fecha.Controls.Add(this.Lbl_fechinicio);
            this.GrBx_Fecha.Controls.Add(this.LblFechFin);
            this.GrBx_Fecha.Controls.Add(this.DtpFechafianl);
            this.GrBx_Fecha.Location = new System.Drawing.Point(18, 21);
            this.GrBx_Fecha.Name = "GrBx_Fecha";
            this.GrBx_Fecha.Size = new System.Drawing.Size(1026, 102);
            this.GrBx_Fecha.TabIndex = 5;
            this.GrBx_Fecha.TabStop = false;
            this.GrBx_Fecha.Text = "Fecha";
            // 
            // chckfecha
            // 
            this.chckfecha.AutoSize = true;
            this.chckfecha.Location = new System.Drawing.Point(6, 36);
            this.chckfecha.Name = "chckfecha";
            this.chckfecha.Size = new System.Drawing.Size(80, 24);
            this.chckfecha.TabIndex = 6;
            this.chckfecha.Text = "Fecha";
            this.chckfecha.UseVisualStyleBackColor = true;
            this.chckfecha.CheckedChanged += new System.EventHandler(this.chckfecha_CheckedChanged);
            // 
            // RadBtn_fechintervalo
            // 
            this.RadBtn_fechintervalo.AutoSize = true;
            this.RadBtn_fechintervalo.Location = new System.Drawing.Point(140, 55);
            this.RadBtn_fechintervalo.Name = "RadBtn_fechintervalo";
            this.RadBtn_fechintervalo.Size = new System.Drawing.Size(144, 24);
            this.RadBtn_fechintervalo.TabIndex = 5;
            this.RadBtn_fechintervalo.Text = "Fecha Intervalo";
            this.RadBtn_fechintervalo.UseVisualStyleBackColor = true;
            this.RadBtn_fechintervalo.CheckedChanged += new System.EventHandler(this.RadBtn_fechintervalo_CheckedChanged);
            // 
            // RadBtn_fechaini
            // 
            this.RadBtn_fechaini.AutoSize = true;
            this.RadBtn_fechaini.Checked = true;
            this.RadBtn_fechaini.Location = new System.Drawing.Point(140, 25);
            this.RadBtn_fechaini.Name = "RadBtn_fechaini";
            this.RadBtn_fechaini.Size = new System.Drawing.Size(124, 24);
            this.RadBtn_fechaini.TabIndex = 4;
            this.RadBtn_fechaini.TabStop = true;
            this.RadBtn_fechaini.Text = "Fecha Unica";
            this.RadBtn_fechaini.UseVisualStyleBackColor = true;
            this.RadBtn_fechaini.CheckedChanged += new System.EventHandler(this.RadBtn_fechaini_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 484);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(801, 272);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(33, 29);
            this.LblCantidad.TabIndex = 8;
            this.LblCantidad.Text = "/0";
            // 
            // txtintervalo
            // 
            this.txtintervalo.Location = new System.Drawing.Point(737, 271);
            this.txtintervalo.Name = "txtintervalo";
            this.txtintervalo.Size = new System.Drawing.Size(58, 26);
            this.txtintervalo.TabIndex = 9;
            this.txtintervalo.Text = "0";
            // 
            // Btn_anteriro
            // 
            this.Btn_anteriro.Location = new System.Drawing.Point(853, 266);
            this.Btn_anteriro.Name = "Btn_anteriro";
            this.Btn_anteriro.Size = new System.Drawing.Size(75, 36);
            this.Btn_anteriro.TabIndex = 10;
            this.Btn_anteriro.Text = ">";
            this.Btn_anteriro.UseVisualStyleBackColor = true;
            this.Btn_anteriro.Click += new System.EventHandler(this.Btn_anteriro_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(656, 266);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 36);
            this.btn_siguiente.TabIndex = 11;
            this.btn_siguiente.Text = "<";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Buscar.Location = new System.Drawing.Point(18, 257);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(262, 44);
            this.Btn_Buscar.TabIndex = 32;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Gb_No_Venta
            // 
            this.Gb_No_Venta.Controls.Add(this.chckventa);
            this.Gb_No_Venta.Controls.Add(this.LblNumventa);
            this.Gb_No_Venta.Controls.Add(this.TxtVenta);
            this.Gb_No_Venta.Location = new System.Drawing.Point(18, 133);
            this.Gb_No_Venta.Name = "Gb_No_Venta";
            this.Gb_No_Venta.Size = new System.Drawing.Size(437, 78);
            this.Gb_No_Venta.TabIndex = 33;
            this.Gb_No_Venta.TabStop = false;
            this.Gb_No_Venta.Text = "Venta";
            // 
            // chckventa
            // 
            this.chckventa.AutoSize = true;
            this.chckventa.Location = new System.Drawing.Point(6, 27);
            this.chckventa.Name = "chckventa";
            this.chckventa.Size = new System.Drawing.Size(78, 24);
            this.chckventa.TabIndex = 7;
            this.chckventa.Text = "Venta";
            this.chckventa.UseVisualStyleBackColor = true;
            this.chckventa.CheckedChanged += new System.EventHandler(this.chckventa_CheckedChanged);
            // 
            // LblNumventa
            // 
            this.LblNumventa.AutoSize = true;
            this.LblNumventa.Location = new System.Drawing.Point(136, 27);
            this.LblNumventa.Name = "LblNumventa";
            this.LblNumventa.Size = new System.Drawing.Size(80, 20);
            this.LblNumventa.TabIndex = 1;
            this.LblNumventa.Text = "No. Venta";
            // 
            // TxtVenta
            // 
            this.TxtVenta.Location = new System.Drawing.Point(222, 24);
            this.TxtVenta.Name = "TxtVenta";
            this.TxtVenta.Size = new System.Drawing.Size(169, 26);
            this.TxtVenta.TabIndex = 0;
            // 
            // gbempleado
            // 
            this.gbempleado.Controls.Add(this.Cmb_Empleado);
            this.gbempleado.Controls.Add(this.chck_empleado);
            this.gbempleado.Controls.Add(this.label1);
            this.gbempleado.Location = new System.Drawing.Point(491, 133);
            this.gbempleado.Name = "gbempleado";
            this.gbempleado.Size = new System.Drawing.Size(437, 78);
            this.gbempleado.TabIndex = 34;
            this.gbempleado.TabStop = false;
            this.gbempleado.Text = "Empleado";
            // 
            // Cmb_Empleado
            // 
            this.Cmb_Empleado.FormattingEnabled = true;
            this.Cmb_Empleado.Location = new System.Drawing.Point(202, 28);
            this.Cmb_Empleado.Name = "Cmb_Empleado";
            this.Cmb_Empleado.Size = new System.Drawing.Size(211, 28);
            this.Cmb_Empleado.TabIndex = 8;
            // 
            // chck_empleado
            // 
            this.chck_empleado.AutoSize = true;
            this.chck_empleado.Location = new System.Drawing.Point(6, 27);
            this.chck_empleado.Name = "chck_empleado";
            this.chck_empleado.Size = new System.Drawing.Size(107, 24);
            this.chck_empleado.TabIndex = 7;
            this.chck_empleado.Text = "Empleado";
            this.chck_empleado.UseVisualStyleBackColor = true;
            this.chck_empleado.CheckedChanged += new System.EventHandler(this.chck_empleado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado";
            // 
            // btn_nuevo_form
            // 
            this.btn_nuevo_form.Image = global::Ferreteria.Properties.Resources.text3;
            this.btn_nuevo_form.Location = new System.Drawing.Point(934, 144);
            this.btn_nuevo_form.Name = "btn_nuevo_form";
            this.btn_nuevo_form.Size = new System.Drawing.Size(110, 81);
            this.btn_nuevo_form.TabIndex = 35;
            this.btn_nuevo_form.Text = "Ventas";
            this.btn_nuevo_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_form.UseVisualStyleBackColor = true;
            this.btn_nuevo_form.Click += new System.EventHandler(this.btn_nuevo_form_Click);
            // 
            // Frm_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 796);
            this.Controls.Add(this.btn_nuevo_form);
            this.Controls.Add(this.gbempleado);
            this.Controls.Add(this.Gb_No_Venta);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.Btn_anteriro);
            this.Controls.Add(this.txtintervalo);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrBx_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Consulta";
            this.Text = "Consulta-Ticket";
            this.Load += new System.EventHandler(this.Frm_Consulta_Load);
            this.GrBx_Fecha.ResumeLayout(false);
            this.GrBx_Fecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gb_No_Venta.ResumeLayout(false);
            this.Gb_No_Venta.PerformLayout();
            this.gbempleado.ResumeLayout(false);
            this.gbempleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtpfechinicio;
        private System.Windows.Forms.Label Lbl_fechinicio;
        private System.Windows.Forms.Label LblFechFin;
        private System.Windows.Forms.DateTimePicker DtpFechafianl;
        private System.Windows.Forms.GroupBox GrBx_Fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox txtintervalo;
        private System.Windows.Forms.Button Btn_anteriro;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.RadioButton RadBtn_fechintervalo;
        private System.Windows.Forms.RadioButton RadBtn_fechaini;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.CheckBox chckfecha;
        private System.Windows.Forms.GroupBox Gb_No_Venta;
        private System.Windows.Forms.CheckBox chckventa;
        private System.Windows.Forms.Label LblNumventa;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.GroupBox gbempleado;
        private System.Windows.Forms.CheckBox chck_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Empleado;
        private System.Windows.Forms.Button btn_nuevo_form;
    }
}
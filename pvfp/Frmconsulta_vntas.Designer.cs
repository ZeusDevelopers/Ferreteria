namespace Ferreteria
{
    partial class Frmconsulta_vntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmconsulta_vntas));
            this.GrBx_Fecha = new System.Windows.Forms.GroupBox();
            this.RadBtn_fechintervalo = new System.Windows.Forms.RadioButton();
            this.RadBtn_fechaini = new System.Windows.Forms.RadioButton();
            this.Dtpfechinicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechinicio = new System.Windows.Forms.Label();
            this.LblFechFin = new System.Windows.Forms.Label();
            this.DtpFechafianl = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbreporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBltipo = new System.Windows.Forms.Label();
            this.Lblresul = new System.Windows.Forms.Label();
            this.GrBx_Fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBx_Fecha
            // 
            this.GrBx_Fecha.Controls.Add(this.RadBtn_fechintervalo);
            this.GrBx_Fecha.Controls.Add(this.RadBtn_fechaini);
            this.GrBx_Fecha.Controls.Add(this.Dtpfechinicio);
            this.GrBx_Fecha.Controls.Add(this.Lbl_fechinicio);
            this.GrBx_Fecha.Controls.Add(this.LblFechFin);
            this.GrBx_Fecha.Controls.Add(this.DtpFechafianl);
            this.GrBx_Fecha.Location = new System.Drawing.Point(12, 95);
            this.GrBx_Fecha.Name = "GrBx_Fecha";
            this.GrBx_Fecha.Size = new System.Drawing.Size(924, 102);
            this.GrBx_Fecha.TabIndex = 6;
            this.GrBx_Fecha.TabStop = false;
            this.GrBx_Fecha.Text = "Fecha";
            // 
            // RadBtn_fechintervalo
            // 
            this.RadBtn_fechintervalo.AutoSize = true;
            this.RadBtn_fechintervalo.Location = new System.Drawing.Point(14, 56);
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
            this.RadBtn_fechaini.Location = new System.Drawing.Point(14, 26);
            this.RadBtn_fechaini.Name = "RadBtn_fechaini";
            this.RadBtn_fechaini.Size = new System.Drawing.Size(124, 24);
            this.RadBtn_fechaini.TabIndex = 4;
            this.RadBtn_fechaini.TabStop = true;
            this.RadBtn_fechaini.Text = "Fecha Unica";
            this.RadBtn_fechaini.UseVisualStyleBackColor = true;
            this.RadBtn_fechaini.CheckedChanged += new System.EventHandler(this.RadBtn_fechaini_CheckedChanged);
            // 
            // Dtpfechinicio
            // 
            this.Dtpfechinicio.Location = new System.Drawing.Point(274, 23);
            this.Dtpfechinicio.Name = "Dtpfechinicio";
            this.Dtpfechinicio.Size = new System.Drawing.Size(294, 26);
            this.Dtpfechinicio.TabIndex = 0;
            // 
            // Lbl_fechinicio
            // 
            this.Lbl_fechinicio.AutoSize = true;
            this.Lbl_fechinicio.Location = new System.Drawing.Point(174, 25);
            this.Lbl_fechinicio.Name = "Lbl_fechinicio";
            this.Lbl_fechinicio.Size = new System.Drawing.Size(95, 20);
            this.Lbl_fechinicio.TabIndex = 1;
            this.Lbl_fechinicio.Text = "Fecha Inicio";
            // 
            // LblFechFin
            // 
            this.LblFechFin.AutoSize = true;
            this.LblFechFin.Location = new System.Drawing.Point(177, 62);
            this.LblFechFin.Name = "LblFechFin";
            this.LblFechFin.Size = new System.Drawing.Size(92, 20);
            this.LblFechFin.TabIndex = 3;
            this.LblFechFin.Text = "Fecha Final";
            this.LblFechFin.Visible = false;
            // 
            // DtpFechafianl
            // 
            this.DtpFechafianl.Location = new System.Drawing.Point(274, 60);
            this.DtpFechafianl.Name = "DtpFechafianl";
            this.DtpFechafianl.Size = new System.Drawing.Size(294, 26);
            this.DtpFechafianl.TabIndex = 2;
            this.DtpFechafianl.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbreporte
            // 
            this.cmbreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbreporte.FormattingEnabled = true;
            this.cmbreporte.Items.AddRange(new object[] {
            "Impuestos",
            "Ganancia"});
            this.cmbreporte.Location = new System.Drawing.Point(184, 30);
            this.cmbreporte.Name = "cmbreporte";
            this.cmbreporte.Size = new System.Drawing.Size(371, 45);
            this.cmbreporte.TabIndex = 8;
            this.cmbreporte.SelectedIndexChanged += new System.EventHandler(this.cmbreporte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reporte";
            // 
            // LBltipo
            // 
            this.LBltipo.AutoSize = true;
            this.LBltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBltipo.Location = new System.Drawing.Point(331, 225);
            this.LBltipo.Name = "LBltipo";
            this.LBltipo.Size = new System.Drawing.Size(146, 37);
            this.LBltipo.TabIndex = 10;
            this.LBltipo.Text = "Reporte:";
            this.LBltipo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lblresul
            // 
            this.Lblresul.AutoSize = true;
            this.Lblresul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblresul.Location = new System.Drawing.Point(507, 225);
            this.Lblresul.Name = "Lblresul";
            this.Lblresul.Size = new System.Drawing.Size(36, 37);
            this.Lblresul.TabIndex = 11;
            this.Lblresul.Text = "0";
            // 
            // Frmconsulta_vntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 303);
            this.Controls.Add(this.Lblresul);
            this.Controls.Add(this.LBltipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbreporte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrBx_Fecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmconsulta_vntas";
            this.Text = "Ventas";
            this.GrBx_Fecha.ResumeLayout(false);
            this.GrBx_Fecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBx_Fecha;
        private System.Windows.Forms.RadioButton RadBtn_fechintervalo;
        private System.Windows.Forms.RadioButton RadBtn_fechaini;
        private System.Windows.Forms.DateTimePicker Dtpfechinicio;
        private System.Windows.Forms.Label Lbl_fechinicio;
        private System.Windows.Forms.Label LblFechFin;
        private System.Windows.Forms.DateTimePicker DtpFechafianl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbreporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBltipo;
        private System.Windows.Forms.Label Lblresul;
    }
}
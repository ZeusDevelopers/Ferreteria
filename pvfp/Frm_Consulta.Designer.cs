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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechinicio = new System.Windows.Forms.Label();
            this.LblFechFin = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.GrBx_Fecha = new System.Windows.Forms.GroupBox();
            this.Chck_fecha = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_anteriro = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.GrBx_Fecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Lbl_fechinicio
            // 
            this.Lbl_fechinicio.AutoSize = true;
            this.Lbl_fechinicio.Location = new System.Drawing.Point(175, 27);
            this.Lbl_fechinicio.Name = "Lbl_fechinicio";
            this.Lbl_fechinicio.Size = new System.Drawing.Size(95, 20);
            this.Lbl_fechinicio.TabIndex = 1;
            this.Lbl_fechinicio.Text = "Fecha Inicio";
            // 
            // LblFechFin
            // 
            this.LblFechFin.AutoSize = true;
            this.LblFechFin.Location = new System.Drawing.Point(588, 29);
            this.LblFechFin.Name = "LblFechFin";
            this.LblFechFin.Size = new System.Drawing.Size(92, 20);
            this.LblFechFin.TabIndex = 3;
            this.LblFechFin.Text = "Fecha Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(685, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Articulo";
            // 
            // GrBx_Fecha
            // 
            this.GrBx_Fecha.Controls.Add(this.Chck_fecha);
            this.GrBx_Fecha.Controls.Add(this.dateTimePicker1);
            this.GrBx_Fecha.Controls.Add(this.Lbl_fechinicio);
            this.GrBx_Fecha.Controls.Add(this.LblFechFin);
            this.GrBx_Fecha.Controls.Add(this.dateTimePicker2);
            this.GrBx_Fecha.Location = new System.Drawing.Point(53, 31);
            this.GrBx_Fecha.Name = "GrBx_Fecha";
            this.GrBx_Fecha.Size = new System.Drawing.Size(1026, 68);
            this.GrBx_Fecha.TabIndex = 5;
            this.GrBx_Fecha.TabStop = false;
            this.GrBx_Fecha.Text = "Fecha";
            // 
            // Chck_fecha
            // 
            this.Chck_fecha.AutoSize = true;
            this.Chck_fecha.Location = new System.Drawing.Point(15, 29);
            this.Chck_fecha.Name = "Chck_fecha";
            this.Chck_fecha.Size = new System.Drawing.Size(80, 24);
            this.Chck_fecha.TabIndex = 4;
            this.Chck_fecha.Text = "Fecha";
            this.Chck_fecha.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 484);
            this.dataGridView1.TabIndex = 7;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(836, 264);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(46, 29);
            this.LblCantidad.TabIndex = 8;
            this.LblCantidad.Text = "/10";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(772, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // Btn_anteriro
            // 
            this.Btn_anteriro.Location = new System.Drawing.Point(888, 258);
            this.Btn_anteriro.Name = "Btn_anteriro";
            this.Btn_anteriro.Size = new System.Drawing.Size(75, 36);
            this.Btn_anteriro.TabIndex = 10;
            this.Btn_anteriro.Text = ">";
            this.Btn_anteriro.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(691, 258);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(75, 36);
            this.btn_siguiente.TabIndex = 11;
            this.btn_siguiente.Text = "<";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // Frm_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 796);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.Btn_anteriro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrBx_Fecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Consulta";
            this.Text = "Consulta";
            this.GrBx_Fecha.ResumeLayout(false);
            this.GrBx_Fecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_fechinicio;
        private System.Windows.Forms.Label LblFechFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBx_Fecha;
        private System.Windows.Forms.CheckBox Chck_fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_anteriro;
        private System.Windows.Forms.Button btn_siguiente;
    }
}
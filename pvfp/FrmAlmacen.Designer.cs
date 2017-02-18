namespace PVFP
{
    partial class FrmAlmacen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnapiso = new System.Windows.Forms.Button();
            this.txtcantidadapiso = new System.Windows.Forms.TextBox();
            this.cmbapiso = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaalmacen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbaalmacen = new System.Windows.Forms.ComboBox();
            this.txtcantidadaalmacen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Piso,
            this.EnAlmacen});
            this.dataGridView1.Location = new System.Drawing.Point(410, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 582);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Piso
            // 
            this.Piso.HeaderText = "En Piso";
            this.Piso.Name = "Piso";
            // 
            // EnAlmacen
            // 
            this.EnAlmacen.HeaderText = "En Almacen";
            this.EnAlmacen.Name = "EnAlmacen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnapiso);
            this.groupBox1.Controls.Add(this.txtcantidadapiso);
            this.groupBox1.Controls.Add(this.cmbapiso);
            this.groupBox1.Location = new System.Drawing.Point(32, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(333, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De almacen a piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // btnapiso
            // 
            this.btnapiso.Location = new System.Drawing.Point(157, 140);
            this.btnapiso.Margin = new System.Windows.Forms.Padding(5);
            this.btnapiso.Name = "btnapiso";
            this.btnapiso.Size = new System.Drawing.Size(125, 39);
            this.btnapiso.TabIndex = 2;
            this.btnapiso.Text = "Enviar";
            this.btnapiso.UseVisualStyleBackColor = true;
            this.btnapiso.Click += new System.EventHandler(this.btnapiso_Click);
            // 
            // txtcantidadapiso
            // 
            this.txtcantidadapiso.Location = new System.Drawing.Point(122, 96);
            this.txtcantidadapiso.Margin = new System.Windows.Forms.Padding(5);
            this.txtcantidadapiso.Name = "txtcantidadapiso";
            this.txtcantidadapiso.Size = new System.Drawing.Size(199, 40);
            this.txtcantidadapiso.TabIndex = 2;
            // 
            // cmbapiso
            // 
            this.cmbapiso.FormattingEnabled = true;
            this.cmbapiso.Location = new System.Drawing.Point(122, 51);
            this.cmbapiso.Margin = new System.Windows.Forms.Padding(5);
            this.cmbapiso.Name = "cmbapiso";
            this.cmbapiso.Size = new System.Drawing.Size(199, 40);
            this.cmbapiso.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnaalmacen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbaalmacen);
            this.groupBox2.Controls.Add(this.txtcantidadaalmacen);
            this.groupBox2.Location = new System.Drawing.Point(32, 301);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(333, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "De piso a almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto:";
            // 
            // btnaalmacen
            // 
            this.btnaalmacen.Location = new System.Drawing.Point(157, 122);
            this.btnaalmacen.Margin = new System.Windows.Forms.Padding(5);
            this.btnaalmacen.Name = "btnaalmacen";
            this.btnaalmacen.Size = new System.Drawing.Size(125, 39);
            this.btnaalmacen.TabIndex = 3;
            this.btnaalmacen.Text = "Enviar";
            this.btnaalmacen.UseVisualStyleBackColor = true;
            this.btnaalmacen.Click += new System.EventHandler(this.btnaalmacen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // cmbaalmacen
            // 
            this.cmbaalmacen.FormattingEnabled = true;
            this.cmbaalmacen.Location = new System.Drawing.Point(122, 32);
            this.cmbaalmacen.Margin = new System.Windows.Forms.Padding(5);
            this.cmbaalmacen.Name = "cmbaalmacen";
            this.cmbaalmacen.Size = new System.Drawing.Size(199, 40);
            this.cmbaalmacen.TabIndex = 5;
            // 
            // txtcantidadaalmacen
            // 
            this.txtcantidadaalmacen.Location = new System.Drawing.Point(122, 78);
            this.txtcantidadaalmacen.Margin = new System.Windows.Forms.Padding(5);
            this.txtcantidadaalmacen.Name = "txtcantidadaalmacen";
            this.txtcantidadaalmacen.Size = new System.Drawing.Size(199, 40);
            this.txtcantidadaalmacen.TabIndex = 4;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAlmacen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.FrmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnAlmacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnapiso;
        private System.Windows.Forms.TextBox txtcantidadapiso;
        private System.Windows.Forms.ComboBox cmbapiso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaalmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbaalmacen;
        private System.Windows.Forms.TextBox txtcantidadaalmacen;
    }
}
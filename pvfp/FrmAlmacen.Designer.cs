﻿namespace PVFP
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
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 344);
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
            this.groupBox1.Location = new System.Drawing.Point(58, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De almacen a piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // btnapiso
            // 
            this.btnapiso.Location = new System.Drawing.Point(94, 83);
            this.btnapiso.Name = "btnapiso";
            this.btnapiso.Size = new System.Drawing.Size(75, 23);
            this.btnapiso.TabIndex = 2;
            this.btnapiso.Text = "Enviar";
            this.btnapiso.UseVisualStyleBackColor = true;
            this.btnapiso.Click += new System.EventHandler(this.btnapiso_Click);
            // 
            // txtcantidadapiso
            // 
            this.txtcantidadapiso.Location = new System.Drawing.Point(73, 57);
            this.txtcantidadapiso.Name = "txtcantidadapiso";
            this.txtcantidadapiso.Size = new System.Drawing.Size(121, 20);
            this.txtcantidadapiso.TabIndex = 2;
            // 
            // cmbapiso
            // 
            this.cmbapiso.FormattingEnabled = true;
            this.cmbapiso.Location = new System.Drawing.Point(73, 30);
            this.cmbapiso.Name = "cmbapiso";
            this.cmbapiso.Size = new System.Drawing.Size(121, 21);
            this.cmbapiso.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnaalmacen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbaalmacen);
            this.groupBox2.Controls.Add(this.txtcantidadaalmacen);
            this.groupBox2.Location = new System.Drawing.Point(58, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "De piso a almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto:";
            // 
            // btnaalmacen
            // 
            this.btnaalmacen.Location = new System.Drawing.Point(94, 72);
            this.btnaalmacen.Name = "btnaalmacen";
            this.btnaalmacen.Size = new System.Drawing.Size(75, 23);
            this.btnaalmacen.TabIndex = 3;
            this.btnaalmacen.Text = "Enviar";
            this.btnaalmacen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // cmbaalmacen
            // 
            this.cmbaalmacen.FormattingEnabled = true;
            this.cmbaalmacen.Location = new System.Drawing.Point(73, 19);
            this.cmbaalmacen.Name = "cmbaalmacen";
            this.cmbaalmacen.Size = new System.Drawing.Size(121, 21);
            this.cmbaalmacen.TabIndex = 5;
            // 
            // txtcantidadaalmacen
            // 
            this.txtcantidadaalmacen.Location = new System.Drawing.Point(73, 46);
            this.txtcantidadaalmacen.Name = "txtcantidadaalmacen";
            this.txtcantidadaalmacen.Size = new System.Drawing.Size(121, 20);
            this.txtcantidadaalmacen.TabIndex = 4;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
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
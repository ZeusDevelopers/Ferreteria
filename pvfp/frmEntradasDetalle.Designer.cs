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
            this.btnCalTotProd = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnCalTotProd
            // 
            this.btnCalTotProd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalTotProd.Location = new System.Drawing.Point(56, 191);
            this.btnCalTotProd.Name = "btnCalTotProd";
            this.btnCalTotProd.Size = new System.Drawing.Size(131, 53);
            this.btnCalTotProd.TabIndex = 27;
            this.btnCalTotProd.Text = "Calcular total Producto";
            this.btnCalTotProd.UseVisualStyleBackColor = true;
            this.btnCalTotProd.Click += new System.EventHandler(this.btnCalTotProd_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(266, 204);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(98, 53);
            this.btnTerminar.TabIndex = 26;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // btnAgrPG
            // 
            this.btnAgrPG.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrPG.Location = new System.Drawing.Point(266, 103);
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
            this.lblTotProd.Location = new System.Drawing.Point(50, 261);
            this.lblTotProd.Name = "lblTotProd";
            this.lblTotProd.Size = new System.Drawing.Size(121, 22);
            this.lblTotProd.TabIndex = 24;
            this.lblTotProd.Text = "Total Producto";
            this.lblTotProd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Costo Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad";
            // 
            // txtTotalProducto
            // 
            this.txtTotalProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProducto.Location = new System.Drawing.Point(54, 286);
            this.txtTotalProducto.Name = "txtTotalProducto";
            this.txtTotalProducto.ReadOnly = true;
            this.txtTotalProducto.Size = new System.Drawing.Size(124, 29);
            this.txtTotalProducto.TabIndex = 21;
            this.txtTotalProducto.Visible = false;
            // 
            // txtCostoUnit
            // 
            this.txtCostoUnit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnit.Location = new System.Drawing.Point(56, 142);
            this.txtCostoUnit.Name = "txtCostoUnit";
            this.txtCostoUnit.Size = new System.Drawing.Size(100, 29);
            this.txtCostoUnit.TabIndex = 20;
            this.txtCostoUnit.Text = "0";
            this.txtCostoUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnit_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(56, 83);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 29);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Text = "0";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(144, 24);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(247, 30);
            this.cmbProducto.TabIndex = 17;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.Click += new System.EventHandler(this.cmbProducto_Click);
            // 
            // frmEntradasDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 355);
            this.Controls.Add(this.btnCalTotProd);
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
            this.Name = "frmEntradasDetalle";
            this.Text = "frmEntradasDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalTotProd;
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
    }
}
namespace PVFP
{
    partial class frmEnAltProd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbxTipoCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecioMayore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.cmbxUM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Txtcodigobarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioMayoreo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(28, 8, 0, 8);
            this.menuStrip1.Size = new System.Drawing.Size(697, 42);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(33, 26);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // cmbxTipoCargo
            // 
            this.cmbxTipoCargo.FormattingEnabled = true;
            this.cmbxTipoCargo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxTipoCargo.Location = new System.Drawing.Point(143, 253);
            this.cmbxTipoCargo.Name = "cmbxTipoCargo";
            this.cmbxTipoCargo.Size = new System.Drawing.Size(181, 30);
            this.cmbxTipoCargo.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(43, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 99;
            this.label8.Text = "Tipo Cargo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(380, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 22);
            this.label20.TabIndex = 98;
            this.label20.Text = "Precio Mayoreo";
            // 
            // txtPrecioMayore
            // 
            this.txtPrecioMayore.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioMayore.Location = new System.Drawing.Point(516, 201);
            this.txtPrecioMayore.Name = "txtPrecioMayore";
            this.txtPrecioMayore.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioMayore.TabIndex = 90;
            this.txtPrecioMayore.Text = "0";
            this.txtPrecioMayore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMayore_KeyPress);
            this.txtPrecioMayore.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioMayore_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(402, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 97;
            this.label4.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioVenta.Location = new System.Drawing.Point(516, 114);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioVenta.TabIndex = 89;
            this.txtPrecioVenta.Text = "0";
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_KeyUp);
            // 
            // cmbxUM
            // 
            this.cmbxUM.FormattingEnabled = true;
            this.cmbxUM.Items.AddRange(new object[] {
            "Por Unidad/Pza",
            "A Granel (Usa Decimal)",
            "Como Paquete (Kit)",
            "Metro"});
            this.cmbxUM.Location = new System.Drawing.Point(143, 209);
            this.cmbxUM.Name = "cmbxUM";
            this.cmbxUM.Size = new System.Drawing.Size(181, 30);
            this.cmbxUM.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 96;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtNombre.Location = new System.Drawing.Point(143, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 27);
            this.txtNombre.TabIndex = 85;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.ImageIndex = 0;
            this.BtnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuardar.Location = new System.Drawing.Point(446, 327);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 74);
            this.BtnGuardar.TabIndex = 91;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // Txtcodigobarras
            // 
            this.Txtcodigobarras.Font = new System.Drawing.Font("Calibri", 12F);
            this.Txtcodigobarras.Location = new System.Drawing.Point(143, 68);
            this.Txtcodigobarras.Name = "Txtcodigobarras";
            this.Txtcodigobarras.Size = new System.Drawing.Size(254, 27);
            this.Txtcodigobarras.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 93;
            this.label2.Text = "Codigo de Barra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(81, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 95;
            this.label7.Text = "Folio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(59, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 92;
            this.label1.Text = "Se vende";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFolio.Location = new System.Drawing.Point(143, 110);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(152, 27);
            this.txtFolio.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(41, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 94;
            this.label5.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrecioCosto.Location = new System.Drawing.Point(143, 303);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(135, 27);
            this.txtPrecioCosto.TabIndex = 88;
            this.txtPrecioCosto.Text = "0";
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCosto_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lblPrecioVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecioVenta.Location = new System.Drawing.Point(512, 158);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(34, 22);
            this.lblPrecioVenta.TabIndex = 108;
            this.lblPrecioVenta.Text = "$$$";
            // 
            // lblPrecioMayoreo
            // 
            this.lblPrecioMayoreo.AutoSize = true;
            this.lblPrecioMayoreo.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.lblPrecioMayoreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecioMayoreo.Location = new System.Drawing.Point(512, 253);
            this.lblPrecioMayoreo.Name = "lblPrecioMayoreo";
            this.lblPrecioMayoreo.Size = new System.Drawing.Size(34, 22);
            this.lblPrecioMayoreo.TabIndex = 107;
            this.lblPrecioMayoreo.Text = "$$$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(363, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 22);
            this.label18.TabIndex = 106;
            this.label18.Text = "% Ganancia Venta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(340, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 22);
            this.label17.TabIndex = 105;
            this.label17.Text = "% Ganancia Mayoreo";
            // 
            // frmEnAltProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 425);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioMayoreo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbxTipoCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPrecioMayore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.cmbxUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.Txtcodigobarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEnAltProd";
            this.Text = "Dar de alta un producto";
            this.Load += new System.EventHandler(this.frmEnAltProd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbxTipoCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPrecioMayore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ComboBox cmbxUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox Txtcodigobarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioMayoreo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}
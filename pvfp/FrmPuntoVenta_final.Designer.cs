namespace PVFP
{
    partial class FrmPuntoVenta_final
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
            this.Txtdinero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btncombinado = new System.Windows.Forms.Button();
            this.Lblefectivo = new System.Windows.Forms.Label();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.txttarjeta = new System.Windows.Forms.TextBox();
            this.BtnTarjeta = new System.Windows.Forms.Button();
            this.BtnEfectivo = new System.Windows.Forms.Button();
            this.lbldolar = new System.Windows.Forms.Label();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.chck_pagodolar = new System.Windows.Forms.CheckBox();
            this.Gb_Venta = new System.Windows.Forms.GroupBox();
            this.LblTot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lblcam = new System.Windows.Forms.Label();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.LblDolarPrecio = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Lbl_total_dlls = new System.Windows.Forms.Label();
            this.Gb_Venta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txtdinero
            // 
            this.Txtdinero.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txtdinero.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdinero.ForeColor = System.Drawing.Color.Black;
            this.Txtdinero.Location = new System.Drawing.Point(232, 262);
            this.Txtdinero.Name = "Txtdinero";
            this.Txtdinero.Size = new System.Drawing.Size(282, 49);
            this.Txtdinero.TabIndex = 1;
            this.Txtdinero.Visible = false;
            this.Txtdinero.TextChanged += new System.EventHandler(this.Txtdinero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(206, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 60);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forma Pago";
            // 
            // Btncombinado
            // 
            this.Btncombinado.BackColor = System.Drawing.Color.Gainsboro;
            this.Btncombinado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btncombinado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncombinado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btncombinado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btncombinado.Location = new System.Drawing.Point(416, 125);
            this.Btncombinado.Name = "Btncombinado";
            this.Btncombinado.Size = new System.Drawing.Size(155, 105);
            this.Btncombinado.TabIndex = 37;
            this.Btncombinado.Text = "Combinado";
            this.Btncombinado.UseVisualStyleBackColor = false;
            this.Btncombinado.Click += new System.EventHandler(this.Btncombinado_Click);
            // 
            // Lblefectivo
            // 
            this.Lblefectivo.AutoSize = true;
            this.Lblefectivo.BackColor = System.Drawing.Color.Transparent;
            this.Lblefectivo.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.Lblefectivo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lblefectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lblefectivo.Location = new System.Drawing.Point(31, 251);
            this.Lblefectivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lblefectivo.Name = "Lblefectivo";
            this.Lblefectivo.Size = new System.Drawing.Size(196, 60);
            this.Lblefectivo.TabIndex = 38;
            this.Lblefectivo.Text = "Efectivo";
            this.Lblefectivo.Visible = false;
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.LblTarjeta.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.LblTarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTarjeta.Location = new System.Drawing.Point(54, 374);
            this.LblTarjeta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(173, 60);
            this.LblTarjeta.TabIndex = 40;
            this.LblTarjeta.Text = "Tarjeta";
            this.LblTarjeta.Visible = false;
            // 
            // txttarjeta
            // 
            this.txttarjeta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txttarjeta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarjeta.ForeColor = System.Drawing.Color.Black;
            this.txttarjeta.Location = new System.Drawing.Point(232, 386);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(282, 49);
            this.txttarjeta.TabIndex = 4;
            this.txttarjeta.Visible = false;
            this.txttarjeta.TextChanged += new System.EventHandler(this.txttarjeta_TextChanged);
            // 
            // BtnTarjeta
            // 
            this.BtnTarjeta.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTarjeta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjeta.Image = global::PVFP.Properties.Resources.test9;
            this.BtnTarjeta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnTarjeta.Location = new System.Drawing.Point(255, 125);
            this.BtnTarjeta.Name = "BtnTarjeta";
            this.BtnTarjeta.Size = new System.Drawing.Size(155, 105);
            this.BtnTarjeta.TabIndex = 36;
            this.BtnTarjeta.Text = "Tarjeta\r\n\r\n\r\n";
            this.BtnTarjeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTarjeta.UseVisualStyleBackColor = false;
            this.BtnTarjeta.Click += new System.EventHandler(this.BtnTarjeta_Click);
            // 
            // BtnEfectivo
            // 
            this.BtnEfectivo.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEfectivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEfectivo.Image = global::PVFP.Properties.Resources.text3;
            this.BtnEfectivo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEfectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEfectivo.Location = new System.Drawing.Point(94, 125);
            this.BtnEfectivo.Name = "BtnEfectivo";
            this.BtnEfectivo.Size = new System.Drawing.Size(155, 105);
            this.BtnEfectivo.TabIndex = 35;
            this.BtnEfectivo.Text = "Efectivo\r\n";
            this.BtnEfectivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEfectivo.UseVisualStyleBackColor = false;
            this.BtnEfectivo.Click += new System.EventHandler(this.BtnEfectivo_Click);
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.BackColor = System.Drawing.Color.Transparent;
            this.lbldolar.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.lbldolar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldolar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbldolar.Location = new System.Drawing.Point(81, 315);
            this.lbldolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(143, 60);
            this.lbldolar.TabIndex = 42;
            this.lbldolar.Text = "Dolar";
            this.lbldolar.Visible = false;
            // 
            // txtdolar
            // 
            this.txtdolar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtdolar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdolar.ForeColor = System.Drawing.Color.Black;
            this.txtdolar.Location = new System.Drawing.Point(232, 324);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(282, 49);
            this.txtdolar.TabIndex = 3;
            this.txtdolar.Visible = false;
            this.txtdolar.TextChanged += new System.EventHandler(this.txtdolar_TextChanged);
            // 
            // chck_pagodolar
            // 
            this.chck_pagodolar.AutoSize = true;
            this.chck_pagodolar.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_pagodolar.Location = new System.Drawing.Point(520, 274);
            this.chck_pagodolar.Name = "chck_pagodolar";
            this.chck_pagodolar.Size = new System.Drawing.Size(191, 32);
            this.chck_pagodolar.TabIndex = 2;
            this.chck_pagodolar.Text = "Pago con dolar";
            this.chck_pagodolar.UseVisualStyleBackColor = true;
            this.chck_pagodolar.Visible = false;
            this.chck_pagodolar.CheckedChanged += new System.EventHandler(this.chck_pagodolar_CheckedChanged);
            // 
            // Gb_Venta
            // 
            this.Gb_Venta.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Venta.Controls.Add(this.LblTot);
            this.Gb_Venta.Controls.Add(this.label5);
            this.Gb_Venta.Controls.Add(this.label7);
            this.Gb_Venta.Controls.Add(this.Lblcam);
            this.Gb_Venta.Location = new System.Drawing.Point(116, 467);
            this.Gb_Venta.Name = "Gb_Venta";
            this.Gb_Venta.Size = new System.Drawing.Size(494, 203);
            this.Gb_Venta.TabIndex = 43;
            this.Gb_Venta.TabStop = false;
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.BackColor = System.Drawing.Color.Transparent;
            this.LblTot.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.LblTot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTot.Location = new System.Drawing.Point(233, 50);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(136, 65);
            this.LblTot.TabIndex = 28;
            this.LblTot.Text = "$0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(89, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 65);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(29, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 65);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cambio:";
            // 
            // Lblcam
            // 
            this.Lblcam.AutoSize = true;
            this.Lblcam.BackColor = System.Drawing.Color.Transparent;
            this.Lblcam.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Lblcam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lblcam.Location = new System.Drawing.Point(231, 127);
            this.Lblcam.Name = "Lblcam";
            this.Lblcam.Size = new System.Drawing.Size(147, 71);
            this.Lblcam.TabIndex = 30;
            this.Lblcam.Text = "$0.00";
            // 
            // Btn_Pagar
            // 
            this.Btn_Pagar.Enabled = false;
            this.Btn_Pagar.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pagar.Location = new System.Drawing.Point(50, 676);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(227, 53);
            this.Btn_Pagar.TabIndex = 44;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = true;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(283, 676);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(227, 53);
            this.Btn_Cancelar.TabIndex = 45;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // LblDolarPrecio
            // 
            this.LblDolarPrecio.AutoSize = true;
            this.LblDolarPrecio.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarPrecio.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDolarPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDolarPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDolarPrecio.Location = new System.Drawing.Point(615, 125);
            this.LblDolarPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDolarPrecio.Name = "LblDolarPrecio";
            this.LblDolarPrecio.Size = new System.Drawing.Size(229, 74);
            this.LblDolarPrecio.TabIndex = 46;
            this.LblDolarPrecio.Text = "Dolar Bancomer\r\n$ 0.000";
            this.LblDolarPrecio.Visible = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(516, 676);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(227, 53);
            this.btn_Cerrar.TabIndex = 47;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Lbl_total_dlls
            // 
            this.Lbl_total_dlls.AutoSize = true;
            this.Lbl_total_dlls.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_total_dlls.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.Lbl_total_dlls.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_total_dlls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_total_dlls.Location = new System.Drawing.Point(534, 318);
            this.Lbl_total_dlls.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_total_dlls.Name = "Lbl_total_dlls";
            this.Lbl_total_dlls.Size = new System.Drawing.Size(151, 60);
            this.Lbl_total_dlls.TabIndex = 48;
            this.Lbl_total_dlls.Text = "$0.00";
            this.Lbl_total_dlls.Visible = false;
            // 
            // FrmPuntoVenta_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 858);
            this.Controls.Add(this.Lbl_total_dlls);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.LblDolarPrecio);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Pagar);
            this.Controls.Add(this.Gb_Venta);
            this.Controls.Add(this.chck_pagodolar);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.LblTarjeta);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.Lblefectivo);
            this.Controls.Add(this.Btncombinado);
            this.Controls.Add(this.BtnTarjeta);
            this.Controls.Add(this.BtnEfectivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtdinero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPuntoVenta_final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPuntoVenta_final";
            this.Load += new System.EventHandler(this.FrmPuntoVenta_final_Load);
            this.Gb_Venta.ResumeLayout(false);
            this.Gb_Venta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtdinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEfectivo;
        private System.Windows.Forms.Button BtnTarjeta;
        private System.Windows.Forms.Button Btncombinado;
        private System.Windows.Forms.Label Lblefectivo;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.TextBox txttarjeta;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.CheckBox chck_pagodolar;
        private System.Windows.Forms.GroupBox Gb_Venta;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lblcam;
        private System.Windows.Forms.Button Btn_Pagar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label LblDolarPrecio;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label Lbl_total_dlls;
    }
}
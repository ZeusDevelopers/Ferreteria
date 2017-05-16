namespace Ferreteria
{
    partial class FrmPuntoVenta_cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoVenta_cotizacion));
            this.Lbl_codprd = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_codprd
            // 
            this.Lbl_codprd.AutoSize = true;
            this.Lbl_codprd.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_codprd.Font = new System.Drawing.Font("Tw Cen MT", 26F, System.Drawing.FontStyle.Bold);
            this.Lbl_codprd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_codprd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl_codprd.Location = new System.Drawing.Point(14, 41);
            this.Lbl_codprd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_codprd.Name = "Lbl_codprd";
            this.Lbl_codprd.Size = new System.Drawing.Size(167, 60);
            this.Lbl_codprd.TabIndex = 25;
            this.Lbl_codprd.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(189, 59);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(263, 42);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Buscar.Location = new System.Drawing.Point(462, 52);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(255, 62);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptar.Image = global::Ferreteria.Properties.Resources._checked;
            this.Btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_aceptar.Location = new System.Drawing.Point(189, 117);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(236, 48);
            this.Btn_aceptar.TabIndex = 1;
            this.Btn_aceptar.Text = "Guardar";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // FrmPuntoVenta_cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 212);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.Lbl_codprd);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPuntoVenta_cotizacion";
            this.Text = "Cotizacion";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_codprd;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_aceptar;
    }
}
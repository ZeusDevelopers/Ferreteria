namespace PVFP
{
    partial class FrmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAdmin));
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnTCargos = new System.Windows.Forms.Button();
            this.BtnPerdida = new System.Windows.Forms.Button();
            this.BtnAlmacen = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.Btn_venta_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::Ferreteria.Properties.Resources.empleados1;
            this.btnEmpleados.Location = new System.Drawing.Point(280, 409);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(203, 135);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductos.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::Ferreteria.Properties.Resources.productos;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.Location = new System.Drawing.Point(45, 214);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(203, 135);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Image = global::Ferreteria.Properties.Resources.informe;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategorias.Location = new System.Drawing.Point(280, 214);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(203, 135);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Informes";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = global::Ferreteria.Properties.Resources.Provedor;
            this.btnProveedores.Location = new System.Drawing.Point(45, 409);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(203, 135);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnTCargos
            // 
            this.btnTCargos.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTCargos.Image = global::Ferreteria.Properties.Resources.Devoluciopn;
            this.btnTCargos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTCargos.Location = new System.Drawing.Point(518, 214);
            this.btnTCargos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTCargos.Name = "btnTCargos";
            this.btnTCargos.Size = new System.Drawing.Size(203, 135);
            this.btnTCargos.TabIndex = 4;
            this.btnTCargos.Text = "Devolucion";
            this.btnTCargos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTCargos.UseVisualStyleBackColor = true;
            this.btnTCargos.Click += new System.EventHandler(this.btnTCargos_Click);
            // 
            // BtnPerdida
            // 
            this.BtnPerdida.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPerdida.Image = global::Ferreteria.Properties.Resources.descending_money_arrow_graphic_and_a_businessman4;
            this.BtnPerdida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPerdida.Location = new System.Drawing.Point(518, 409);
            this.BtnPerdida.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnPerdida.Name = "BtnPerdida";
            this.BtnPerdida.Size = new System.Drawing.Size(203, 135);
            this.BtnPerdida.TabIndex = 5;
            this.BtnPerdida.Text = "Perdida";
            this.BtnPerdida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPerdida.UseVisualStyleBackColor = true;
            this.BtnPerdida.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnAlmacen
            // 
            this.BtnAlmacen.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlmacen.Image = global::Ferreteria.Properties.Resources.warehouse;
            this.BtnAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAlmacen.Location = new System.Drawing.Point(755, 214);
            this.BtnAlmacen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnAlmacen.Name = "BtnAlmacen";
            this.BtnAlmacen.Size = new System.Drawing.Size(203, 135);
            this.BtnAlmacen.TabIndex = 6;
            this.BtnAlmacen.Text = "Almacen";
            this.BtnAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAlmacen.UseVisualStyleBackColor = true;
            this.BtnAlmacen.Click += new System.EventHandler(this.BtnAlmacen_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Image = global::Ferreteria.Properties.Resources.entradas;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntradas.Location = new System.Drawing.Point(755, 409);
            this.btnEntradas.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(203, 135);
            this.btnEntradas.TabIndex = 8;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // Btn_venta_admin
            // 
            this.Btn_venta_admin.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_venta_admin.Image = global::Ferreteria.Properties.Resources.Icono;
            this.Btn_venta_admin.Location = new System.Drawing.Point(45, 571);
            this.Btn_venta_admin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_venta_admin.Name = "Btn_venta_admin";
            this.Btn_venta_admin.Size = new System.Drawing.Size(203, 135);
            this.Btn_venta_admin.TabIndex = 9;
            this.Btn_venta_admin.Text = "Punto Venta";
            this.Btn_venta_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_venta_admin.UseVisualStyleBackColor = true;
            this.Btn_venta_admin.Click += new System.EventHandler(this.Btn_venta_admin_Click);
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 733);
            this.Controls.Add(this.Btn_venta_admin);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.BtnAlmacen);
            this.Controls.Add(this.BtnPerdida);
            this.Controls.Add(this.btnTCargos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnEmpleados);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnTCargos;
        private System.Windows.Forms.Button BtnPerdida;
        private System.Windows.Forms.Button BtnAlmacen;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button Btn_venta_admin;
    }
}
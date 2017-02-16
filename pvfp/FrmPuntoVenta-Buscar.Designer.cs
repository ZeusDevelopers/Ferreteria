namespace PVFP
{
    partial class FrmPuntoVenta_Buscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Txtcodigo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.Txtcodigo.Location = new System.Drawing.Point(12, 129);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(667, 40);
            this.Txtcodigo.TabIndex = 0;
            this.Txtcodigo.TextChanged += new System.EventHandler(this.Txtcodigo_TextChanged);
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductos.Location = new System.Drawing.Point(12, 201);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowTemplate.Height = 28;
            this.DgvProductos.Size = new System.Drawing.Size(1078, 455);
            this.DgvProductos.TabIndex = 24;
            this.DgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellClick);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(892, 122);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(133, 52);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_seleccionar.Location = new System.Drawing.Point(735, 122);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(150, 52);
            this.Btn_seleccionar.TabIndex = 2;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 0;
            this.vScrollBar1.Location = new System.Drawing.Point(693, 121);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 48);
            this.vScrollBar1.SmallChange = 0;
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 56);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar";
            // 
            // FrmPuntoVenta_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1102, 724);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txtcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmPuntoVenta_Buscar";
            this.Text = "FrmPuntoVenta_Buscar";
            this.Load += new System.EventHandler(this.FrmPuntoVenta_Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
    }
}
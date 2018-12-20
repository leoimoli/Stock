namespace Stock
{
    partial class Reporte_ProductoWF
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
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.chcCodigo = new System.Windows.Forms.CheckBox();
            this.chcNombre = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbFiltros.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.BackColor = System.Drawing.Color.SteelBlue;
            this.grbFiltros.Controls.Add(this.button1);
            this.grbFiltros.Controls.Add(this.lblProducto);
            this.grbFiltros.Controls.Add(this.txtProducto);
            this.grbFiltros.Controls.Add(this.chcCodigo);
            this.grbFiltros.Controls.Add(this.chcNombre);
            this.grbFiltros.Location = new System.Drawing.Point(254, 83);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(680, 200);
            this.grbFiltros.TabIndex = 5;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Ventas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::Stock.Properties.Resources.buscar40X35;
            this.button1.Location = new System.Drawing.Point(594, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 114;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(124, 76);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 113;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(272, 78);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(280, 20);
            this.txtProducto.TabIndex = 112;
            // 
            // chcCodigo
            // 
            this.chcCodigo.AutoSize = true;
            this.chcCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcCodigo.Location = new System.Drawing.Point(365, 16);
            this.chcCodigo.Name = "chcCodigo";
            this.chcCodigo.Size = new System.Drawing.Size(106, 24);
            this.chcCodigo.TabIndex = 2;
            this.chcCodigo.Text = "Por Código";
            this.chcCodigo.UseVisualStyleBackColor = true;
            this.chcCodigo.CheckedChanged += new System.EventHandler(this.chcCodigo_CheckedChanged);
            // 
            // chcNombre
            // 
            this.chcNombre.AutoSize = true;
            this.chcNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcNombre.Location = new System.Drawing.Point(185, 16);
            this.chcNombre.Name = "chcNombre";
            this.chcNombre.Size = new System.Drawing.Size(112, 24);
            this.chcNombre.TabIndex = 0;
            this.chcNombre.Text = "Por Nombre";
            this.chcNombre.UseVisualStyleBackColor = true;
            this.chcNombre.CheckedChanged += new System.EventHandler(this.chcNombre_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(256, 289);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(680, 290);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // Reporte_ProductoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grbFiltros);
            this.Name = "Reporte_ProductoWF";
            this.Text = "Reporte_ProductoWF";
            this.Load += new System.EventHandler(this.Reporte_ProductoWF_Load);
            this.Controls.SetChildIndex(this.grbFiltros, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.CheckBox chcCodigo;
        private System.Windows.Forms.CheckBox chcNombre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
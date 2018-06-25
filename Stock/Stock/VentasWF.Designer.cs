namespace Stock
{
    partial class VentasWF
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
            this.components = new System.ComponentModel.Container();
            this.panelGrande_Ventas = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEfectivoFijo = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblVueltoFijo = new System.Windows.Forms.Label();
            this.lblTotalPagarReal = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.panelGrande_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrande_Ventas
            // 
            this.panelGrande_Ventas.BackColor = System.Drawing.Color.SteelBlue;
            this.panelGrande_Ventas.Controls.Add(this.dgvVentas);
            this.panelGrande_Ventas.Location = new System.Drawing.Point(20, 70);
            this.panelGrande_Ventas.Name = "panelGrande_Ventas";
            this.panelGrande_Ventas.Size = new System.Drawing.Size(700, 450);
            this.panelGrande_Ventas.TabIndex = 3;
            // 
            // dgvVentas
            // 
            this.dgvVentas.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.Descripcion,
            this.Cantidad,
            this.PrecioVenta,
            this.PrecioFinal});
            this.dgvVentas.Location = new System.Drawing.Point(24, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(650, 430);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvVentas_KeyDown);
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Valor Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "Precio Final";
            this.PrecioFinal.Name = "PrecioFinal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblEfectivoFijo);
            this.panel2.Controls.Add(this.lblCambio);
            this.panel2.Controls.Add(this.lblVueltoFijo);
            this.panel2.Controls.Add(this.lblTotalPagarReal);
            this.panel2.Controls.Add(this.lblTotalPagar);
            this.panel2.Location = new System.Drawing.Point(730, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 160);
            this.panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblEfectivoFijo
            // 
            this.lblEfectivoFijo.AutoSize = true;
            this.lblEfectivoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivoFijo.ForeColor = System.Drawing.Color.White;
            this.lblEfectivoFijo.Location = new System.Drawing.Point(17, 71);
            this.lblEfectivoFijo.Name = "lblEfectivoFijo";
            this.lblEfectivoFijo.Size = new System.Drawing.Size(87, 25);
            this.lblEfectivoFijo.TabIndex = 25;
            this.lblEfectivoFijo.Text = "Efectivo:";
            this.lblEfectivoFijo.Visible = false;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.White;
            this.lblCambio.Location = new System.Drawing.Point(117, 130);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(119, 25);
            this.lblCambio.TabIndex = 24;
            this.lblCambio.Text = "@lblCambio";
            this.lblCambio.Visible = false;
            // 
            // lblVueltoFijo
            // 
            this.lblVueltoFijo.AutoSize = true;
            this.lblVueltoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueltoFijo.ForeColor = System.Drawing.Color.White;
            this.lblVueltoFijo.Location = new System.Drawing.Point(30, 130);
            this.lblVueltoFijo.Name = "lblVueltoFijo";
            this.lblVueltoFijo.Size = new System.Drawing.Size(74, 25);
            this.lblVueltoFijo.TabIndex = 23;
            this.lblVueltoFijo.Text = "Vuelto:";
            this.lblVueltoFijo.Visible = false;
            // 
            // lblTotalPagarReal
            // 
            this.lblTotalPagarReal.AutoSize = true;
            this.lblTotalPagarReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagarReal.ForeColor = System.Drawing.Color.White;
            this.lblTotalPagarReal.Location = new System.Drawing.Point(110, 17);
            this.lblTotalPagarReal.Name = "lblTotalPagarReal";
            this.lblTotalPagarReal.Size = new System.Drawing.Size(142, 25);
            this.lblTotalPagarReal.TabIndex = 22;
            this.lblTotalPagarReal.Text = "Total a Pagar";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lblTotalPagar.Location = new System.Drawing.Point(2, 24);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(112, 17);
            this.lblTotalPagar.TabIndex = 21;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Código Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(181, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 20);
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Location = new System.Drawing.Point(729, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 250);
            this.panel1.TabIndex = 4;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(42, 216);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(195, 25);
            this.lblNombreProducto.TabIndex = 36;
            this.lblNombreProducto.Text = "lblNombreProducto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(68, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.Silver;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFinalizarVenta.Image = global::Stock.Properties.Resources.Caja_Chica;
            this.btnFinalizarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(827, 491);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(80, 52);
            this.btnFinalizarVenta.TabIndex = 18;
            this.btnFinalizarVenta.Text = "Finalizar(F10)";
            this.btnFinalizarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnFinalizarVenta, "Finalizar(F10)");
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // btnCuentaCorriente
            // 
            this.btnCuentaCorriente.BackColor = System.Drawing.Color.Silver;
            this.btnCuentaCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaCorriente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCuentaCorriente.Image = global::Stock.Properties.Resources.Moroso_Grande;
            this.btnCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuentaCorriente.Location = new System.Drawing.Point(919, 491);
            this.btnCuentaCorriente.Name = "btnCuentaCorriente";
            this.btnCuentaCorriente.Size = new System.Drawing.Size(80, 52);
            this.btnCuentaCorriente.TabIndex = 19;
            this.btnCuentaCorriente.Text = "Deuda(F1)";
            this.btnCuentaCorriente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCuentaCorriente, "Registrar Deuda(F1)");
            this.btnCuentaCorriente.UseVisualStyleBackColor = false;
            this.btnCuentaCorriente.Visible = false;
            this.btnCuentaCorriente.Click += new System.EventHandler(this.btnCuentaCorriente_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Silver;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = global::Stock.Properties.Resources.cobrar1;
            this.btnCobrar.Location = new System.Drawing.Point(940, 491);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(50, 40);
            this.btnCobrar.TabIndex = 17;
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Visible = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // VentasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 704);
            this.Controls.Add(this.btnCuentaCorriente);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGrande_Ventas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VentasWF";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasWF_Load);
            this.Controls.SetChildIndex(this.panelGrande_Ventas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnCobrar, 0);
            this.Controls.SetChildIndex(this.btnFinalizarVenta, 0);
            this.Controls.SetChildIndex(this.btnCuentaCorriente, 0);
            this.panelGrande_Ventas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrande_Ventas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalPagarReal;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblEfectivoFijo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblVueltoFijo;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCuentaCorriente;
    }
}
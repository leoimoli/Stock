namespace Stock
{
    partial class PagosWF
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
            this.panel_RegistrarPago = new System.Windows.Forms.Panel();
            this.lblProveedorFijo = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblChequeFijo = new System.Windows.Forms.Label();
            this.lblMontoFijo = new System.Windows.Forms.Label();
            this.lblFechaFijo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFormaPagoFijo = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.panel200 = new System.Windows.Forms.Panel();
            this.btnNuevoPago = new System.Windows.Forms.Button();
            this.lblUltimoMovimientosProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHistorialProducto = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel_RegistrarPago.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel200.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel100.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_RegistrarPago
            // 
            this.panel_RegistrarPago.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_RegistrarPago.Controls.Add(this.lblProveedorFijo);
            this.panel_RegistrarPago.Controls.Add(this.cmbProveedor);
            this.panel_RegistrarPago.Controls.Add(this.txtCheque);
            this.panel_RegistrarPago.Controls.Add(this.txtMonto);
            this.panel_RegistrarPago.Controls.Add(this.lblChequeFijo);
            this.panel_RegistrarPago.Controls.Add(this.lblMontoFijo);
            this.panel_RegistrarPago.Controls.Add(this.lblFechaFijo);
            this.panel_RegistrarPago.Controls.Add(this.dateTimePicker1);
            this.panel_RegistrarPago.Controls.Add(this.lblFormaPagoFijo);
            this.panel_RegistrarPago.Controls.Add(this.cmbFormaPago);
            this.panel_RegistrarPago.Controls.Add(this.btnAgregarMarca);
            this.panel_RegistrarPago.Controls.Add(this.btnCargar);
            this.panel_RegistrarPago.Controls.Add(this.btnCancelar);
            this.panel_RegistrarPago.Controls.Add(this.btnGuardar);
            this.panel_RegistrarPago.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_RegistrarPago.Enabled = false;
            this.panel_RegistrarPago.Location = new System.Drawing.Point(311, 95);
            this.panel_RegistrarPago.Name = "panel_RegistrarPago";
            this.panel_RegistrarPago.Size = new System.Drawing.Size(611, 220);
            this.panel_RegistrarPago.TabIndex = 20;
            // 
            // lblProveedorFijo
            // 
            this.lblProveedorFijo.AutoSize = true;
            this.lblProveedorFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorFijo.ForeColor = System.Drawing.Color.White;
            this.lblProveedorFijo.Location = new System.Drawing.Point(128, 109);
            this.lblProveedorFijo.Name = "lblProveedorFijo";
            this.lblProveedorFijo.Size = new System.Drawing.Size(106, 17);
            this.lblProveedorFijo.TabIndex = 43;
            this.lblProveedorFijo.Text = "Proveedor(*):";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(240, 105);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(200, 21);
            this.cmbProveedor.TabIndex = 42;
            // 
            // txtCheque
            // 
            this.txtCheque.Enabled = false;
            this.txtCheque.Location = new System.Drawing.Point(240, 42);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(200, 20);
            this.txtCheque.TabIndex = 41;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(240, 72);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 40;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // lblChequeFijo
            // 
            this.lblChequeFijo.AutoSize = true;
            this.lblChequeFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeFijo.ForeColor = System.Drawing.Color.White;
            this.lblChequeFijo.Location = new System.Drawing.Point(147, 45);
            this.lblChequeFijo.Name = "lblChequeFijo";
            this.lblChequeFijo.Size = new System.Drawing.Size(86, 17);
            this.lblChequeFijo.TabIndex = 39;
            this.lblChequeFijo.Text = "Cheque(*):";
            // 
            // lblMontoFijo
            // 
            this.lblMontoFijo.AutoSize = true;
            this.lblMontoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoFijo.ForeColor = System.Drawing.Color.White;
            this.lblMontoFijo.Location = new System.Drawing.Point(159, 72);
            this.lblMontoFijo.Name = "lblMontoFijo";
            this.lblMontoFijo.Size = new System.Drawing.Size(75, 17);
            this.lblMontoFijo.TabIndex = 38;
            this.lblMontoFijo.Text = "Monto(*):";
            // 
            // lblFechaFijo
            // 
            this.lblFechaFijo.AutoSize = true;
            this.lblFechaFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFijo.ForeColor = System.Drawing.Color.White;
            this.lblFechaFijo.Location = new System.Drawing.Point(93, 136);
            this.lblFechaFijo.Name = "lblFechaFijo";
            this.lblFechaFijo.Size = new System.Drawing.Size(140, 17);
            this.lblFechaFijo.TabIndex = 37;
            this.lblFechaFijo.Text = "Fecha de Pago(*):";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // lblFormaPagoFijo
            // 
            this.lblFormaPagoFijo.AutoSize = true;
            this.lblFormaPagoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPagoFijo.ForeColor = System.Drawing.Color.White;
            this.lblFormaPagoFijo.Location = new System.Drawing.Point(93, 7);
            this.lblFormaPagoFijo.Name = "lblFormaPagoFijo";
            this.lblFormaPagoFijo.Size = new System.Drawing.Size(141, 17);
            this.lblFormaPagoFijo.TabIndex = 35;
            this.lblFormaPagoFijo.Text = "Forma de Pago(*):";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(240, 6);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(200, 21);
            this.cmbFormaPago.TabIndex = 34;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMarca.Image = global::Stock.Properties.Resources.Agregar_2__40X35;
            this.btnAgregarMarca.Location = new System.Drawing.Point(492, 174);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(50, 40);
            this.btnAgregarMarca.TabIndex = 33;
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Visible = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Image = global::Stock.Properties.Resources.subir;
            this.btnCargar.Location = new System.Drawing.Point(203, 175);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(49, 39);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::Stock.Properties.Resources.Eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(285, 175);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 39);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Stock.Properties.Resources.Guardar1;
            this.btnGuardar.Location = new System.Drawing.Point(362, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 39);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(311, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 25);
            this.panel3.TabIndex = 19;
            // 
            // lblapellidoNombreEditar
            // 
            this.lblapellidoNombreEditar.AutoSize = true;
            this.lblapellidoNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoNombreEditar.ForeColor = System.Drawing.Color.White;
            this.lblapellidoNombreEditar.Location = new System.Drawing.Point(19, 0);
            this.lblapellidoNombreEditar.Name = "lblapellidoNombreEditar";
            this.lblapellidoNombreEditar.Size = new System.Drawing.Size(140, 25);
            this.lblapellidoNombreEditar.TabIndex = 1;
            this.lblapellidoNombreEditar.Text = "Registrar Pago";
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.btnNuevoPago);
            this.panel200.Controls.Add(this.lblUltimoMovimientosProductos);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Location = new System.Drawing.Point(5, 95);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 18;
            // 
            // btnNuevoPago
            // 
            this.btnNuevoPago.BackColor = System.Drawing.Color.Silver;
            this.btnNuevoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPago.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuevoPago.Image = global::Stock.Properties.Resources.Pagos_Chico1;
            this.btnNuevoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoPago.Location = new System.Drawing.Point(93, 12);
            this.btnNuevoPago.Name = "btnNuevoPago";
            this.btnNuevoPago.Size = new System.Drawing.Size(80, 52);
            this.btnNuevoPago.TabIndex = 21;
            this.btnNuevoPago.Text = "Nuevo Pago";
            this.btnNuevoPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoPago.UseVisualStyleBackColor = false;
            this.btnNuevoPago.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // lblUltimoMovimientosProductos
            // 
            this.lblUltimoMovimientosProductos.AutoSize = true;
            this.lblUltimoMovimientosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimientosProductos.ForeColor = System.Drawing.Color.White;
            this.lblUltimoMovimientosProductos.Location = new System.Drawing.Point(3, 105);
            this.lblUltimoMovimientosProductos.Name = "lblUltimoMovimientosProductos";
            this.lblUltimoMovimientosProductos.Size = new System.Drawing.Size(190, 17);
            this.lblUltimoMovimientosProductos.TabIndex = 20;
            this.lblUltimoMovimientosProductos.Text = "Últimos pagos realizados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(5, 70);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(294, 25);
            this.panel100.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pagos";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Location = new System.Drawing.Point(311, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 187);
            this.panel6.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblHistorialProducto);
            this.panel5.Location = new System.Drawing.Point(311, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 21;
            // 
            // lblHistorialProducto
            // 
            this.lblHistorialProducto.AutoSize = true;
            this.lblHistorialProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialProducto.ForeColor = System.Drawing.Color.White;
            this.lblHistorialProducto.Location = new System.Drawing.Point(19, 0);
            this.lblHistorialProducto.Name = "lblHistorialProducto";
            this.lblHistorialProducto.Size = new System.Drawing.Size(167, 25);
            this.lblHistorialProducto.TabIndex = 1;
            this.lblHistorialProducto.Text = "Historial de pagos";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(442, 315);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 95;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // PagosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 749);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel_RegistrarPago);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PagosWF";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.PagosWF_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_RegistrarPago, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.panel_RegistrarPago.ResumeLayout(false);
            this.panel_RegistrarPago.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_RegistrarPago;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Label lblUltimoMovimientosProductos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblHistorialProducto;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lblFormaPagoFijo;
        private System.Windows.Forms.Label lblMontoFijo;
        private System.Windows.Forms.Label lblFechaFijo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblChequeFijo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label lblProveedorFijo;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnNuevoPago;
    }
}
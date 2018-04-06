namespace Stock
{
    partial class PrecioDeVentaWF
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
            this.panel_Producto = new System.Windows.Forms.Panel();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioActualVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReditoPorcentual = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorUni = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.panel200 = new System.Windows.Forms.Panel();
            this.lblUltimoMovimientosProductos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHistorialProducto = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_Producto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel200.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel100.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Producto
            // 
            this.panel_Producto.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Producto.Controls.Add(this.txtPrecioVenta);
            this.panel_Producto.Controls.Add(this.txtPrecioActualVenta);
            this.panel_Producto.Controls.Add(this.label1);
            this.panel_Producto.Controls.Add(this.txtReditoPorcentual);
            this.panel_Producto.Controls.Add(this.label9);
            this.panel_Producto.Controls.Add(this.label6);
            this.panel_Producto.Controls.Add(this.txtValorUni);
            this.panel_Producto.Controls.Add(this.txtTotalCompra);
            this.panel_Producto.Controls.Add(this.lblContraseña);
            this.panel_Producto.Controls.Add(this.label5);
            this.panel_Producto.Controls.Add(this.btnCancelar);
            this.panel_Producto.Controls.Add(this.btnGuardar);
            this.panel_Producto.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Producto.Location = new System.Drawing.Point(313, 96);
            this.panel_Producto.Name = "panel_Producto";
            this.panel_Producto.Size = new System.Drawing.Size(611, 220);
            this.panel_Producto.TabIndex = 20;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Location = new System.Drawing.Point(310, 92);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(170, 20);
            this.txtPrecioVenta.TabIndex = 44;
            // 
            // txtPrecioActualVenta
            // 
            this.txtPrecioActualVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioActualVenta.Enabled = false;
            this.txtPrecioActualVenta.Location = new System.Drawing.Point(41, 150);
            this.txtPrecioActualVenta.Name = "txtPrecioActualVenta";
            this.txtPrecioActualVenta.Size = new System.Drawing.Size(170, 20);
            this.txtPrecioActualVenta.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio actual de venta:";
            // 
            // txtReditoPorcentual
            // 
            this.txtReditoPorcentual.Location = new System.Drawing.Point(310, 34);
            this.txtReditoPorcentual.Mask = "000%";
            this.txtReditoPorcentual.Name = "txtReditoPorcentual";
            this.txtReditoPorcentual.Size = new System.Drawing.Size(170, 20);
            this.txtReditoPorcentual.TabIndex = 41;
            this.txtReditoPorcentual.TextChanged += new System.EventHandler(this.txtReditoPorcentual_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(307, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Precio de Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(307, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Rédito Porcentual:";
            // 
            // txtValorUni
            // 
            this.txtValorUni.Enabled = false;
            this.txtValorUni.Location = new System.Drawing.Point(41, 34);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(170, 20);
            this.txtValorUni.TabIndex = 36;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(41, 92);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(170, 20);
            this.txtTotalCompra.TabIndex = 37;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(38, 72);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(234, 17);
            this.lblContraseña.TabIndex = 35;
            this.lblContraseña.Text = "Último Precio Total de Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Último Valor Unitario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::Stock.Properties.Resources.Eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(301, 170);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 39);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Stock.Properties.Resources.Guardar1;
            this.btnGuardar.Location = new System.Drawing.Point(370, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 39);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(313, 71);
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
            this.lblapellidoNombreEditar.Size = new System.Drawing.Size(146, 25);
            this.lblapellidoNombreEditar.TabIndex = 1;
            this.lblapellidoNombreEditar.Text = "Producto/Editar";
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.lblUltimoMovimientosProductos);
            this.panel200.Controls.Add(this.label10);
            this.panel200.Controls.Add(this.txtCodigo);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Location = new System.Drawing.Point(7, 96);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 18;
            // 
            // lblUltimoMovimientosProductos
            // 
            this.lblUltimoMovimientosProductos.AutoSize = true;
            this.lblUltimoMovimientosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimientosProductos.ForeColor = System.Drawing.Color.White;
            this.lblUltimoMovimientosProductos.Location = new System.Drawing.Point(3, 82);
            this.lblUltimoMovimientosProductos.Name = "lblUltimoMovimientosProductos";
            this.lblUltimoMovimientosProductos.Size = new System.Drawing.Size(160, 17);
            this.lblUltimoMovimientosProductos.TabIndex = 20;
            this.lblUltimoMovimientosProductos.Text = "Últimos Movimientos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 14);
            this.label10.MaximumSize = new System.Drawing.Size(100, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 34);
            this.label10.TabIndex = 19;
            this.label10.Text = "Código Producto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(83, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(7, 71);
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
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Productos";
            // 
            // lblHistorialProducto
            // 
            this.lblHistorialProducto.AutoSize = true;
            this.lblHistorialProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialProducto.ForeColor = System.Drawing.Color.White;
            this.lblHistorialProducto.Location = new System.Drawing.Point(19, 0);
            this.lblHistorialProducto.Name = "lblHistorialProducto";
            this.lblHistorialProducto.Size = new System.Drawing.Size(221, 25);
            this.lblHistorialProducto.TabIndex = 1;
            this.lblHistorialProducto.Text = "Historial Precio de venta";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.panelInformacion);
            this.panel6.Location = new System.Drawing.Point(313, 365);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 187);
            this.panel6.TabIndex = 22;
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.LightBlue;
            this.panelInformacion.Controls.Add(this.dataGridView2);
            this.panelInformacion.Location = new System.Drawing.Point(30, 18);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(550, 150);
            this.panelInformacion.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 140);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblHistorialProducto);
            this.panel5.Location = new System.Drawing.Point(313, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 21;
            // 
            // PrecioDeVentaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.panel_Producto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PrecioDeVentaWF";
            this.Text = "Calculo Precio de Venta";
            this.Load += new System.EventHandler(this.PrecioDeVentaWF_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_Producto, 0);
            this.panel_Producto.ResumeLayout(false);
            this.panel_Producto.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Producto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Label lblUltimoMovimientosProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHistorialProducto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox txtReditoPorcentual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorUni;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioActualVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
    }
}
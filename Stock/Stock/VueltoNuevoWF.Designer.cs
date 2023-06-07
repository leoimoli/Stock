namespace Stock
{
    partial class VueltoNuevoWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueltoNuevoWF));
            this.lblTotal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEfectivo = new System.Windows.Forms.TextBox();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.grbDescuentos = new System.Windows.Forms.GroupBox();
            this.btnCancelarDescuento1 = new System.Windows.Forms.Button();
            this.btnCancelaDescuento2 = new System.Windows.Forms.Button();
            this.btnAplicarPrecio = new System.Windows.Forms.Button();
            this.btnAplicarPorcentaje = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtReditoPorcentual = new System.Windows.Forms.MaskedTextBox();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbDescuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblTotal.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(165, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 60);
            this.lblTotal.TabIndex = 58;
            this.lblTotal.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 128;
            this.label8.Text = "Total a Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "Efectivo";
            // 
            // lblVuelto
            // 
            this.lblVuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblVuelto.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.lblVuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.ForeColor = System.Drawing.Color.White;
            this.lblVuelto.Location = new System.Drawing.Point(165, 244);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(147, 60);
            this.lblVuelto.TabIndex = 60;
            this.lblVuelto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 130;
            this.label2.Text = "Vuelto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(128, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 131;
            this.label3.Text = "Venta Confiramda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::Stock.Properties.Resources.escapar;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(146, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 17);
            this.label5.TabIndex = 134;
            this.label5.Text = "   (Esc)Cerrar la ventana";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Stock.Properties.Resources.cancelar2;
            this.pictureBox1.Location = new System.Drawing.Point(456, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.ForeColor = System.Drawing.Color.White;
            this.lblEfectivo.Location = new System.Drawing.Point(165, 159);
            this.lblEfectivo.Multiline = true;
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(147, 68);
            this.lblEfectivo.TabIndex = 132;
            this.lblEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblEfectivo_KeyDown);
            this.lblEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentos.ForeColor = System.Drawing.Color.Red;
            this.lblDescuentos.Location = new System.Drawing.Point(11, 56);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(428, 19);
            this.lblDescuentos.TabIndex = 135;
            this.lblDescuentos.Text = "Atención: Se aplicaron Descuentos por ofertas vigentes";
            this.lblDescuentos.Visible = false;
            // 
            // grbDescuentos
            // 
            this.grbDescuentos.Controls.Add(this.btnCancelarDescuento1);
            this.grbDescuentos.Controls.Add(this.btnDescuentos);
            this.grbDescuentos.Controls.Add(this.btnCancelaDescuento2);
            this.grbDescuentos.Controls.Add(this.btnAplicarPrecio);
            this.grbDescuentos.Controls.Add(this.btnAplicarPorcentaje);
            this.grbDescuentos.Controls.Add(this.label9);
            this.grbDescuentos.Controls.Add(this.label4);
            this.grbDescuentos.Controls.Add(this.txtPrecioVenta);
            this.grbDescuentos.Controls.Add(this.txtReditoPorcentual);
            this.grbDescuentos.Location = new System.Drawing.Point(132, 371);
            this.grbDescuentos.Name = "grbDescuentos";
            this.grbDescuentos.Size = new System.Drawing.Size(202, 102);
            this.grbDescuentos.TabIndex = 155;
            this.grbDescuentos.TabStop = false;
            this.grbDescuentos.Visible = false;
            // 
            // btnCancelarDescuento1
            // 
            this.btnCancelarDescuento1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnCancelarDescuento1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCancelarDescuento1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDescuento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDescuento1.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDescuento1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarDescuento1.Image")));
            this.btnCancelarDescuento1.Location = new System.Drawing.Point(170, 37);
            this.btnCancelarDescuento1.Name = "btnCancelarDescuento1";
            this.btnCancelarDescuento1.Size = new System.Drawing.Size(21, 19);
            this.btnCancelarDescuento1.TabIndex = 160;
            this.toolTip1.SetToolTip(this.btnCancelarDescuento1, "Cancelar Descuento");
            this.btnCancelarDescuento1.UseVisualStyleBackColor = false;
            this.btnCancelarDescuento1.Click += new System.EventHandler(this.btnCancelarDescuento1_Click);
            // 
            // btnCancelaDescuento2
            // 
            this.btnCancelaDescuento2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnCancelaDescuento2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCancelaDescuento2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaDescuento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaDescuento2.ForeColor = System.Drawing.Color.White;
            this.btnCancelaDescuento2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelaDescuento2.Image")));
            this.btnCancelaDescuento2.Location = new System.Drawing.Point(170, 78);
            this.btnCancelaDescuento2.Name = "btnCancelaDescuento2";
            this.btnCancelaDescuento2.Size = new System.Drawing.Size(21, 19);
            this.btnCancelaDescuento2.TabIndex = 159;
            this.toolTip1.SetToolTip(this.btnCancelaDescuento2, "Cancelar Descuento");
            this.btnCancelaDescuento2.UseVisualStyleBackColor = false;
            this.btnCancelaDescuento2.Click += new System.EventHandler(this.btnCancelaDescuento2_Click);
            // 
            // btnAplicarPrecio
            // 
            this.btnAplicarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnAplicarPrecio.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAplicarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnAplicarPrecio.Image = global::Stock.Properties.Resources.boton_de_play;
            this.btnAplicarPrecio.Location = new System.Drawing.Point(143, 78);
            this.btnAplicarPrecio.Name = "btnAplicarPrecio";
            this.btnAplicarPrecio.Size = new System.Drawing.Size(21, 19);
            this.btnAplicarPrecio.TabIndex = 158;
            this.toolTip1.SetToolTip(this.btnAplicarPrecio, "Aplicar Descuento");
            this.btnAplicarPrecio.UseVisualStyleBackColor = false;
            this.btnAplicarPrecio.Click += new System.EventHandler(this.btnAplicarPrecio_Click);
            // 
            // btnAplicarPorcentaje
            // 
            this.btnAplicarPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnAplicarPorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAplicarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarPorcentaje.ForeColor = System.Drawing.Color.White;
            this.btnAplicarPorcentaje.Image = global::Stock.Properties.Resources.boton_de_play;
            this.btnAplicarPorcentaje.Location = new System.Drawing.Point(143, 37);
            this.btnAplicarPorcentaje.Name = "btnAplicarPorcentaje";
            this.btnAplicarPorcentaje.Size = new System.Drawing.Size(21, 19);
            this.btnAplicarPorcentaje.TabIndex = 157;
            this.toolTip1.SetToolTip(this.btnAplicarPorcentaje, "Aplicar Descuento");
            this.btnAplicarPorcentaje.UseVisualStyleBackColor = false;
            this.btnAplicarPorcentaje.Click += new System.EventHandler(this.btnAplicarPorcentaje_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 154;
            this.label9.Text = "Nuevo Monto Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 153;
            this.label4.Text = "Descuento Procentual";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(29, 73);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(108, 26);
            this.txtPrecioVenta.TabIndex = 66;
            this.txtPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_KeyDown);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtReditoPorcentual
            // 
            this.txtReditoPorcentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReditoPorcentual.Location = new System.Drawing.Point(29, 30);
            this.txtReditoPorcentual.Mask = "000%";
            this.txtReditoPorcentual.Name = "txtReditoPorcentual";
            this.txtReditoPorcentual.Size = new System.Drawing.Size(108, 26);
            this.txtReditoPorcentual.TabIndex = 67;
            this.txtReditoPorcentual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReditoPorcentual_KeyDown);
            this.txtReditoPorcentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnDescuentos.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentos.ForeColor = System.Drawing.Color.White;
            this.btnDescuentos.Location = new System.Drawing.Point(56, 30);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(164, 44);
            this.btnDescuentos.TabIndex = 154;
            this.btnDescuentos.Text = "(F10) Aplicar Descuento";
            this.btnDescuentos.UseVisualStyleBackColor = false;
            this.btnDescuentos.Visible = false;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // VueltoNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(487, 337);
            this.Controls.Add(this.grbDescuentos);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVuelto);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueltoNuevoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VueltoNuevoWF";
            this.Load += new System.EventHandler(this.VueltoNuevoWF_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VueltoNuevoWF_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbDescuentos.ResumeLayout(false);
            this.grbDescuentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblVuelto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblEfectivo;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.GroupBox grbDescuentos;
        private System.Windows.Forms.Button btnCancelarDescuento1;
        private System.Windows.Forms.Button btnCancelaDescuento2;
        private System.Windows.Forms.Button btnAplicarPrecio;
        private System.Windows.Forms.Button btnAplicarPorcentaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.MaskedTextBox txtReditoPorcentual;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
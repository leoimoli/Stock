namespace Stock
{
    partial class CobrarWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.@lblCambio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnImprimirTicket = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTitulaTarjate = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.cmbMesVencimiento = new System.Windows.Forms.ComboBox();
            this.txtAñoVencimiento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total a pagar:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lblTotalPagar.Location = new System.Drawing.Point(264, 13);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(147, 25);
            this.lblTotalPagar.TabIndex = 1;
            this.lblTotalPagar.Text = "@lblTotalPagar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.@lblCambio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(130, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 172);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // @lblCambio
            // 
            this.@lblCambio.AutoSize = true;
            this.@lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.@lblCambio.ForeColor = System.Drawing.Color.White;
            this.@lblCambio.Location = new System.Drawing.Point(111, 102);
            this.@lblCambio.Name = "@lblCambio";
            this.@lblCambio.Size = new System.Drawing.Size(119, 25);
            this.@lblCambio.TabIndex = 3;
            this.@lblCambio.Text = "@lblCambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cambio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Efectivo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 54);
            this.textBox1.TabIndex = 5;
            // 
            // btnImprimirTicket
            // 
            this.btnImprimirTicket.BackColor = System.Drawing.Color.Silver;
            this.btnImprimirTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTicket.Image = global::Stock.Properties.Resources.cobrar1;
            this.btnImprimirTicket.Location = new System.Drawing.Point(472, 310);
            this.btnImprimirTicket.Name = "btnImprimirTicket";
            this.btnImprimirTicket.Size = new System.Drawing.Size(70, 40);
            this.btnImprimirTicket.TabIndex = 21;
            this.btnImprimirTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirTicket.UseVisualStyleBackColor = false;
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.Silver;
            this.btnDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.Image = global::Stock.Properties.Resources.F2;
            this.btnDebito.Location = new System.Drawing.Point(234, 49);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(70, 40);
            this.btnDebito.TabIndex = 20;
            this.btnDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDebito.UseVisualStyleBackColor = false;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.BackColor = System.Drawing.Color.Silver;
            this.btnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Image = global::Stock.Properties.Resources.F1;
            this.btnEfectivo.Location = new System.Drawing.Point(139, 49);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(70, 40);
            this.btnEfectivo.TabIndex = 19;
            this.btnEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEfectivo.UseVisualStyleBackColor = false;
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.Silver;
            this.btnCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.Image = global::Stock.Properties.Resources.F3;
            this.btnCredito.Location = new System.Drawing.Point(325, 49);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(70, 40);
            this.btnCredito.TabIndex = 18;
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCredito.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCuotas);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAñoVencimiento);
            this.groupBox2.Controls.Add(this.cmbMesVencimiento);
            this.groupBox2.Controls.Add(this.txtCodigoSeguridad);
            this.groupBox2.Controls.Add(this.txtNroTarjeta);
            this.groupBox2.Controls.Add(this.txtTitulaTarjate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(104, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 196);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido y Nombre Títular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número de la tarjeta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Código de seguridad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(124, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cuotas:";
            // 
            // txtTitulaTarjate
            // 
            this.txtTitulaTarjate.Location = new System.Drawing.Point(181, 24);
            this.txtTitulaTarjate.Name = "txtTitulaTarjate";
            this.txtTitulaTarjate.Size = new System.Drawing.Size(175, 20);
            this.txtTitulaTarjate.TabIndex = 9;
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(181, 54);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(175, 20);
            this.txtNroTarjeta.TabIndex = 10;
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(181, 124);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(175, 20);
            this.txtCodigoSeguridad.TabIndex = 11;
            // 
            // cmbMesVencimiento
            // 
            this.cmbMesVencimiento.FormattingEnabled = true;
            this.cmbMesVencimiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbMesVencimiento.Location = new System.Drawing.Point(181, 88);
            this.cmbMesVencimiento.Name = "cmbMesVencimiento";
            this.cmbMesVencimiento.Size = new System.Drawing.Size(73, 21);
            this.cmbMesVencimiento.TabIndex = 12;
            // 
            // txtAñoVencimiento
            // 
            this.txtAñoVencimiento.Location = new System.Drawing.Point(275, 88);
            this.txtAñoVencimiento.Name = "txtAñoVencimiento";
            this.txtAñoVencimiento.Size = new System.Drawing.Size(81, 20);
            this.txtAñoVencimiento.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(260, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "/";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "18",
            "24",
            "36",
            "48"});
            this.cmbCuotas.Location = new System.Drawing.Point(181, 160);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(73, 21);
            this.cmbCuotas.TabIndex = 15;
            // 
            // CobrarWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(554, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImprimirTicket);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label1);
            this.Name = "CobrarWF";
            this.Text = "Cobrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnImprimirTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.TextBox txtTitulaTarjate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAñoVencimiento;
        private System.Windows.Forms.ComboBox cmbMesVencimiento;
        private System.Windows.Forms.ComboBox cmbCuotas;
    }
}
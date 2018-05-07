namespace Stock
{
    partial class Reporte_VentasWF
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
            this.chcCliente = new System.Windows.Forms.CheckBox();
            this.chcUsuario = new System.Windows.Forms.CheckBox();
            this.chcFecha = new System.Windows.Forms.CheckBox();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.chcCliente);
            this.grbFiltros.Controls.Add(this.chcUsuario);
            this.grbFiltros.Controls.Add(this.chcFecha);
            this.grbFiltros.Location = new System.Drawing.Point(251, 77);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(600, 200);
            this.grbFiltros.TabIndex = 4;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "groupBox1";
            // 
            // chcCliente
            // 
            this.chcCliente.AutoSize = true;
            this.chcCliente.Location = new System.Drawing.Point(287, 16);
            this.chcCliente.Name = "chcCliente";
            this.chcCliente.Size = new System.Drawing.Size(77, 17);
            this.chcCliente.TabIndex = 2;
            this.chcCliente.Text = "Por Cliente";
            this.chcCliente.UseVisualStyleBackColor = true;
            this.chcCliente.CheckedChanged += new System.EventHandler(this.chcCliente_CheckedChanged);
            // 
            // chcUsuario
            // 
            this.chcUsuario.AutoSize = true;
            this.chcUsuario.Location = new System.Drawing.Point(185, 16);
            this.chcUsuario.Name = "chcUsuario";
            this.chcUsuario.Size = new System.Drawing.Size(81, 17);
            this.chcUsuario.TabIndex = 1;
            this.chcUsuario.Text = "Por Usuario";
            this.chcUsuario.UseVisualStyleBackColor = true;
            this.chcUsuario.CheckedChanged += new System.EventHandler(this.chcUsuario_CheckedChanged);
            // 
            // chcFecha
            // 
            this.chcFecha.AutoSize = true;
            this.chcFecha.Location = new System.Drawing.Point(74, 16);
            this.chcFecha.Name = "chcFecha";
            this.chcFecha.Size = new System.Drawing.Size(75, 17);
            this.chcFecha.TabIndex = 0;
            this.chcFecha.Text = "Por Fecha";
            this.chcFecha.UseVisualStyleBackColor = true;
            this.chcFecha.CheckedChanged += new System.EventHandler(this.chcFecha_CheckedChanged);
            // 
            // Reporte_VentasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.grbFiltros);
            this.Name = "Reporte_VentasWF";
            this.Text = "Reporte_VentasWF";
            this.Load += new System.EventHandler(this.Reporte_VentasWF_Load);
            this.Controls.SetChildIndex(this.grbFiltros, 0);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.CheckBox chcCliente;
        //private System.Windows.Forms.CheckBox chcUsuario;
        //private System.Windows.Forms.CheckBox chcFecha;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.CheckBox chcCliente;
        private System.Windows.Forms.CheckBox chcUsuario;
        private System.Windows.Forms.CheckBox chcFecha;
    }
}
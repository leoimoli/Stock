namespace Stock
{
    partial class CargarPuntosWF
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblPuntosVisible = new System.Windows.Forms.Label();
            this.lblPuntosVariables = new System.Windows.Forms.Label();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(120, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(63, 113);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(95, 20);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "Ingrese Dni:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(178, 115);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(159, 20);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            // 
            // lblPuntosVisible
            // 
            this.lblPuntosVisible.AutoSize = true;
            this.lblPuntosVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosVisible.ForeColor = System.Drawing.Color.White;
            this.lblPuntosVisible.Location = new System.Drawing.Point(5, 75);
            this.lblPuntosVisible.Name = "lblPuntosVisible";
            this.lblPuntosVisible.Size = new System.Drawing.Size(167, 25);
            this.lblPuntosVisible.TabIndex = 3;
            this.lblPuntosVisible.Text = "Puntos a Asignar:";
            this.lblPuntosVisible.Visible = false;
            // 
            // lblPuntosVariables
            // 
            this.lblPuntosVariables.AutoSize = true;
            this.lblPuntosVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosVariables.ForeColor = System.Drawing.Color.White;
            this.lblPuntosVariables.Location = new System.Drawing.Point(173, 75);
            this.lblPuntosVariables.Name = "lblPuntosVariables";
            this.lblPuntosVariables.Size = new System.Drawing.Size(178, 26);
            this.lblPuntosVariables.TabIndex = 38;
            this.lblPuntosVariables.Text = "Puntos a Asignar";
            this.lblPuntosVariables.Visible = false;
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombre.ForeColor = System.Drawing.Color.White;
            this.lblApellidoNombre.Location = new System.Drawing.Point(194, 31);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(73, 24);
            this.lblApellidoNombre.TabIndex = 39;
            this.lblApellidoNombre.Text = "Cliente:";
            this.lblApellidoNombre.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::Stock.Properties.Resources.Eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(109, 163);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 39);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Stock.Properties.Resources.f12Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(198, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 39);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CargarPuntosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(363, 256);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblApellidoNombre);
            this.Controls.Add(this.lblPuntosVariables);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPuntosVisible);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblCliente);
            this.Name = "CargarPuntosWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar puntos";
            this.Load += new System.EventHandler(this.CargarPuntosWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblPuntosVisible;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPuntosVariables;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Button btnCancelar;
    }
}
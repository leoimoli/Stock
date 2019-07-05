namespace Stock
{
    partial class MenuSuperAdminWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarCodigos = new System.Windows.Forms.Button();
            this.btnCargaMasiva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnActualizarCodigos);
            this.groupBox1.Controls.Add(this.btnCargaMasiva);
            this.groupBox1.Location = new System.Drawing.Point(148, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnActualizarCodigos
            // 
            this.btnActualizarCodigos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarCodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCodigos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCodigos.Image = global::Stock.Properties.Resources.flecha_de_bucle;
            this.btnActualizarCodigos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCodigos.Location = new System.Drawing.Point(277, 19);
            this.btnActualizarCodigos.Name = "btnActualizarCodigos";
            this.btnActualizarCodigos.Size = new System.Drawing.Size(271, 82);
            this.btnActualizarCodigos.TabIndex = 10;
            this.btnActualizarCodigos.Text = "Actualizar Códigos Productos";
            this.btnActualizarCodigos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarCodigos.UseVisualStyleBackColor = false;
            this.btnActualizarCodigos.Click += new System.EventHandler(this.btnActualizarCodigos_Click);
            // 
            // btnCargaMasiva
            // 
            this.btnCargaMasiva.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCargaMasiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargaMasiva.Image = global::Stock.Properties.Resources.subir;
            this.btnCargaMasiva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaMasiva.Location = new System.Drawing.Point(29, 19);
            this.btnCargaMasiva.Name = "btnCargaMasiva";
            this.btnCargaMasiva.Size = new System.Drawing.Size(216, 82);
            this.btnCargaMasiva.TabIndex = 4;
            this.btnCargaMasiva.Text = "Carga Masiva Productos";
            this.btnCargaMasiva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargaMasiva.UseVisualStyleBackColor = false;
            this.btnCargaMasiva.Click += new System.EventHandler(this.btnCargaMasiva_Click);
            // 
            // MenuSuperAdminWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 593);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuSuperAdminWF";
            this.Text = "Menú Super Admin";
            this.Load += new System.EventHandler(this.MenuSuperAdminWF_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizarCodigos;
        private System.Windows.Forms.Button btnCargaMasiva;
    }
}
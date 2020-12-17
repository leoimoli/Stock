namespace Stock
{
    partial class AltaMarcaNuevoWF
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stock.Properties.Resources.cancelar2;
            this.pictureBox1.Location = new System.Drawing.Point(457, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.txtNombreEmpresa);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(18, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 243);
            this.panel1.TabIndex = 62;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(177, 71);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEmpresa.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 96;
            this.label12.Text = "Nombre Marca(*):";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(32, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 95;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nuevo Proveedor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(97, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(289, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AltaMarcaNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(485, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaMarcaNuevoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta nueva marca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
    }
}
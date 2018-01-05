namespace Stock
{
    partial class Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel200 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsuarioEstadisticas = new System.Windows.Forms.Label();
            this.panel_Producto = new System.Windows.Forms.Panel();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel200.SuspendLayout();
            this.panel100.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.label10);
            this.panel200.Controls.Add(this.textBox6);
            this.panel200.Controls.Add(this.btnProducto);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Location = new System.Drawing.Point(19, 101);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.MaximumSize = new System.Drawing.Size(100, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 34);
            this.label10.TabIndex = 19;
            this.label10.Text = "Código Producto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 9);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 18;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.Silver;
            this.btnProducto.Location = new System.Drawing.Point(90, 40);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(100, 35);
            this.btnProducto.TabIndex = 13;
            this.btnProducto.Text = "Nuevo Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(19, 76);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(294, 25);
            this.panel100.TabIndex = 11;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Location = new System.Drawing.Point(325, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 187);
            this.panel6.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblUsuarioEstadisticas);
            this.panel5.Location = new System.Drawing.Point(325, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 15;
            // 
            // lblUsuarioEstadisticas
            // 
            this.lblUsuarioEstadisticas.AutoSize = true;
            this.lblUsuarioEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEstadisticas.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEstadisticas.Location = new System.Drawing.Point(19, 0);
            this.lblUsuarioEstadisticas.Name = "lblUsuarioEstadisticas";
            this.lblUsuarioEstadisticas.Size = new System.Drawing.Size(174, 25);
            this.lblUsuarioEstadisticas.TabIndex = 1;
            this.lblUsuarioEstadisticas.Text = "Historial Productos";
            // 
            // panel_Producto
            // 
            this.panel_Producto.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Producto.Controls.Add(this.btnAgregarMarca);
            this.panel_Producto.Controls.Add(this.cmbMarca);
            this.panel_Producto.Controls.Add(this.txtImagen);
            this.panel_Producto.Controls.Add(this.btnCargarImagen);
            this.panel_Producto.Controls.Add(this.pictureBox1);
            this.panel_Producto.Controls.Add(this.textBox2);
            this.panel_Producto.Controls.Add(this.label8);
            this.panel_Producto.Controls.Add(this.btnCancelar);
            this.panel_Producto.Controls.Add(this.btnGuardar);
            this.panel_Producto.Controls.Add(this.txtNombreProducto);
            this.panel_Producto.Controls.Add(this.txtCodigoProducto);
            this.panel_Producto.Controls.Add(this.txtDescripcion);
            this.panel_Producto.Controls.Add(this.label4);
            this.panel_Producto.Controls.Add(this.label3);
            this.panel_Producto.Enabled = false;
            this.panel_Producto.Location = new System.Drawing.Point(325, 101);
            this.panel_Producto.Name = "panel_Producto";
            this.panel_Producto.Size = new System.Drawing.Size(611, 220);
            this.panel_Producto.TabIndex = 14;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarMarca.Image = global::Stock.Properties.Resources.Agregar_2__40X35;
            this.btnAgregarMarca.Location = new System.Drawing.Point(528, 87);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(40, 35);
            this.btnAgregarMarca.TabIndex = 33;
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Visible = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(322, 95);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(200, 21);
            this.cmbMarca.TabIndex = 32;
            this.cmbMarca.Click += new System.EventHandler(this.cmbMarca_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(10, 158);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(150, 20);
            this.txtImagen.TabIndex = 31;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Silver;
            this.btnCargarImagen.Location = new System.Drawing.Point(41, 188);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 30;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Visible = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(320, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 40);
            this.textBox2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(181, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre Producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Location = new System.Drawing.Point(350, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(445, 188);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProducto.Location = new System.Drawing.Point(320, 57);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(200, 20);
            this.txtNombreProducto.TabIndex = 23;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProducto.Location = new System.Drawing.Point(320, 19);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoProducto.TabIndex = 21;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(222, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(98, 17);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(263, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(169, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Código Producto(*):";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(325, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 25);
            this.panel3.TabIndex = 13;
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
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(450, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 94;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 753);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_Producto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_Producto, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_Producto.ResumeLayout(false);
            this.panel_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblUsuarioEstadisticas;
        private System.Windows.Forms.Panel panel_Producto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnAgregarMarca;
    }
}
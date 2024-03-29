﻿namespace Stock
{
    partial class ProductoNuevoWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoNuevoWF));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirCodigo = new System.Windows.Forms.Button();
            this.panelCodigo = new System.Windows.Forms.Panel();
            this.btnGenerarCodigo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chcProductoEspecial = new System.Windows.Forms.CheckBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargaMasiva = new System.Windows.Forms.Button();
            this.btnImprimirCod = new System.Windows.Forms.Button();
            this.txtDescipcionBus = new System.Windows.Forms.TextBox();
            this.txtCodigoBus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 30;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.CodigoProducto,
            this.Descripcion,
            this.Marca,
            this.Categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvProductos.Location = new System.Drawing.Point(12, 99);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProductos.Size = new System.Drawing.Size(633, 429);
            this.dgvProductos.TabIndex = 0;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "id";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 60;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Código de Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 250;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnImprimirCodigo);
            this.panel1.Controls.Add(this.panelCodigo);
            this.panel1.Controls.Add(this.btnGenerarCodigo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chcProductoEspecial);
            this.panel1.Controls.Add(this.lblContador);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbMarca);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtCodigoProducto);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(648, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 468);
            this.panel1.TabIndex = 2;
            // 
            // btnImprimirCodigo
            // 
            this.btnImprimirCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnImprimirCodigo.Enabled = false;
            this.btnImprimirCodigo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnImprimirCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCodigo.ForeColor = System.Drawing.Color.White;
            this.btnImprimirCodigo.Image = global::Stock.Properties.Resources.impresora;
            this.btnImprimirCodigo.Location = new System.Drawing.Point(365, 380);
            this.btnImprimirCodigo.Name = "btnImprimirCodigo";
            this.btnImprimirCodigo.Size = new System.Drawing.Size(46, 29);
            this.btnImprimirCodigo.TabIndex = 164;
            this.toolTip1.SetToolTip(this.btnImprimirCodigo, "Imprimir Código");
            this.btnImprimirCodigo.UseVisualStyleBackColor = false;
            this.btnImprimirCodigo.Visible = false;
            this.btnImprimirCodigo.Click += new System.EventHandler(this.btnImprimirCodigo_Click);
            // 
            // panelCodigo
            // 
            this.panelCodigo.Location = new System.Drawing.Point(11, 253);
            this.panelCodigo.Name = "panelCodigo";
            this.panelCodigo.Size = new System.Drawing.Size(414, 121);
            this.panelCodigo.TabIndex = 50;
            // 
            // btnGenerarCodigo
            // 
            this.btnGenerarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnGenerarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCodigo.Image = global::Stock.Properties.Resources.codigo_de_barras3;
            this.btnGenerarCodigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarCodigo.Location = new System.Drawing.Point(197, 210);
            this.btnGenerarCodigo.Name = "btnGenerarCodigo";
            this.btnGenerarCodigo.Size = new System.Drawing.Size(141, 38);
            this.btnGenerarCodigo.TabIndex = 163;
            this.btnGenerarCodigo.Text = "Generar Código";
            this.btnGenerarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarCodigo.UseVisualStyleBackColor = false;
            this.btnGenerarCodigo.Visible = false;
            this.btnGenerarCodigo.Click += new System.EventHandler(this.btnGenerarCodigo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Stock.Properties.Resources.mas__2_;
            this.button1.Location = new System.Drawing.Point(398, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 29);
            this.button1.TabIndex = 162;
            this.toolTip1.SetToolTip(this.button1, "Registrar Marca");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-153, -10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 160;
            this.label8.Text = "Categoria(*):";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(165, 73);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(227, 21);
            this.cmbCategoria.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 160;
            this.label7.Text = "Categoria(*):";
            // 
            // chcProductoEspecial
            // 
            this.chcProductoEspecial.AutoSize = true;
            this.chcProductoEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcProductoEspecial.ForeColor = System.Drawing.Color.White;
            this.chcProductoEspecial.Location = new System.Drawing.Point(165, 12);
            this.chcProductoEspecial.Name = "chcProductoEspecial";
            this.chcProductoEspecial.Size = new System.Drawing.Size(142, 21);
            this.chcProductoEspecial.TabIndex = 159;
            this.chcProductoEspecial.Text = "Generar Código";
            this.chcProductoEspecial.UseVisualStyleBackColor = true;
            this.chcProductoEspecial.CheckedChanged += new System.EventHandler(this.chcProductoEspecial_CheckedChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblContador.Location = new System.Drawing.Point(325, 191);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(32, 18);
            this.lblContador.TabIndex = 158;
            this.lblContador.Text = "200";
            this.lblContador.Visible = false;
            this.lblContador.TextChanged += new System.EventHandler(this.lblContador_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(353, 191);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 18);
            this.lblTotal.TabIndex = 157;
            this.lblTotal.Text = "/200";
            this.lblTotal.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnCrear.Enabled = false;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Image = global::Stock.Properties.Resources.mas__2_;
            this.btnCrear.Location = new System.Drawing.Point(398, 107);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(27, 29);
            this.btnCrear.TabIndex = 156;
            this.toolTip1.SetToolTip(this.btnCrear, "Registrar Marca");
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(39, 179);
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
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nuevo Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(103, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(289, 38);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(165, 112);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(227, 21);
            this.cmbMarca.TabIndex = 40;
            this.cmbMarca.Click += new System.EventHandler(this.ActualizarCombo);
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(165, 148);
            this.textBox2.MaxLength = 200;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 40);
            this.textBox2.TabIndex = 39;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProducto.Location = new System.Drawing.Point(165, 38);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(227, 20);
            this.txtCodigoProducto.TabIndex = 36;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(43, 159);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(116, 17);
            this.txtDescripcion.TabIndex = 35;
            this.txtDescripcion.Text = "Descripción(*):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Código Producto(*):";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(95, 534);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 28);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.toolTip1.SetToolTip(this.btnEditar, "Editar Producto");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(12, 534);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(77, 28);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "Nuevo";
            this.toolTip1.SetToolTip(this.btnNuevo, "Editar Producto");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargaMasiva
            // 
            this.btnCargaMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnCargaMasiva.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCargaMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaMasiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargaMasiva.Location = new System.Drawing.Point(302, 534);
            this.btnCargaMasiva.Name = "btnCargaMasiva";
            this.btnCargaMasiva.Size = new System.Drawing.Size(112, 28);
            this.btnCargaMasiva.TabIndex = 49;
            this.btnCargaMasiva.Text = "Carga Masiva";
            this.toolTip1.SetToolTip(this.btnCargaMasiva, "Eliminar Producto");
            this.btnCargaMasiva.UseVisualStyleBackColor = false;
            this.btnCargaMasiva.Visible = false;
            this.btnCargaMasiva.Click += new System.EventHandler(this.btnCargaMasiva_Click);
            // 
            // btnImprimirCod
            // 
            this.btnImprimirCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnImprimirCod.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnImprimirCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCod.ForeColor = System.Drawing.Color.White;
            this.btnImprimirCod.Location = new System.Drawing.Point(178, 534);
            this.btnImprimirCod.Name = "btnImprimirCod";
            this.btnImprimirCod.Size = new System.Drawing.Size(118, 28);
            this.btnImprimirCod.TabIndex = 50;
            this.btnImprimirCod.Text = "Imprimir Código";
            this.toolTip1.SetToolTip(this.btnImprimirCod, "Editar Producto");
            this.btnImprimirCod.UseVisualStyleBackColor = false;
            this.btnImprimirCod.Click += new System.EventHandler(this.btnImprimirCod_Click);
            // 
            // txtDescipcionBus
            // 
            this.txtDescipcionBus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescipcionBus.Location = new System.Drawing.Point(154, 73);
            this.txtDescipcionBus.Name = "txtDescipcionBus";
            this.txtDescipcionBus.Size = new System.Drawing.Size(219, 20);
            this.txtDescipcionBus.TabIndex = 44;
            this.txtDescipcionBus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescipcionBus_KeyDown);
            // 
            // txtCodigoBus
            // 
            this.txtCodigoBus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBus.Location = new System.Drawing.Point(491, 73);
            this.txtCodigoBus.Name = "txtCodigoBus";
            this.txtCodigoBus.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoBus.TabIndex = 45;
            this.txtCodigoBus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Buscar por Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(378, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Buscar por Código";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ProductoNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1099, 564);
            this.Controls.Add(this.btnImprimirCod);
            this.Controls.Add(this.btnCargaMasiva);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoBus);
            this.Controls.Add(this.txtDescipcionBus);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductoNuevoWF";
            this.Text = "ProductoNuevoWF";
            this.Load += new System.EventHandler(this.ProductoNuevoWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtDescipcionBus;
        private System.Windows.Forms.TextBox txtCodigoBus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargaMasiva;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.CheckBox chcProductoEspecial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerarCodigo;
        private System.Windows.Forms.Panel panelCodigo;
        private System.Windows.Forms.Button btnImprimirCodigo;
        private System.Windows.Forms.Button btnImprimirCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label8;
    }
}
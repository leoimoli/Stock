namespace Stock
{
    partial class Reportes_VentasNuevoWF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_VentasNuevoWF));
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelResultado = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCuentaDni = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.Button();
            this.txtMercadoPago = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.txtDebito = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txtCredito = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCajaVentas = new System.Windows.Forms.Label();
            this.btnCajaVentas = new System.Windows.Forms.Button();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.btnVentasGenerales = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEsteMes = new System.Windows.Forms.Button();
            this.btnVentasMesAnterior = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUltimosTreinta = new System.Windows.Forms.Button();
            this.btnVentasUltimosSiete = new System.Windows.Forms.Button();
            this.btnVentasAyer = new System.Windows.Forms.Button();
            this.btnVentasDelDia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.PanelResultado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(2, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1296, 37);
            this.panel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(577, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Reportes de Ventas";
            // 
            // PanelResultado
            // 
            this.PanelResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelResultado.Controls.Add(this.groupBox1);
            this.PanelResultado.Controls.Add(this.btnEliminar);
            this.PanelResultado.Controls.Add(this.btnExportar);
            this.PanelResultado.Controls.Add(this.dgvVentas);
            this.PanelResultado.Controls.Add(this.label1);
            this.PanelResultado.Controls.Add(this.lblCajaVentas);
            this.PanelResultado.Controls.Add(this.btnCajaVentas);
            this.PanelResultado.Controls.Add(this.lblTotalVentas);
            this.PanelResultado.Controls.Add(this.btnVentasGenerales);
            this.PanelResultado.Location = new System.Drawing.Point(266, 210);
            this.PanelResultado.Name = "PanelResultado";
            this.PanelResultado.Size = new System.Drawing.Size(795, 383);
            this.PanelResultado.TabIndex = 3;
            this.PanelResultado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCuentaDni);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.txtEfectivo);
            this.groupBox1.Controls.Add(this.txtMercadoPago);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.txtDebito);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.txtCredito);
            this.groupBox1.Location = new System.Drawing.Point(60, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 83);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            // 
            // txtCuentaDni
            // 
            this.txtCuentaDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.txtCuentaDni.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCuentaDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCuentaDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDni.ForeColor = System.Drawing.Color.White;
            this.txtCuentaDni.Image = global::Stock.Properties.Resources.CuentaDNI_Icono;
            this.txtCuentaDni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCuentaDni.Location = new System.Drawing.Point(399, 41);
            this.txtCuentaDni.Name = "txtCuentaDni";
            this.txtCuentaDni.Size = new System.Drawing.Size(128, 34);
            this.txtCuentaDni.TabIndex = 56;
            this.txtCuentaDni.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(537, 11);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(119, 26);
            this.button14.TabIndex = 57;
            this.button14.Text = "Mercado Pago";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.txtEfectivo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.White;
            this.txtEfectivo.Image = global::Stock.Properties.Resources.Efectivo_Icono;
            this.txtEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEfectivo.Location = new System.Drawing.Point(3, 41);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(128, 34);
            this.txtEfectivo.TabIndex = 50;
            this.txtEfectivo.UseVisualStyleBackColor = false;
            // 
            // txtMercadoPago
            // 
            this.txtMercadoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.txtMercadoPago.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMercadoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMercadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMercadoPago.ForeColor = System.Drawing.Color.White;
            this.txtMercadoPago.Image = global::Stock.Properties.Resources.MercadoPago_Icono__2_;
            this.txtMercadoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMercadoPago.Location = new System.Drawing.Point(532, 41);
            this.txtMercadoPago.Name = "txtMercadoPago";
            this.txtMercadoPago.Size = new System.Drawing.Size(128, 34);
            this.txtMercadoPago.TabIndex = 58;
            this.txtMercadoPago.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(16, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 26);
            this.button9.TabIndex = 1;
            this.button9.Text = "Efectivo";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(407, 11);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(115, 26);
            this.button12.TabIndex = 55;
            this.button12.Text = "Cuenta DNI";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.txtDebito.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebito.ForeColor = System.Drawing.Color.White;
            this.txtDebito.Image = global::Stock.Properties.Resources.Debito_Icono;
            this.txtDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDebito.Location = new System.Drawing.Point(136, 41);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(128, 34);
            this.txtDebito.TabIndex = 52;
            this.txtDebito.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(149, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 26);
            this.button7.TabIndex = 51;
            this.button7.Text = "Debito";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(281, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 26);
            this.button10.TabIndex = 53;
            this.button10.Text = "Credito";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.txtCredito.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.ForeColor = System.Drawing.Color.White;
            this.txtCredito.Image = global::Stock.Properties.Resources.Credito_Icono;
            this.txtCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCredito.Location = new System.Drawing.Point(268, 41);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(128, 34);
            this.txtCredito.TabIndex = 54;
            this.txtCredito.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(694, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 47);
            this.btnEliminar.TabIndex = 158;
            this.btnEliminar.Text = "Eliminar Venta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::Stock.Properties.Resources.sobresalir;
            this.btnExportar.Location = new System.Drawing.Point(729, 334);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(46, 40);
            this.btnExportar.TabIndex = 68;
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.btnExportar, "Exportar a Excel");
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeight = 30;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Fecha,
            this.Descripcion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.Location = new System.Drawing.Point(76, 82);
            this.dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVentas.Size = new System.Drawing.Size(594, 212);
            this.dgvVentas.TabIndex = 67;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Nro.Venta";
            this.idProducto.Name = "idProducto";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha De Venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Precio de venta";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(286, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Información General";
            // 
            // lblCajaVentas
            // 
            this.lblCajaVentas.AutoSize = true;
            this.lblCajaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaVentas.ForeColor = System.Drawing.Color.White;
            this.lblCajaVentas.Location = new System.Drawing.Point(518, 52);
            this.lblCajaVentas.Name = "lblCajaVentas";
            this.lblCajaVentas.Size = new System.Drawing.Size(22, 17);
            this.lblCajaVentas.TabIndex = 56;
            this.lblCajaVentas.Text = "@";
            // 
            // btnCajaVentas
            // 
            this.btnCajaVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnCajaVentas.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnCajaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCajaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaVentas.ForeColor = System.Drawing.Color.White;
            this.btnCajaVentas.Image = global::Stock.Properties.Resources.dinero__2_;
            this.btnCajaVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajaVentas.Location = new System.Drawing.Point(428, 29);
            this.btnCajaVentas.Name = "btnCajaVentas";
            this.btnCajaVentas.Size = new System.Drawing.Size(181, 47);
            this.btnCajaVentas.TabIndex = 54;
            this.btnCajaVentas.Text = "Caja de ventas";
            this.btnCajaVentas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCajaVentas.UseVisualStyleBackColor = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(213, 52);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(22, 17);
            this.lblTotalVentas.TabIndex = 52;
            this.lblTotalVentas.Text = "@";
            // 
            // btnVentasGenerales
            // 
            this.btnVentasGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnVentasGenerales.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnVentasGenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasGenerales.ForeColor = System.Drawing.Color.White;
            this.btnVentasGenerales.Image = global::Stock.Properties.Resources.cupon;
            this.btnVentasGenerales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasGenerales.Location = new System.Drawing.Point(129, 29);
            this.btnVentasGenerales.Name = "btnVentasGenerales";
            this.btnVentasGenerales.Size = new System.Drawing.Size(181, 47);
            this.btnVentasGenerales.TabIndex = 51;
            this.btnVentasGenerales.Text = "Total de Ventas";
            this.btnVentasGenerales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVentasGenerales.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtFechaHasta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtFechaDesde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(266, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 136);
            this.panel1.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(107, 101);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(128, 21);
            this.cmbCategoria.TabIndex = 163;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(103, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 156;
            this.label7.Text = "Categoria";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Stock.Properties.Resources.lente;
            this.btnBuscar.Location = new System.Drawing.Point(705, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 40);
            this.btnBuscar.TabIndex = 155;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(484, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 70;
            this.label5.Text = "Fecha Hasta";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaHasta.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHasta.Location = new System.Drawing.Point(488, 46);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(128, 26);
            this.dtFechaHasta.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(103, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Fecha Desde";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaDesde.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(107, 46);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(128, 26);
            this.dtFechaDesde.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(288, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Filtro Personalizado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Stock.Properties.Resources.cancelar2;
            this.pictureBox1.Location = new System.Drawing.Point(1272, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEsteMes);
            this.panel2.Controls.Add(this.btnVentasMesAnterior);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnUltimosTreinta);
            this.panel2.Controls.Add(this.btnVentasUltimosSiete);
            this.panel2.Controls.Add(this.btnVentasAyer);
            this.panel2.Controls.Add(this.btnVentasDelDia);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 544);
            this.panel2.TabIndex = 156;
            // 
            // btnEsteMes
            // 
            this.btnEsteMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnEsteMes.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEsteMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsteMes.ForeColor = System.Drawing.Color.White;
            this.btnEsteMes.Image = ((System.Drawing.Image)(resources.GetObject("btnEsteMes.Image")));
            this.btnEsteMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEsteMes.Location = new System.Drawing.Point(38, 402);
            this.btnEsteMes.Name = "btnEsteMes";
            this.btnEsteMes.Size = new System.Drawing.Size(157, 53);
            this.btnEsteMes.TabIndex = 70;
            this.btnEsteMes.Text = "Mes actual";
            this.btnEsteMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEsteMes.UseVisualStyleBackColor = false;
            this.btnEsteMes.Click += new System.EventHandler(this.btnEsteMes_Click);
            // 
            // btnVentasMesAnterior
            // 
            this.btnVentasMesAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnVentasMesAnterior.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnVentasMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasMesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasMesAnterior.ForeColor = System.Drawing.Color.White;
            this.btnVentasMesAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasMesAnterior.Image")));
            this.btnVentasMesAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasMesAnterior.Location = new System.Drawing.Point(38, 483);
            this.btnVentasMesAnterior.Name = "btnVentasMesAnterior";
            this.btnVentasMesAnterior.Size = new System.Drawing.Size(157, 53);
            this.btnVentasMesAnterior.TabIndex = 69;
            this.btnVentasMesAnterior.Text = "Mes anterior";
            this.btnVentasMesAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasMesAnterior.UseVisualStyleBackColor = false;
            this.btnVentasMesAnterior.Click += new System.EventHandler(this.btnVentasMesAnterior_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(44, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Filtros de Busqueda";
            // 
            // btnUltimosTreinta
            // 
            this.btnUltimosTreinta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnUltimosTreinta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnUltimosTreinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimosTreinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimosTreinta.ForeColor = System.Drawing.Color.White;
            this.btnUltimosTreinta.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimosTreinta.Image")));
            this.btnUltimosTreinta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimosTreinta.Location = new System.Drawing.Point(38, 307);
            this.btnUltimosTreinta.Name = "btnUltimosTreinta";
            this.btnUltimosTreinta.Size = new System.Drawing.Size(157, 53);
            this.btnUltimosTreinta.TabIndex = 55;
            this.btnUltimosTreinta.Text = "Últimos 30 días";
            this.btnUltimosTreinta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimosTreinta.UseVisualStyleBackColor = false;
            this.btnUltimosTreinta.Click += new System.EventHandler(this.btnUltimosTreinta_Click);
            // 
            // btnVentasUltimosSiete
            // 
            this.btnVentasUltimosSiete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnVentasUltimosSiete.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnVentasUltimosSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasUltimosSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasUltimosSiete.ForeColor = System.Drawing.Color.White;
            this.btnVentasUltimosSiete.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasUltimosSiete.Image")));
            this.btnVentasUltimosSiete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasUltimosSiete.Location = new System.Drawing.Point(38, 219);
            this.btnVentasUltimosSiete.Name = "btnVentasUltimosSiete";
            this.btnVentasUltimosSiete.Size = new System.Drawing.Size(157, 53);
            this.btnVentasUltimosSiete.TabIndex = 54;
            this.btnVentasUltimosSiete.Text = "Últimos 7 días";
            this.btnVentasUltimosSiete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasUltimosSiete.UseVisualStyleBackColor = false;
            this.btnVentasUltimosSiete.Click += new System.EventHandler(this.btnVentasUltimosSiete_Click);
            // 
            // btnVentasAyer
            // 
            this.btnVentasAyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnVentasAyer.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnVentasAyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasAyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasAyer.ForeColor = System.Drawing.Color.White;
            this.btnVentasAyer.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasAyer.Image")));
            this.btnVentasAyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasAyer.Location = new System.Drawing.Point(38, 136);
            this.btnVentasAyer.Name = "btnVentasAyer";
            this.btnVentasAyer.Size = new System.Drawing.Size(157, 53);
            this.btnVentasAyer.TabIndex = 53;
            this.btnVentasAyer.Text = "Ayer";
            this.btnVentasAyer.UseVisualStyleBackColor = false;
            this.btnVentasAyer.Click += new System.EventHandler(this.btnVentasAyer_Click);
            // 
            // btnVentasDelDia
            // 
            this.btnVentasDelDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnVentasDelDia.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnVentasDelDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDelDia.ForeColor = System.Drawing.Color.White;
            this.btnVentasDelDia.Image = global::Stock.Properties.Resources.lente;
            this.btnVentasDelDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasDelDia.Location = new System.Drawing.Point(38, 48);
            this.btnVentasDelDia.Name = "btnVentasDelDia";
            this.btnVentasDelDia.Size = new System.Drawing.Size(157, 53);
            this.btnVentasDelDia.TabIndex = 52;
            this.btnVentasDelDia.Text = "Hoy";
            this.btnVentasDelDia.UseVisualStyleBackColor = false;
            this.btnVentasDelDia.Click += new System.EventHandler(this.btnVentasDelDia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1223, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 40);
            this.button1.TabIndex = 157;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes_VentasNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelResultado);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes_VentasNuevoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes_VentasNuevoWF";
            this.Load += new System.EventHandler(this.Reportes_VentasNuevoWF_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Reportes_VentasNuevoWF_Paint);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.PanelResultado.ResumeLayout(false);
            this.PanelResultado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCajaVentas;
        private System.Windows.Forms.Button btnCajaVentas;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Button btnVentasGenerales;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUltimosTreinta;
        private System.Windows.Forms.Button btnVentasUltimosSiete;
        private System.Windows.Forms.Button btnVentasAyer;
        private System.Windows.Forms.Button btnVentasDelDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVentasMesAnterior;
        private System.Windows.Forms.Button btnEsteMes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtCuentaDni;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button txtEfectivo;
        private System.Windows.Forms.Button txtMercadoPago;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button txtDebito;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button txtCredito;
    }
}
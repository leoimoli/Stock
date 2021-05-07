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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes_VentasNuevoWF));
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelResultado = new System.Windows.Forms.Panel();
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
            this.PanelResultado.Controls.Add(this.btnExportar);
            this.PanelResultado.Controls.Add(this.dgvVentas);
            this.PanelResultado.Controls.Add(this.label1);
            this.PanelResultado.Controls.Add(this.lblCajaVentas);
            this.PanelResultado.Controls.Add(this.btnCajaVentas);
            this.PanelResultado.Controls.Add(this.lblTotalVentas);
            this.PanelResultado.Controls.Add(this.btnVentasGenerales);
            this.PanelResultado.Location = new System.Drawing.Point(266, 211);
            this.PanelResultado.Name = "PanelResultado";
            this.PanelResultado.Size = new System.Drawing.Size(795, 404);
            this.PanelResultado.TabIndex = 3;
            this.PanelResultado.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::Stock.Properties.Resources.sobresalir;
            this.btnExportar.Location = new System.Drawing.Point(728, 356);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeight = 30;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Fecha,
            this.Descripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.Location = new System.Drawing.Point(106, 91);
            this.dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVentas.Size = new System.Drawing.Size(534, 224);
            this.dgvVentas.TabIndex = 67;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "id";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 60;
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
            this.label1.Location = new System.Drawing.Point(285, 6);
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
            this.lblCajaVentas.Location = new System.Drawing.Point(516, 54);
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
            this.btnCajaVentas.Location = new System.Drawing.Point(427, 29);
            this.btnCajaVentas.Name = "btnCajaVentas";
            this.btnCajaVentas.Size = new System.Drawing.Size(181, 53);
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
            this.lblTotalVentas.Location = new System.Drawing.Point(210, 54);
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
            this.btnVentasGenerales.Location = new System.Drawing.Point(128, 29);
            this.btnVentasGenerales.Name = "btnVentasGenerales";
            this.btnVentasGenerales.Size = new System.Drawing.Size(181, 53);
            this.btnVentasGenerales.TabIndex = 51;
            this.btnVentasGenerales.Text = "Total de Ventas";
            this.btnVentasGenerales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVentasGenerales.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtFechaHasta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtFechaDesde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(266, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 134);
            this.panel1.TabIndex = 4;
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
            this.label5.Location = new System.Drawing.Point(484, 35);
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
            this.dtFechaHasta.Location = new System.Drawing.Point(488, 62);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(128, 26);
            this.dtFechaHasta.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(103, 35);
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
            this.dtFechaDesde.Location = new System.Drawing.Point(107, 62);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(128, 26);
            this.dtFechaDesde.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(288, 10);
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
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.PanelResultado.ResumeLayout(false);
            this.PanelResultado.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
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
    }
}
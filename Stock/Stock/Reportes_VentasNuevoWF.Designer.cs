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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCajaVentas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.btnVentasGenerales = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.panel8.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(815, 37);
            this.panel8.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(287, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Reportes de Ventas";
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.dgvProductos);
            this.PanelInfo.Controls.Add(this.label1);
            this.PanelInfo.Controls.Add(this.lblCajaVentas);
            this.PanelInfo.Controls.Add(this.button2);
            this.PanelInfo.Controls.Add(this.lblTotalVentas);
            this.PanelInfo.Controls.Add(this.btnVentasGenerales);
            this.PanelInfo.Location = new System.Drawing.Point(31, 184);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(768, 372);
            this.PanelInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(285, 11);
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
            this.lblCajaVentas.Location = new System.Drawing.Point(516, 68);
            this.lblCajaVentas.Name = "lblCajaVentas";
            this.lblCajaVentas.Size = new System.Drawing.Size(22, 17);
            this.lblCajaVentas.TabIndex = 56;
            this.lblCajaVentas.Text = "@";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Stock.Properties.Resources.dinero__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(427, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 53);
            this.button2.TabIndex = 54;
            this.button2.Text = "Caja de ventas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(210, 68);
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
            this.btnVentasGenerales.Location = new System.Drawing.Point(128, 43);
            this.btnVentasGenerales.Name = "btnVentasGenerales";
            this.btnVentasGenerales.Size = new System.Drawing.Size(181, 53);
            this.btnVentasGenerales.TabIndex = 51;
            this.btnVentasGenerales.Text = "Total de Ventas";
            this.btnVentasGenerales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVentasGenerales.UseVisualStyleBackColor = false;
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
            this.Marca});
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
            this.dgvProductos.Location = new System.Drawing.Point(55, 120);
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
            this.dgvProductos.Size = new System.Drawing.Size(638, 234);
            this.dgvProductos.TabIndex = 67;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtFechaHasta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtFechaDesde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(159, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 124);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(157, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Filtros de Busqueda";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaDesde.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaDesde.Location = new System.Drawing.Point(53, 62);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(128, 26);
            this.dtFechaDesde.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(49, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Fecha Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(259, 35);
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
            this.dtFechaHasta.Location = new System.Drawing.Point(263, 62);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(128, 26);
            this.dtFechaHasta.TabIndex = 69;
            // 
            // Reportes_VentasNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(822, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes_VentasNuevoWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes_VentasNuevoWF";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCajaVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Button btnVentasGenerales;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label4;
    }
}
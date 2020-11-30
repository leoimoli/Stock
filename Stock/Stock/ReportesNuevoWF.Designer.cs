namespace Stock
{
    partial class ReportesNuevoWF
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartProveedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPagosProveedores = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.lblCajaVentas = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVentasGenerales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProveedores)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartVentas);
            this.panel1.Location = new System.Drawing.Point(1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 252);
            this.panel1.TabIndex = 0;
            // 
            // chartVentas
            // 
            this.chartVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGreen;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.SeaGreen;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkSeaGreen;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartVentas.Legends.Add(legend4);
            this.chartVentas.Location = new System.Drawing.Point(10, 9);
            this.chartVentas.Name = "chartVentas";
            this.chartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.SeaGreen;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartVentas.Series.Add(series4);
            this.chartVentas.Size = new System.Drawing.Size(523, 214);
            this.chartVentas.TabIndex = 0;
            this.chartVentas.Text = "chartVentas";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title4.ForeColor = System.Drawing.Color.SeaGreen;
            title4.Name = "Title1";
            title4.Text = "Ventas del Año en curso";
            this.chartVentas.Titles.Add(title4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartProveedores);
            this.panel2.Location = new System.Drawing.Point(1, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 252);
            this.panel2.TabIndex = 1;
            // 
            // chartProveedores
            // 
            this.chartProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkSeaGreen;
            chartArea5.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGreen;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chartProveedores.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartProveedores.Legends.Add(legend5);
            this.chartProveedores.Location = new System.Drawing.Point(11, 3);
            this.chartProveedores.Name = "chartProveedores";
            this.chartProveedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.LabelForeColor = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartProveedores.Series.Add(series5);
            this.chartProveedores.Size = new System.Drawing.Size(523, 214);
            this.chartProveedores.TabIndex = 2;
            this.chartProveedores.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title5.ForeColor = System.Drawing.Color.SeaGreen;
            title5.Name = "Title1";
            title5.Text = "Compras a Proveedores";
            this.chartProveedores.Titles.Add(title5);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartProductos);
            this.panel3.Location = new System.Drawing.Point(552, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 252);
            this.panel3.TabIndex = 3;
            // 
            // chartProductos
            // 
            chartArea6.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartProductos.Legends.Add(legend6);
            this.chartProductos.Location = new System.Drawing.Point(12, 3);
            this.chartProductos.Name = "chartProductos";
            this.chartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartProductos.Series.Add(series6);
            this.chartProductos.Size = new System.Drawing.Size(523, 214);
            this.chartProductos.TabIndex = 1;
            this.chartProductos.Text = "chart1";
            title6.ForeColor = System.Drawing.Color.DarkGreen;
            title6.Name = "Title1";
            title6.Text = "Productos más Vendidos";
            this.chartProductos.Titles.Add(title6);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPagosProveedores);
            this.panel4.Controls.Add(this.lblTotalCompras);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.lblCajaVentas);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.lblTotalVentas);
            this.panel4.Controls.Add(this.btnVentasGenerales);
            this.panel4.Location = new System.Drawing.Point(552, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 252);
            this.panel4.TabIndex = 2;
            // 
            // lblPagosProveedores
            // 
            this.lblPagosProveedores.AutoSize = true;
            this.lblPagosProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagosProveedores.ForeColor = System.Drawing.Color.White;
            this.lblPagosProveedores.Location = new System.Drawing.Point(395, 173);
            this.lblPagosProveedores.Name = "lblPagosProveedores";
            this.lblPagosProveedores.Size = new System.Drawing.Size(22, 17);
            this.lblPagosProveedores.TabIndex = 65;
            this.lblPagosProveedores.Text = "@";
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompras.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompras.Location = new System.Drawing.Point(165, 173);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(22, 17);
            this.lblTotalCompras.TabIndex = 63;
            this.lblTotalCompras.Text = "@";
            // 
            // lblCajaVentas
            // 
            this.lblCajaVentas.AutoSize = true;
            this.lblCajaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaVentas.ForeColor = System.Drawing.Color.White;
            this.lblCajaVentas.Location = new System.Drawing.Point(395, 68);
            this.lblCajaVentas.Name = "lblCajaVentas";
            this.lblCajaVentas.Size = new System.Drawing.Size(22, 17);
            this.lblCajaVentas.TabIndex = 56;
            this.lblCajaVentas.Text = "@";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(165, 68);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(22, 17);
            this.lblTotalVentas.TabIndex = 52;
            this.lblTotalVentas.Text = "@";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(543, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 512);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(1, 299);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(544, 10);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(552, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(547, 10);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(1, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1098, 37);
            this.panel8.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Menú Reportes";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Stock.Properties.Resources.ordenador_portatil__1_1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(287, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 53);
            this.button5.TabIndex = 59;
            this.button5.Text = "Pagos  Proveedores";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Stock.Properties.Resources.pagar__2_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(70, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 53);
            this.button4.TabIndex = 58;
            this.button4.Text = "Total de Compras";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.UseVisualStyleBackColor = false;
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
            this.button2.Location = new System.Drawing.Point(287, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 53);
            this.button2.TabIndex = 54;
            this.button2.Text = "Caja de ventas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnVentasGenerales.Location = new System.Drawing.Point(70, 43);
            this.btnVentasGenerales.Name = "btnVentasGenerales";
            this.btnVentasGenerales.Size = new System.Drawing.Size(181, 53);
            this.btnVentasGenerales.TabIndex = 51;
            this.btnVentasGenerales.Text = "Total de Ventas";
            this.btnVentasGenerales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnVentasGenerales.UseVisualStyleBackColor = false;
            // 
            // ReportesNuevoWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1099, 564);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportesNuevoWF";
            this.Text = "ReportesNuevoWF";
            this.Load += new System.EventHandler(this.ReportesNuevoWF_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProveedores)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProveedores;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVentasGenerales;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblPagosProveedores;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblCajaVentas;
        private System.Windows.Forms.Button button2;
    }
}
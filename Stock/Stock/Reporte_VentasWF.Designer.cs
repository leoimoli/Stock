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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarPorUsuario = new System.Windows.Forms.Button();
            this.chcCliente = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnBuscarPorCliente = new System.Windows.Forms.Button();
            this.chcUsuario = new System.Windows.Forms.CheckBox();
            this.chcFecha = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.groupBox1);
            this.grbFiltros.Controls.Add(this.groupBox3);
            this.grbFiltros.Controls.Add(this.chcCliente);
            this.grbFiltros.Controls.Add(this.groupBox2);
            this.grbFiltros.Controls.Add(this.chcUsuario);
            this.grbFiltros.Controls.Add(this.chcFecha);
            this.grbFiltros.Location = new System.Drawing.Point(251, 77);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(680, 200);
            this.grbFiltros.TabIndex = 4;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFechaHasta);
            this.groupBox1.Controls.Add(this.dtFechaDesde);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(57, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por Fechas";
            this.groupBox1.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Stock.Properties.Resources.buscar40X35;
            this.btnBuscar.Location = new System.Drawing.Point(445, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 39);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(283, 40);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHasta.TabIndex = 1;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Location = new System.Drawing.Point(31, 40);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDesde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnBuscarPorUsuario);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(57, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por Usuario";
            this.groupBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Ingrese Dni:";
            // 
            // btnBuscarPorUsuario
            // 
            this.btnBuscarPorUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPorUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPorUsuario.Image = global::Stock.Properties.Resources.buscar40X35;
            this.btnBuscarPorUsuario.Location = new System.Drawing.Point(445, 75);
            this.btnBuscarPorUsuario.Name = "btnBuscarPorUsuario";
            this.btnBuscarPorUsuario.Size = new System.Drawing.Size(49, 39);
            this.btnBuscarPorUsuario.TabIndex = 97;
            this.btnBuscarPorUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarPorUsuario.Visible = false;
            // 
            // chcCliente
            // 
            this.chcCliente.AutoSize = true;
            this.chcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcCliente.Location = new System.Drawing.Point(443, 16);
            this.chcCliente.Name = "chcCliente";
            this.chcCliente.Size = new System.Drawing.Size(105, 24);
            this.chcCliente.TabIndex = 2;
            this.chcCliente.Text = "Por Cliente";
            this.chcCliente.UseVisualStyleBackColor = true;
            this.chcCliente.CheckedChanged += new System.EventHandler(this.chcCliente_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.txtDni);
            this.groupBox2.Controls.Add(this.lblDni);
            this.groupBox2.Controls.Add(this.btnBuscarPorCliente);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(57, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por Cliente";
            this.groupBox2.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(233, 45);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(159, 20);
            this.txtDni.TabIndex = 99;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(118, 43);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(95, 20);
            this.lblDni.TabIndex = 98;
            this.lblDni.Text = "Ingrese Dni:";
            // 
            // btnBuscarPorCliente
            // 
            this.btnBuscarPorCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPorCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPorCliente.Image = global::Stock.Properties.Resources.buscar40X35;
            this.btnBuscarPorCliente.Location = new System.Drawing.Point(445, 75);
            this.btnBuscarPorCliente.Name = "btnBuscarPorCliente";
            this.btnBuscarPorCliente.Size = new System.Drawing.Size(49, 39);
            this.btnBuscarPorCliente.TabIndex = 97;
            this.btnBuscarPorCliente.UseVisualStyleBackColor = false;
            this.btnBuscarPorCliente.Visible = false;
            // 
            // chcUsuario
            // 
            this.chcUsuario.AutoSize = true;
            this.chcUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcUsuario.Location = new System.Drawing.Point(233, 16);
            this.chcUsuario.Name = "chcUsuario";
            this.chcUsuario.Size = new System.Drawing.Size(111, 24);
            this.chcUsuario.TabIndex = 1;
            this.chcUsuario.Text = "Por Usuario";
            this.chcUsuario.UseVisualStyleBackColor = true;
            this.chcUsuario.CheckedChanged += new System.EventHandler(this.chcUsuario_CheckedChanged);
            // 
            // chcFecha
            // 
            this.chcFecha.AutoSize = true;
            this.chcFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcFecha.Location = new System.Drawing.Point(40, 16);
            this.chcFecha.Name = "chcFecha";
            this.chcFecha.Size = new System.Drawing.Size(101, 24);
            this.chcFecha.TabIndex = 0;
            this.chcFecha.Text = "Por Fecha";
            this.chcFecha.UseVisualStyleBackColor = true;
            this.chcFecha.CheckedChanged += new System.EventHandler(this.chcFecha_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(597, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 300);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(251, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 300);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 16);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(330, 280);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Reporte_VentasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbFiltros);
            this.Name = "Reporte_VentasWF";
            this.Text = "Reporte_VentasWF";
            this.Load += new System.EventHandler(this.Reporte_VentasWF_Load);
            this.Controls.SetChildIndex(this.grbFiltros, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPorCliente;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPorUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
namespace Stock
{
    partial class New_MasterWF
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
            this.Master_panel2 = new System.Windows.Forms.Panel();
            this.lblMaster_Version = new System.Windows.Forms.Label();
            this.Master_panel1 = new System.Windows.Forms.Panel();
            this.lblMaster_FechaHoraReal = new System.Windows.Forms.Label();
            this.lblMaster_UsuarioLogin = new System.Windows.Forms.Label();
            this.lblMaster_FechaHora = new System.Windows.Forms.Label();
            this.lblMaster_Usuario = new System.Windows.Forms.Label();
            this.Master_menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCódigoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Master_panel2.SuspendLayout();
            this.Master_panel1.SuspendLayout();
            this.Master_menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Master_panel2
            // 
            this.Master_panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.Master_panel2.Controls.Add(this.lblMaster_Version);
            this.Master_panel2.Location = new System.Drawing.Point(-126, 593);
            this.Master_panel2.Name = "Master_panel2";
            this.Master_panel2.Size = new System.Drawing.Size(1500, 28);
            this.Master_panel2.TabIndex = 5;
            // 
            // lblMaster_Version
            // 
            this.lblMaster_Version.AutoSize = true;
            this.lblMaster_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_Version.ForeColor = System.Drawing.Color.White;
            this.lblMaster_Version.Location = new System.Drawing.Point(499, 5);
            this.lblMaster_Version.Name = "lblMaster_Version";
            this.lblMaster_Version.Size = new System.Drawing.Size(102, 20);
            this.lblMaster_Version.TabIndex = 0;
            this.lblMaster_Version.Text = "Versión 1.0.1";
            // 
            // Master_panel1
            // 
            this.Master_panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Master_panel1.Controls.Add(this.lblMaster_FechaHoraReal);
            this.Master_panel1.Controls.Add(this.lblMaster_UsuarioLogin);
            this.Master_panel1.Controls.Add(this.lblMaster_FechaHora);
            this.Master_panel1.Controls.Add(this.lblMaster_Usuario);
            this.Master_panel1.Location = new System.Drawing.Point(-41, 27);
            this.Master_panel1.Name = "Master_panel1";
            this.Master_panel1.Size = new System.Drawing.Size(1500, 28);
            this.Master_panel1.TabIndex = 4;
            // 
            // lblMaster_FechaHoraReal
            // 
            this.lblMaster_FechaHoraReal.AutoSize = true;
            this.lblMaster_FechaHoraReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_FechaHoraReal.ForeColor = System.Drawing.Color.White;
            this.lblMaster_FechaHoraReal.Location = new System.Drawing.Point(106, 5);
            this.lblMaster_FechaHoraReal.Name = "lblMaster_FechaHoraReal";
            this.lblMaster_FechaHoraReal.Size = new System.Drawing.Size(0, 17);
            this.lblMaster_FechaHoraReal.TabIndex = 4;
            // 
            // lblMaster_UsuarioLogin
            // 
            this.lblMaster_UsuarioLogin.AutoSize = true;
            this.lblMaster_UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_UsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.lblMaster_UsuarioLogin.Location = new System.Drawing.Point(823, 5);
            this.lblMaster_UsuarioLogin.Name = "lblMaster_UsuarioLogin";
            this.lblMaster_UsuarioLogin.Size = new System.Drawing.Size(111, 20);
            this.lblMaster_UsuarioLogin.TabIndex = 2;
            this.lblMaster_UsuarioLogin.Text = "Datos Usuario";
            // 
            // lblMaster_FechaHora
            // 
            this.lblMaster_FechaHora.AutoSize = true;
            this.lblMaster_FechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_FechaHora.ForeColor = System.Drawing.Color.White;
            this.lblMaster_FechaHora.Location = new System.Drawing.Point(12, 5);
            this.lblMaster_FechaHora.Name = "lblMaster_FechaHora";
            this.lblMaster_FechaHora.Size = new System.Drawing.Size(97, 17);
            this.lblMaster_FechaHora.TabIndex = 3;
            this.lblMaster_FechaHora.Text = "Fecha y Hora:";
            // 
            // lblMaster_Usuario
            // 
            this.lblMaster_Usuario.AutoSize = true;
            this.lblMaster_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_Usuario.ForeColor = System.Drawing.Color.White;
            this.lblMaster_Usuario.Location = new System.Drawing.Point(749, 5);
            this.lblMaster_Usuario.Name = "lblMaster_Usuario";
            this.lblMaster_Usuario.Size = new System.Drawing.Size(68, 20);
            this.lblMaster_Usuario.TabIndex = 0;
            this.lblMaster_Usuario.Text = "Usuario:";
            // 
            // Master_menuStrip1
            // 
            this.Master_menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Master_menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.preciosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Master_menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.Master_menuStrip1.Name = "Master_menuStrip1";
            this.Master_menuStrip1.Size = new System.Drawing.Size(1333, 29);
            this.Master_menuStrip1.TabIndex = 3;
            this.Master_menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioToolStripMenuItem.Image = global::Stock.Properties.Resources.inicio_de_web;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Image = global::Stock.Properties.Resources.hombre2_Nuevo;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCódigoProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Image = global::Stock.Properties.Resources.codigo_de_barras_Nuevo;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // editarCódigoProductoToolStripMenuItem
            // 
            this.editarCódigoProductoToolStripMenuItem.Name = "editarCódigoProductoToolStripMenuItem";
            this.editarCódigoProductoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.editarCódigoProductoToolStripMenuItem.Text = "Editar Código Producto";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockToolStripMenuItem.Image = global::Stock.Properties.Resources.almacen_Nuevo;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proveedoresToolStripMenuItem.Image = global::Stock.Properties.Resources.empleado_Nuevo;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Image = global::Stock.Properties.Resources.Clientes_Nuevo;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.Image = global::Stock.Properties.Resources.Ventas1;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Image = global::Stock.Properties.Resources.estadistica;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // preciosToolStripMenuItem
            // 
            this.preciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.preciosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.preciosToolStripMenuItem.Image = global::Stock.Properties.Resources.etiqueta_del_precio;
            this.preciosToolStripMenuItem.Name = "preciosToolStripMenuItem";
            this.preciosToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.preciosToolStripMenuItem.Text = "Precios";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pagosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pagosToolStripMenuItem.Image = global::Stock.Properties.Resources.Pagos_Chico;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(183, 25);
            this.pagosToolStripMenuItem.Text = "Pagos a proveedores";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::Stock.Properties.Resources.Salir_Chico;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // New_MasterWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.Master_panel2);
            this.Controls.Add(this.Master_panel1);
            this.Controls.Add(this.Master_menuStrip1);
            this.Name = "New_MasterWF";
            this.Text = "New_MasterWF";
            this.Master_panel2.ResumeLayout(false);
            this.Master_panel2.PerformLayout();
            this.Master_panel1.ResumeLayout(false);
            this.Master_panel1.PerformLayout();
            this.Master_menuStrip1.ResumeLayout(false);
            this.Master_menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Master_panel2;
        private System.Windows.Forms.Label lblMaster_Version;
        private System.Windows.Forms.Panel Master_panel1;
        private System.Windows.Forms.Label lblMaster_FechaHoraReal;
        private System.Windows.Forms.Label lblMaster_UsuarioLogin;
        private System.Windows.Forms.Label lblMaster_FechaHora;
        private System.Windows.Forms.Label lblMaster_Usuario;
        private System.Windows.Forms.MenuStrip Master_menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCódigoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
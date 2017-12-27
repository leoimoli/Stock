﻿namespace Stock
{
    partial class Master
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
            this.Master_menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Master_panel1 = new System.Windows.Forms.Panel();
            this.lblMaster_FechaHoraReal = new System.Windows.Forms.Label();
            this.lblMaster_UsuarioLogin = new System.Windows.Forms.Label();
            this.lblMaster_FechaHora = new System.Windows.Forms.Label();
            this.lblMaster_Usuario = new System.Windows.Forms.Label();
            this.Master_panel2 = new System.Windows.Forms.Panel();
            this.lblMaster_Version = new System.Windows.Forms.Label();
            this.Master_menuStrip1.SuspendLayout();
            this.Master_panel1.SuspendLayout();
            this.Master_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Master_menuStrip1
            // 
            this.Master_menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Master_menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.Master_menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.Master_menuStrip1.Name = "Master_menuStrip1";
            this.Master_menuStrip1.Size = new System.Drawing.Size(1333, 27);
            this.Master_menuStrip1.TabIndex = 0;
            this.Master_menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Image = global::Stock.Properties.Resources.hombre2;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Image = global::Stock.Properties.Resources.codigo_de_barras;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.stockToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockToolStripMenuItem.Image = global::Stock.Properties.Resources.almacen;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proveedoresToolStripMenuItem.Image = global::Stock.Properties.Resources.empleado;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Image = global::Stock.Properties.Resources.Clientes;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Image = global::Stock.Properties.Resources.estadistica;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // Master_panel1
            // 
            this.Master_panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Master_panel1.Controls.Add(this.lblMaster_FechaHoraReal);
            this.Master_panel1.Controls.Add(this.lblMaster_UsuarioLogin);
            this.Master_panel1.Controls.Add(this.lblMaster_FechaHora);
            this.Master_panel1.Controls.Add(this.lblMaster_Usuario);
            this.Master_panel1.Location = new System.Drawing.Point(0, 27);
            this.Master_panel1.Name = "Master_panel1";
            this.Master_panel1.Size = new System.Drawing.Size(1500, 28);
            this.Master_panel1.TabIndex = 1;
            // 
            // lblMaster_FechaHoraReal
            // 
            this.lblMaster_FechaHoraReal.AutoSize = true;
            this.lblMaster_FechaHoraReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_FechaHoraReal.ForeColor = System.Drawing.Color.White;
            this.lblMaster_FechaHoraReal.Location = new System.Drawing.Point(106, 5);
            this.lblMaster_FechaHoraReal.Name = "lblMaster_FechaHoraReal";
            this.lblMaster_FechaHoraReal.Size = new System.Drawing.Size(95, 17);
            this.lblMaster_FechaHoraReal.TabIndex = 4;
            this.lblMaster_FechaHoraReal.Text = "Fecha Y Hora";
            // 
            // lblMaster_UsuarioLogin
            // 
            this.lblMaster_UsuarioLogin.AutoSize = true;
            this.lblMaster_UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster_UsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.lblMaster_UsuarioLogin.Location = new System.Drawing.Point(782, 5);
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
            this.lblMaster_Usuario.Location = new System.Drawing.Point(708, 5);
            this.lblMaster_Usuario.Name = "lblMaster_Usuario";
            this.lblMaster_Usuario.Size = new System.Drawing.Size(68, 20);
            this.lblMaster_Usuario.TabIndex = 0;
            this.lblMaster_Usuario.Text = "Usuario:";
            // 
            // Master_panel2
            // 
            this.Master_panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.Master_panel2.Controls.Add(this.lblMaster_Version);
            this.Master_panel2.Location = new System.Drawing.Point(-85, 593);
            this.Master_panel2.Name = "Master_panel2";
            this.Master_panel2.Size = new System.Drawing.Size(1500, 28);
            this.Master_panel2.TabIndex = 2;
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
            this.lblMaster_Version.Text = "Versión 1.0.0";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.Master_panel2);
            this.Controls.Add(this.Master_panel1);
            this.Controls.Add(this.Master_menuStrip1);
            this.MainMenuStrip = this.Master_menuStrip1;
            this.Name = "Master";
            this.Text = "Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Master_Load);
            this.Master_menuStrip1.ResumeLayout(false);
            this.Master_menuStrip1.PerformLayout();
            this.Master_panel1.ResumeLayout(false);
            this.Master_panel1.PerformLayout();
            this.Master_panel2.ResumeLayout(false);
            this.Master_panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Master_menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.Panel Master_panel1;
        private System.Windows.Forms.Label lblMaster_Usuario;
        private System.Windows.Forms.Label lblMaster_UsuarioLogin;
        private System.Windows.Forms.Panel Master_panel2;
        private System.Windows.Forms.Label lblMaster_Version;
        private System.Windows.Forms.Label lblMaster_FechaHoraReal;
        private System.Windows.Forms.Label lblMaster_FechaHora;
    }
}
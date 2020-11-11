namespace Stock
{
    partial class ClientesWF
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCodArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVerPagos = new System.Windows.Forms.Button();
            this.btnCancelarDeuda = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDescontar = new System.Windows.Forms.Button();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblDeudaFijo = new System.Windows.Forms.Label();
            this.lblPersonaFijo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsuarioEstadisticas = new System.Windows.Forms.Label();
            this.panel_Clientes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel200 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUltimoMovimientosUsuarios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelInformacion.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Clientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel200.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel100.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(342, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtCodArea
            // 
            this.txtCodArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodArea.Location = new System.Drawing.Point(286, 111);
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.Size = new System.Drawing.Size(50, 20);
            this.txtCodArea.TabIndex = 5;
            this.txtCodArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(284, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Teléfono";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(286, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(284, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Nombre(*)";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(53, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Email";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(53, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(125, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 102;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.btnVerPagos);
            this.panel6.Controls.Add(this.btnCancelarDeuda);
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Controls.Add(this.btnDescontar);
            this.panel6.Controls.Add(this.panelInformacion);
            this.panel6.Location = new System.Drawing.Point(321, 346);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 205);
            this.panel6.TabIndex = 101;
            // 
            // btnVerPagos
            // 
            this.btnVerPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPagos.Image = global::Stock.Properties.Resources.binoculares;
            this.btnVerPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerPagos.Location = new System.Drawing.Point(386, 153);
            this.btnVerPagos.Name = "btnVerPagos";
            this.btnVerPagos.Size = new System.Drawing.Size(65, 52);
            this.btnVerPagos.TabIndex = 105;
            this.btnVerPagos.Text = "Ver Pagos";
            this.btnVerPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnVerPagos, "Descontar Deuda");
            this.btnVerPagos.UseVisualStyleBackColor = false;
            this.btnVerPagos.Visible = false;
            this.btnVerPagos.Click += new System.EventHandler(this.btnVerPagos_Click);
            // 
            // btnCancelarDeuda
            // 
            this.btnCancelarDeuda.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDeuda.Image = global::Stock.Properties.Resources.cancelar;
            this.btnCancelarDeuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarDeuda.Location = new System.Drawing.Point(537, 153);
            this.btnCancelarDeuda.Name = "btnCancelarDeuda";
            this.btnCancelarDeuda.Size = new System.Drawing.Size(65, 52);
            this.btnCancelarDeuda.TabIndex = 104;
            this.btnCancelarDeuda.Text = "Cancelar";
            this.btnCancelarDeuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnCancelarDeuda, "Cancelar Deuda");
            this.btnCancelarDeuda.UseVisualStyleBackColor = false;
            this.btnCancelarDeuda.Visible = false;
            this.btnCancelarDeuda.Click += new System.EventHandler(this.btnCancelarDeuda_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(261, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Visible = false;
            // 
            // btnDescontar
            // 
            this.btnDescontar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescontar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescontar.Image = global::Stock.Properties.Resources.DescontarDeuda_Chico1;
            this.btnDescontar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescontar.Location = new System.Drawing.Point(466, 153);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(65, 52);
            this.btnDescontar.TabIndex = 103;
            this.btnDescontar.Text = "Descontar";
            this.btnDescontar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnDescontar, "Descontar Deuda");
            this.btnDescontar.UseVisualStyleBackColor = false;
            this.btnDescontar.Visible = false;
            this.btnDescontar.Click += new System.EventHandler(this.btnDescontar_Click);
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.LightBlue;
            this.panelInformacion.Controls.Add(this.lblPendiente);
            this.panelInformacion.Controls.Add(this.lblPersona);
            this.panelInformacion.Controls.Add(this.lblDeudaFijo);
            this.panelInformacion.Controls.Add(this.lblPersonaFijo);
            this.panelInformacion.Location = new System.Drawing.Point(5, 3);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(250, 150);
            this.panelInformacion.TabIndex = 2;
            this.panelInformacion.Visible = false;
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.ForeColor = System.Drawing.Color.Black;
            this.lblPendiente.Location = new System.Drawing.Point(117, 70);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(109, 13);
            this.lblPendiente.TabIndex = 31;
            this.lblPendiente.Text = "Nombre Producto:";
            this.lblPendiente.Visible = false;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.ForeColor = System.Drawing.Color.Black;
            this.lblPersona.Location = new System.Drawing.Point(117, 21);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(105, 13);
            this.lblPersona.TabIndex = 30;
            this.lblPersona.Text = "Código Producto:";
            this.lblPersona.Visible = false;
            // 
            // lblDeudaFijo
            // 
            this.lblDeudaFijo.AutoSize = true;
            this.lblDeudaFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudaFijo.ForeColor = System.Drawing.Color.Black;
            this.lblDeudaFijo.Location = new System.Drawing.Point(2, 70);
            this.lblDeudaFijo.Name = "lblDeudaFijo";
            this.lblDeudaFijo.Size = new System.Drawing.Size(109, 13);
            this.lblDeudaFijo.TabIndex = 24;
            this.lblDeudaFijo.Text = "Deuda Pendiente:";
            // 
            // lblPersonaFijo
            // 
            this.lblPersonaFijo.AutoSize = true;
            this.lblPersonaFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaFijo.ForeColor = System.Drawing.Color.Black;
            this.lblPersonaFijo.Location = new System.Drawing.Point(6, 21);
            this.lblPersonaFijo.Name = "lblPersonaFijo";
            this.lblPersonaFijo.Size = new System.Drawing.Size(109, 13);
            this.lblPersonaFijo.TabIndex = 23;
            this.lblPersonaFijo.Text = "Apellido yNombre:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(182, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(139, 25);
            this.lblMensaje.TabIndex = 106;
            this.lblMensaje.Text = "Clientes/Editar";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensaje.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Apellido(*)";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblMensaje);
            this.panel5.Controls.Add(this.lblUsuarioEstadisticas);
            this.panel5.Location = new System.Drawing.Point(321, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 100;
            // 
            // lblUsuarioEstadisticas
            // 
            this.lblUsuarioEstadisticas.AutoSize = true;
            this.lblUsuarioEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEstadisticas.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEstadisticas.Location = new System.Drawing.Point(19, -1);
            this.lblUsuarioEstadisticas.Name = "lblUsuarioEstadisticas";
            this.lblUsuarioEstadisticas.Size = new System.Drawing.Size(157, 25);
            this.lblUsuarioEstadisticas.TabIndex = 1;
            this.lblUsuarioEstadisticas.Text = "Historial Clientes";
            // 
            // panel_Clientes
            // 
            this.panel_Clientes.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Clientes.Controls.Add(this.progressBar1);
            this.panel_Clientes.Controls.Add(this.btnCancelar);
            this.panel_Clientes.Controls.Add(this.btnGuardar);
            this.panel_Clientes.Controls.Add(this.label2);
            this.panel_Clientes.Controls.Add(this.cmbSexo);
            this.panel_Clientes.Controls.Add(this.txtAltura);
            this.panel_Clientes.Controls.Add(this.label1);
            this.panel_Clientes.Controls.Add(this.txtCalle);
            this.panel_Clientes.Controls.Add(this.label14);
            this.panel_Clientes.Controls.Add(this.txtTelefono);
            this.panel_Clientes.Controls.Add(this.txtCodArea);
            this.panel_Clientes.Controls.Add(this.label8);
            this.panel_Clientes.Controls.Add(this.txtNombre);
            this.panel_Clientes.Controls.Add(this.label13);
            this.panel_Clientes.Controls.Add(this.txtEmail);
            this.panel_Clientes.Controls.Add(this.label9);
            this.panel_Clientes.Controls.Add(this.txtApellido);
            this.panel_Clientes.Controls.Add(this.label11);
            this.panel_Clientes.Controls.Add(this.txtDni);
            this.panel_Clientes.Controls.Add(this.label12);
            this.panel_Clientes.Enabled = false;
            this.panel_Clientes.Location = new System.Drawing.Point(321, 96);
            this.panel_Clientes.Name = "panel_Clientes";
            this.panel_Clientes.Size = new System.Drawing.Size(611, 220);
            this.panel_Clientes.TabIndex = 99;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::Stock.Properties.Resources.Eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(204, 177);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 39);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Stock.Properties.Resources.Guardar1;
            this.btnGuardar.Location = new System.Drawing.Point(287, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Sexo(*)";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(286, 28);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(200, 21);
            this.cmbSexo.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltura.Location = new System.Drawing.Point(286, 151);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(200, 20);
            this.txtAltura.TabIndex = 8;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Altura";
            // 
            // txtCalle
            // 
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalle.Location = new System.Drawing.Point(54, 151);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(200, 20);
            this.txtCalle.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(52, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Calle";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(53, 28);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(51, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Número Documento(*)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(321, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 25);
            this.panel3.TabIndex = 98;
            // 
            // lblapellidoNombreEditar
            // 
            this.lblapellidoNombreEditar.AutoSize = true;
            this.lblapellidoNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoNombreEditar.ForeColor = System.Drawing.Color.White;
            this.lblapellidoNombreEditar.Location = new System.Drawing.Point(19, 0);
            this.lblapellidoNombreEditar.Name = "lblapellidoNombreEditar";
            this.lblapellidoNombreEditar.Size = new System.Drawing.Size(139, 25);
            this.lblapellidoNombreEditar.TabIndex = 1;
            this.lblapellidoNombreEditar.Text = "Clientes/Editar";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(77, 9);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(170, 20);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.lblTotal);
            this.panel200.Controls.Add(this.label6);
            this.panel200.Controls.Add(this.lblUltimoMovimientosUsuarios);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Controls.Add(this.btnNuevoCliente);
            this.panel200.Controls.Add(this.label10);
            this.panel200.Controls.Add(this.txtBuscador);
            this.panel200.Location = new System.Drawing.Point(15, 96);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 97;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(226, 426);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total:";
            this.label6.Visible = false;
            // 
            // lblUltimoMovimientosUsuarios
            // 
            this.lblUltimoMovimientosUsuarios.AutoSize = true;
            this.lblUltimoMovimientosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimientosUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUltimoMovimientosUsuarios.Location = new System.Drawing.Point(3, 83);
            this.lblUltimoMovimientosUsuarios.Name = "lblUltimoMovimientosUsuarios";
            this.lblUltimoMovimientosUsuarios.Size = new System.Drawing.Size(117, 17);
            this.lblUltimoMovimientosUsuarios.TabIndex = 25;
            this.lblUltimoMovimientosUsuarios.Text = "Lista Usuarios:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 320);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Silver;
            this.btnNuevoCliente.Image = global::Stock.Properties.Resources.Nuevo_Cliente;
            this.btnNuevoCliente.Location = new System.Drawing.Point(94, 38);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(113, 33);
            this.btnNuevoCliente.TabIndex = 1;
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 12);
            this.label10.MaximumSize = new System.Drawing.Size(100, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dni:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(15, 71);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(294, 25);
            this.panel100.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Clientes";
            // 
            // ClientesWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 749);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_Clientes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ClientesWF";
            this.Text = "ClientesWF";
            this.Load += new System.EventHandler(this.ClientesWF_Load);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_Clientes, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_Clientes.ResumeLayout(false);
            this.panel_Clientes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCodArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblUsuarioEstadisticas;
        private System.Windows.Forms.Panel panel_Clientes;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUltimoMovimientosUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblDeudaFijo;
        private System.Windows.Forms.Label lblPersonaFijo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDescontar;
        private System.Windows.Forms.Button btnCancelarDeuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVerPagos;
        private System.Windows.Forms.Label lblMensaje;
    }
}
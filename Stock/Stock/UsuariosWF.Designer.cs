namespace Stock
{
    partial class UsuariosWF
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
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel200 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDniBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.panel_CargaUsuario = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtRepiteContraseña = new System.Windows.Forms.TextBox();
            this.lblRepitaContraseña = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUsuarioEstadisticas = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFechaUltimaConexion_base = new System.Windows.Forms.Label();
            this.label6lblFechaCreacion_base = new System.Windows.Forms.Label();
            this.lblFechaUltimaConexion = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel100.SuspendLayout();
            this.panel200.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_CargaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(1, 74);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(294, 25);
            this.panel100.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.btnBuscar);
            this.panel200.Controls.Add(this.label10);
            this.panel200.Controls.Add(this.txtDniBuscar);
            this.panel200.Controls.Add(this.btnNuevoUsuario);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Location = new System.Drawing.Point(1, 100);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Image = global::Stock.Properties.Resources.buscar40X35;
            this.btnBuscar.Location = new System.Drawing.Point(236, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 35);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Dni:";
            // 
            // txtDniBuscar
            // 
            this.txtDniBuscar.Location = new System.Drawing.Point(60, 10);
            this.txtDniBuscar.Name = "txtDniBuscar";
            this.txtDniBuscar.Size = new System.Drawing.Size(170, 20);
            this.txtDniBuscar.TabIndex = 16;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(88, 35);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(100, 40);
            this.btnNuevoUsuario.TabIndex = 14;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(316, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 25);
            this.panel3.TabIndex = 3;
            // 
            // lblapellidoNombreEditar
            // 
            this.lblapellidoNombreEditar.AutoSize = true;
            this.lblapellidoNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoNombreEditar.ForeColor = System.Drawing.Color.White;
            this.lblapellidoNombreEditar.Location = new System.Drawing.Point(19, 0);
            this.lblapellidoNombreEditar.Name = "lblapellidoNombreEditar";
            this.lblapellidoNombreEditar.Size = new System.Drawing.Size(228, 25);
            this.lblapellidoNombreEditar.TabIndex = 1;
            this.lblapellidoNombreEditar.Text = "Apellido/Nombre o Editar";
            // 
            // panel_CargaUsuario
            // 
            this.panel_CargaUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_CargaUsuario.Controls.Add(this.checkBox2);
            this.panel_CargaUsuario.Controls.Add(this.checkBox1);
            this.panel_CargaUsuario.Controls.Add(this.lblEstado);
            this.panel_CargaUsuario.Controls.Add(this.cmbPerfil);
            this.panel_CargaUsuario.Controls.Add(this.lblPerfil);
            this.panel_CargaUsuario.Controls.Add(this.txtImagen);
            this.panel_CargaUsuario.Controls.Add(this.txtRepiteContraseña);
            this.panel_CargaUsuario.Controls.Add(this.lblRepitaContraseña);
            this.panel_CargaUsuario.Controls.Add(this.label8);
            this.panel_CargaUsuario.Controls.Add(this.btnCancelar);
            this.panel_CargaUsuario.Controls.Add(this.btnGuardar);
            this.panel_CargaUsuario.Controls.Add(this.btnCargarImagen);
            this.panel_CargaUsuario.Controls.Add(this.dtFechaNacimiento);
            this.panel_CargaUsuario.Controls.Add(this.txtApellido);
            this.panel_CargaUsuario.Controls.Add(this.txtNombre);
            this.panel_CargaUsuario.Controls.Add(this.txtContraseña);
            this.panel_CargaUsuario.Controls.Add(this.txtDni);
            this.panel_CargaUsuario.Controls.Add(this.lblContraseña);
            this.panel_CargaUsuario.Controls.Add(this.label5);
            this.panel_CargaUsuario.Controls.Add(this.label4);
            this.panel_CargaUsuario.Controls.Add(this.label3);
            this.panel_CargaUsuario.Controls.Add(this.pictureBox1);
            this.panel_CargaUsuario.Enabled = false;
            this.panel_CargaUsuario.Location = new System.Drawing.Point(316, 100);
            this.panel_CargaUsuario.Name = "panel_CargaUsuario";
            this.panel_CargaUsuario.Size = new System.Drawing.Size(611, 220);
            this.panel_CargaUsuario.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(390, 175);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Inactivo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(328, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(264, 175);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 17);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Visible = false;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(327, 151);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(170, 21);
            this.cmbPerfil.TabIndex = 12;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.Black;
            this.lblPerfil.Location = new System.Drawing.Point(258, 152);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(69, 17);
            this.lblPerfil.TabIndex = 19;
            this.lblPerfil.Text = "Perfil(*):";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(8, 165);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(150, 20);
            this.txtImagen.TabIndex = 18;
            // 
            // txtRepiteContraseña
            // 
            this.txtRepiteContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRepiteContraseña.Location = new System.Drawing.Point(327, 125);
            this.txtRepiteContraseña.Name = "txtRepiteContraseña";
            this.txtRepiteContraseña.PasswordChar = '*';
            this.txtRepiteContraseña.Size = new System.Drawing.Size(170, 20);
            this.txtRepiteContraseña.TabIndex = 11;
            // 
            // lblRepitaContraseña
            // 
            this.lblRepitaContraseña.AutoSize = true;
            this.lblRepitaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepitaContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblRepitaContraseña.Location = new System.Drawing.Point(161, 128);
            this.lblRepitaContraseña.Name = "lblRepitaContraseña";
            this.lblRepitaContraseña.Size = new System.Drawing.Size(166, 17);
            this.lblRepitaContraseña.TabIndex = 16;
            this.lblRepitaContraseña.Text = "Repita Contraseña(*):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(272, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dni(*):";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Location = new System.Drawing.Point(330, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.Location = new System.Drawing.Point(425, 195);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Silver;
            this.btnCargarImagen.Location = new System.Drawing.Point(39, 195);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 13;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Visible = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(327, 73);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(170, 20);
            this.dtFechaNacimiento.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(327, 25);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(170, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(327, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContraseña.Location = new System.Drawing.Point(327, 99);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(170, 20);
            this.txtContraseña.TabIndex = 10;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(327, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(170, 20);
            this.txtDni.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(213, 102);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(114, 17);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña(*):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(164, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(240, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(238, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido(*):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(8, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(290, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblUsuarioEstadisticas);
            this.panel5.Controls.Add(this.lblInformacion);
            this.panel5.Location = new System.Drawing.Point(316, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 5;
            // 
            // lblUsuarioEstadisticas
            // 
            this.lblUsuarioEstadisticas.AutoSize = true;
            this.lblUsuarioEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEstadisticas.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEstadisticas.Location = new System.Drawing.Point(19, 0);
            this.lblUsuarioEstadisticas.Name = "lblUsuarioEstadisticas";
            this.lblUsuarioEstadisticas.Size = new System.Drawing.Size(116, 25);
            this.lblUsuarioEstadisticas.TabIndex = 1;
            this.lblUsuarioEstadisticas.Text = "Estadisticas";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(141, 1);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(393, 25);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "No hay información del usuario para mostrar";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.lblFechaUltimaConexion_base);
            this.panel6.Controls.Add(this.label6lblFechaCreacion_base);
            this.panel6.Controls.Add(this.lblFechaUltimaConexion);
            this.panel6.Controls.Add(this.lblFechaCreacion);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(316, 369);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 187);
            this.panel6.TabIndex = 6;
            // 
            // lblFechaUltimaConexion_base
            // 
            this.lblFechaUltimaConexion_base.AutoSize = true;
            this.lblFechaUltimaConexion_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaUltimaConexion_base.ForeColor = System.Drawing.Color.Black;
            this.lblFechaUltimaConexion_base.Location = new System.Drawing.Point(212, 32);
            this.lblFechaUltimaConexion_base.Name = "lblFechaUltimaConexion_base";
            this.lblFechaUltimaConexion_base.Size = new System.Drawing.Size(24, 18);
            this.lblFechaUltimaConexion_base.TabIndex = 4;
            this.lblFechaUltimaConexion_base.Text = "@";
            this.lblFechaUltimaConexion_base.Visible = false;
            // 
            // label6lblFechaCreacion_base
            // 
            this.label6lblFechaCreacion_base.AutoSize = true;
            this.label6lblFechaCreacion_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6lblFechaCreacion_base.ForeColor = System.Drawing.Color.Black;
            this.label6lblFechaCreacion_base.Location = new System.Drawing.Point(213, 1);
            this.label6lblFechaCreacion_base.Name = "label6lblFechaCreacion_base";
            this.label6lblFechaCreacion_base.Size = new System.Drawing.Size(24, 18);
            this.label6lblFechaCreacion_base.TabIndex = 3;
            this.label6lblFechaCreacion_base.Text = "@";
            this.label6lblFechaCreacion_base.Visible = false;
            // 
            // lblFechaUltimaConexion
            // 
            this.lblFechaUltimaConexion.AutoSize = true;
            this.lblFechaUltimaConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaUltimaConexion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaUltimaConexion.Location = new System.Drawing.Point(10, 32);
            this.lblFechaUltimaConexion.Name = "lblFechaUltimaConexion";
            this.lblFechaUltimaConexion.Size = new System.Drawing.Size(205, 18);
            this.lblFechaUltimaConexion.TabIndex = 2;
            this.lblFechaUltimaConexion.Text = "Fecha de ultima conexión:";
            this.lblFechaUltimaConexion.Visible = false;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCreacion.Location = new System.Drawing.Point(100, 0);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(115, 18);
            this.lblFechaCreacion.TabIndex = 1;
            this.lblFechaCreacion.Text = "Fecha de Alta:";
            this.lblFechaCreacion.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(419, 322);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 93;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // UsuariosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 704);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_CargaUsuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UsuariosWF";
            this.Text = "UsuariosWF";
            this.Load += new System.EventHandler(this.UsuariosWF_Load);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_CargaUsuario, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_CargaUsuario.ResumeLayout(false);
            this.panel_CargaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_CargaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblUsuarioEstadisticas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRepiteContraseña;
        private System.Windows.Forms.Label lblRepitaContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDniBuscar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaUltimaConexion;
        private System.Windows.Forms.Label lblFechaUltimaConexion_base;
        private System.Windows.Forms.Label label6lblFechaCreacion_base;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
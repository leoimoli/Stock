namespace Stock
{
    partial class PrecioDeVentaWF
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
            this.panel_Producto = new System.Windows.Forms.Panel();
            this.lblEnProgreso = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioActualVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioActualFijo = new System.Windows.Forms.Label();
            this.txtReditoPorcentual = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecioFijo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblUltimoPrecioFijo = new System.Windows.Forms.Label();
            this.lblValorOMarcaFijo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblapellidoNombreEditar = new System.Windows.Forms.Label();
            this.panel200 = new System.Windows.Forms.Panel();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.chcProveedor = new System.Windows.Forms.CheckBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProductoBuscar = new System.Windows.Forms.TextBox();
            this.chcProducto = new System.Windows.Forms.CheckBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarcaFijo = new System.Windows.Forms.Label();
            this.chcMarca = new System.Windows.Forms.CheckBox();
            this.chcPorCodigo = new System.Windows.Forms.CheckBox();
            this.lblUltimoMovimientosProductos = new System.Windows.Forms.Label();
            this.lblCodigoFijo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel100 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHistorialProducto = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalEdit = new System.Windows.Forms.Label();
            this.panel_Producto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel200.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel100.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Producto
            // 
            this.panel_Producto.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_Producto.Controls.Add(this.lblTotalEdit);
            this.panel_Producto.Controls.Add(this.lblTotal);
            this.panel_Producto.Controls.Add(this.lblEnProgreso);
            this.panel_Producto.Controls.Add(this.txtMarca);
            this.panel_Producto.Controls.Add(this.txtPrecioVenta);
            this.panel_Producto.Controls.Add(this.txtPrecioActualVenta);
            this.panel_Producto.Controls.Add(this.lblPrecioActualFijo);
            this.panel_Producto.Controls.Add(this.txtReditoPorcentual);
            this.panel_Producto.Controls.Add(this.lblPrecioFijo);
            this.panel_Producto.Controls.Add(this.label6);
            this.panel_Producto.Controls.Add(this.txtValorUnit);
            this.panel_Producto.Controls.Add(this.txtTotalCompra);
            this.panel_Producto.Controls.Add(this.lblUltimoPrecioFijo);
            this.panel_Producto.Controls.Add(this.lblValorOMarcaFijo);
            this.panel_Producto.Controls.Add(this.btnCancelar);
            this.panel_Producto.Controls.Add(this.btnGuardar);
            this.panel_Producto.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Producto.Location = new System.Drawing.Point(313, 96);
            this.panel_Producto.Name = "panel_Producto";
            this.panel_Producto.Size = new System.Drawing.Size(611, 220);
            this.panel_Producto.TabIndex = 20;
            // 
            // lblEnProgreso
            // 
            this.lblEnProgreso.AutoSize = true;
            this.lblEnProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnProgreso.ForeColor = System.Drawing.Color.White;
            this.lblEnProgreso.Location = new System.Drawing.Point(220, 150);
            this.lblEnProgreso.Name = "lblEnProgreso";
            this.lblEnProgreso.Size = new System.Drawing.Size(113, 17);
            this.lblEnProgreso.TabIndex = 46;
            this.lblEnProgreso.Text = "En Progreso...";
            this.lblEnProgreso.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(41, 34);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(170, 20);
            this.txtMarca.TabIndex = 45;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(310, 92);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(170, 20);
            this.txtPrecioVenta.TabIndex = 44;
            // 
            // txtPrecioActualVenta
            // 
            this.txtPrecioActualVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioActualVenta.Enabled = false;
            this.txtPrecioActualVenta.Location = new System.Drawing.Point(41, 150);
            this.txtPrecioActualVenta.Name = "txtPrecioActualVenta";
            this.txtPrecioActualVenta.Size = new System.Drawing.Size(170, 20);
            this.txtPrecioActualVenta.TabIndex = 43;
            // 
            // lblPrecioActualFijo
            // 
            this.lblPrecioActualFijo.AutoSize = true;
            this.lblPrecioActualFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioActualFijo.ForeColor = System.Drawing.Color.White;
            this.lblPrecioActualFijo.Location = new System.Drawing.Point(38, 130);
            this.lblPrecioActualFijo.Name = "lblPrecioActualFijo";
            this.lblPrecioActualFijo.Size = new System.Drawing.Size(176, 17);
            this.lblPrecioActualFijo.TabIndex = 42;
            this.lblPrecioActualFijo.Text = "Precio actual de venta:";
            // 
            // txtReditoPorcentual
            // 
            this.txtReditoPorcentual.Enabled = false;
            this.txtReditoPorcentual.Location = new System.Drawing.Point(310, 34);
            this.txtReditoPorcentual.Mask = "000%";
            this.txtReditoPorcentual.Name = "txtReditoPorcentual";
            this.txtReditoPorcentual.Size = new System.Drawing.Size(170, 20);
            this.txtReditoPorcentual.TabIndex = 41;
            this.txtReditoPorcentual.TextChanged += new System.EventHandler(this.txtReditoPorcentual_TextChanged);
            // 
            // lblPrecioFijo
            // 
            this.lblPrecioFijo.AutoSize = true;
            this.lblPrecioFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFijo.ForeColor = System.Drawing.Color.White;
            this.lblPrecioFijo.Location = new System.Drawing.Point(307, 74);
            this.lblPrecioFijo.Name = "lblPrecioFijo";
            this.lblPrecioFijo.Size = new System.Drawing.Size(129, 17);
            this.lblPrecioFijo.TabIndex = 40;
            this.lblPrecioFijo.Text = "Precio de Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(307, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Rédito Porcentual:";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(41, 34);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(170, 20);
            this.txtValorUnit.TabIndex = 36;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Location = new System.Drawing.Point(41, 92);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(170, 20);
            this.txtTotalCompra.TabIndex = 37;
            // 
            // lblUltimoPrecioFijo
            // 
            this.lblUltimoPrecioFijo.AutoSize = true;
            this.lblUltimoPrecioFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoPrecioFijo.ForeColor = System.Drawing.Color.White;
            this.lblUltimoPrecioFijo.Location = new System.Drawing.Point(38, 72);
            this.lblUltimoPrecioFijo.Name = "lblUltimoPrecioFijo";
            this.lblUltimoPrecioFijo.Size = new System.Drawing.Size(234, 17);
            this.lblUltimoPrecioFijo.TabIndex = 35;
            this.lblUltimoPrecioFijo.Text = "Último Precio Total de Compra:";
            // 
            // lblValorOMarcaFijo
            // 
            this.lblValorOMarcaFijo.AutoSize = true;
            this.lblValorOMarcaFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOMarcaFijo.ForeColor = System.Drawing.Color.White;
            this.lblValorOMarcaFijo.Location = new System.Drawing.Point(36, 14);
            this.lblValorOMarcaFijo.Name = "lblValorOMarcaFijo";
            this.lblValorOMarcaFijo.Size = new System.Drawing.Size(163, 17);
            this.lblValorOMarcaFijo.TabIndex = 34;
            this.lblValorOMarcaFijo.Text = "Último Valor Unitario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::Stock.Properties.Resources.Eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(226, 176);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 39);
            this.btnCancelar.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Stock.Properties.Resources.Guardar1;
            this.btnGuardar.Location = new System.Drawing.Point(295, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 39);
            this.btnGuardar.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.lblapellidoNombreEditar);
            this.panel3.Location = new System.Drawing.Point(313, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 25);
            this.panel3.TabIndex = 19;
            // 
            // lblapellidoNombreEditar
            // 
            this.lblapellidoNombreEditar.AutoSize = true;
            this.lblapellidoNombreEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidoNombreEditar.ForeColor = System.Drawing.Color.White;
            this.lblapellidoNombreEditar.Location = new System.Drawing.Point(19, 0);
            this.lblapellidoNombreEditar.Name = "lblapellidoNombreEditar";
            this.lblapellidoNombreEditar.Size = new System.Drawing.Size(207, 25);
            this.lblapellidoNombreEditar.TabIndex = 1;
            this.lblapellidoNombreEditar.Text = "Nuevo precio de venta";
            // 
            // panel200
            // 
            this.panel200.BackColor = System.Drawing.Color.SteelBlue;
            this.panel200.Controls.Add(this.cmbProveedores);
            this.panel200.Controls.Add(this.chcProveedor);
            this.panel200.Controls.Add(this.lblNombreProducto);
            this.panel200.Controls.Add(this.txtNombreProductoBuscar);
            this.panel200.Controls.Add(this.chcProducto);
            this.panel200.Controls.Add(this.cmbMarca);
            this.panel200.Controls.Add(this.lblMarcaFijo);
            this.panel200.Controls.Add(this.chcMarca);
            this.panel200.Controls.Add(this.chcPorCodigo);
            this.panel200.Controls.Add(this.lblUltimoMovimientosProductos);
            this.panel200.Controls.Add(this.lblCodigoFijo);
            this.panel200.Controls.Add(this.txtCodigo);
            this.panel200.Controls.Add(this.dataGridView1);
            this.panel200.Location = new System.Drawing.Point(7, 96);
            this.panel200.Name = "panel200";
            this.panel200.Size = new System.Drawing.Size(294, 455);
            this.panel200.TabIndex = 18;
            this.panel200.Paint += new System.Windows.Forms.PaintEventHandler(this.panel200_Paint);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(36, 61);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(200, 21);
            this.cmbProveedores.TabIndex = 35;
            this.cmbProveedores.Visible = false;
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // chcProveedor
            // 
            this.chcProveedor.AutoSize = true;
            this.chcProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcProveedor.Location = new System.Drawing.Point(175, 27);
            this.chcProveedor.Name = "chcProveedor";
            this.chcProveedor.Size = new System.Drawing.Size(119, 21);
            this.chcProveedor.TabIndex = 34;
            this.chcProveedor.Text = "Por Proveedor";
            this.chcProveedor.UseVisualStyleBackColor = true;
            this.chcProveedor.CheckedChanged += new System.EventHandler(this.chcProveedor_CheckedChanged);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(3, 43);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(160, 17);
            this.lblNombreProducto.TabIndex = 33;
            this.lblNombreProducto.Text = "Últimos Movimientos:";
            this.lblNombreProducto.Visible = false;
            // 
            // txtNombreProductoBuscar
            // 
            this.txtNombreProductoBuscar.Location = new System.Drawing.Point(0, 60);
            this.txtNombreProductoBuscar.Name = "txtNombreProductoBuscar";
            this.txtNombreProductoBuscar.Size = new System.Drawing.Size(280, 20);
            this.txtNombreProductoBuscar.TabIndex = 32;
            this.txtNombreProductoBuscar.Visible = false;
            this.txtNombreProductoBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProductoBuscar_KeyDown);
            // 
            // chcProducto
            // 
            this.chcProducto.AutoSize = true;
            this.chcProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcProducto.Location = new System.Drawing.Point(3, 25);
            this.chcProducto.Name = "chcProducto";
            this.chcProducto.Size = new System.Drawing.Size(164, 21);
            this.chcProducto.TabIndex = 31;
            this.chcProducto.Text = "Por Nombre Producto";
            this.chcProducto.UseVisualStyleBackColor = true;
            this.chcProducto.CheckedChanged += new System.EventHandler(this.chcProducto_CheckedChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(80, 63);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(170, 21);
            this.cmbMarca.TabIndex = 24;
            this.cmbMarca.Visible = false;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblMarcaFijo
            // 
            this.lblMarcaFijo.AutoSize = true;
            this.lblMarcaFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFijo.ForeColor = System.Drawing.Color.White;
            this.lblMarcaFijo.Location = new System.Drawing.Point(22, 63);
            this.lblMarcaFijo.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblMarcaFijo.Name = "lblMarcaFijo";
            this.lblMarcaFijo.Size = new System.Drawing.Size(52, 17);
            this.lblMarcaFijo.TabIndex = 23;
            this.lblMarcaFijo.Text = "Marca";
            this.lblMarcaFijo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMarcaFijo.Visible = false;
            // 
            // chcMarca
            // 
            this.chcMarca.AutoSize = true;
            this.chcMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcMarca.Location = new System.Drawing.Point(175, 9);
            this.chcMarca.Name = "chcMarca";
            this.chcMarca.Size = new System.Drawing.Size(92, 21);
            this.chcMarca.TabIndex = 22;
            this.chcMarca.Text = "Por Marca";
            this.chcMarca.UseVisualStyleBackColor = true;
            this.chcMarca.CheckedChanged += new System.EventHandler(this.chcMarca_CheckedChanged);
            // 
            // chcPorCodigo
            // 
            this.chcPorCodigo.AutoSize = true;
            this.chcPorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcPorCodigo.Location = new System.Drawing.Point(3, 10);
            this.chcPorCodigo.Name = "chcPorCodigo";
            this.chcPorCodigo.Size = new System.Drawing.Size(97, 21);
            this.chcPorCodigo.TabIndex = 21;
            this.chcPorCodigo.Text = "Por Código";
            this.chcPorCodigo.UseVisualStyleBackColor = true;
            this.chcPorCodigo.CheckedChanged += new System.EventHandler(this.chcPorCodigo_CheckedChanged);
            // 
            // lblUltimoMovimientosProductos
            // 
            this.lblUltimoMovimientosProductos.AutoSize = true;
            this.lblUltimoMovimientosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimientosProductos.ForeColor = System.Drawing.Color.White;
            this.lblUltimoMovimientosProductos.Location = new System.Drawing.Point(3, 83);
            this.lblUltimoMovimientosProductos.Name = "lblUltimoMovimientosProductos";
            this.lblUltimoMovimientosProductos.Size = new System.Drawing.Size(160, 17);
            this.lblUltimoMovimientosProductos.TabIndex = 20;
            this.lblUltimoMovimientosProductos.Text = "Últimos Movimientos:";
            // 
            // lblCodigoFijo
            // 
            this.lblCodigoFijo.AutoSize = true;
            this.lblCodigoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFijo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoFijo.Location = new System.Drawing.Point(9, 46);
            this.lblCodigoFijo.MaximumSize = new System.Drawing.Size(100, 0);
            this.lblCodigoFijo.Name = "lblCodigoFijo";
            this.lblCodigoFijo.Size = new System.Drawing.Size(73, 34);
            this.lblCodigoFijo.TabIndex = 19;
            this.lblCodigoFijo.Text = "Código Producto";
            this.lblCodigoFijo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCodigoFijo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtCodigo.TabIndex = 18;
            this.txtCodigo.Visible = false;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel100
            // 
            this.panel100.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel100.Controls.Add(this.label7);
            this.panel100.Location = new System.Drawing.Point(7, 71);
            this.panel100.Name = "panel100";
            this.panel100.Size = new System.Drawing.Size(294, 25);
            this.panel100.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Productos";
            // 
            // lblHistorialProducto
            // 
            this.lblHistorialProducto.AutoSize = true;
            this.lblHistorialProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialProducto.ForeColor = System.Drawing.Color.White;
            this.lblHistorialProducto.Location = new System.Drawing.Point(19, 0);
            this.lblHistorialProducto.Name = "lblHistorialProducto";
            this.lblHistorialProducto.Size = new System.Drawing.Size(221, 25);
            this.lblHistorialProducto.TabIndex = 1;
            this.lblHistorialProducto.Text = "Historial Precio de venta";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.panelInformacion);
            this.panel6.Location = new System.Drawing.Point(313, 365);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 187);
            this.panel6.TabIndex = 22;
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.LightBlue;
            this.panelInformacion.Controls.Add(this.dataGridView2);
            this.panelInformacion.Location = new System.Drawing.Point(30, 18);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(550, 150);
            this.panelInformacion.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 140);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.lblHistorialProducto);
            this.panel5.Location = new System.Drawing.Point(313, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(611, 25);
            this.panel5.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(468, 317);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 96;
            this.progressBar1.Value = 10;
            this.progressBar1.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(373, 198);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(151, 17);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total de Productos:";
            this.lblTotal.Visible = false;
            // 
            // lblTotalEdit
            // 
            this.lblTotalEdit.AutoSize = true;
            this.lblTotalEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEdit.ForeColor = System.Drawing.Color.White;
            this.lblTotalEdit.Location = new System.Drawing.Point(530, 198);
            this.lblTotalEdit.Name = "lblTotalEdit";
            this.lblTotalEdit.Size = new System.Drawing.Size(20, 17);
            this.lblTotalEdit.TabIndex = 48;
            this.lblTotalEdit.Text = "--";
            this.lblTotalEdit.Visible = false;
            // 
            // PrecioDeVentaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 620);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel_Producto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel200);
            this.Controls.Add(this.panel100);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PrecioDeVentaWF";
            this.Text = "Calculo Precio de Venta";
            this.Load += new System.EventHandler(this.PrecioDeVentaWF_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel100, 0);
            this.Controls.SetChildIndex(this.panel200, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_Producto, 0);
            this.Controls.SetChildIndex(this.progressBar1, 0);
            this.panel_Producto.ResumeLayout(false);
            this.panel_Producto.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel200.ResumeLayout(false);
            this.panel200.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel100.ResumeLayout(false);
            this.panel100.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Producto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblapellidoNombreEditar;
        private System.Windows.Forms.Panel panel200;
        private System.Windows.Forms.Label lblUltimoMovimientosProductos;
        private System.Windows.Forms.Label lblCodigoFijo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHistorialProducto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox txtReditoPorcentual;
        private System.Windows.Forms.Label lblPrecioFijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblUltimoPrecioFijo;
        private System.Windows.Forms.Label lblValorOMarcaFijo;
        private System.Windows.Forms.TextBox txtPrecioActualVenta;
        private System.Windows.Forms.Label lblPrecioActualFijo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chcMarca;
        private System.Windows.Forms.CheckBox chcPorCodigo;
        private System.Windows.Forms.Label lblMarcaFijo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.CheckBox chcProducto;
        private System.Windows.Forms.TextBox txtNombreProductoBuscar;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.CheckBox chcProveedor;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblEnProgreso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalEdit;
    }
}
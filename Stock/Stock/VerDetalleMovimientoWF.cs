﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Stock
{
    public partial class VerDetalleMovimientoWF : Form
    {
        private int idMovimiento;
        private string fecha;
        private string proveedor;
        private int facturaPaga;
        public VerDetalleMovimientoWF(int idMovimiento, string fecha, string proveedor, int facturaPaga)
        {
            InitializeComponent();
            this.idMovimiento = idMovimiento;
            this.fecha = fecha;
            this.proveedor = proveedor;
            this.facturaPaga = facturaPaga;
        }

        private void VerDetalleMovimientoWF_Load(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            if (facturaPaga == 1)
            {
                //btnHistorialDePago.Visible = false;

            }
            else
            {
                btnHistorialDePago.BackColor = Color.Red;
                //btnHistorialDePago.Visible = true;
            }
            List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListarDetalleStock(idMovimiento);
            if (ListaProductos.Count > 0)
            {
                foreach (var item in ListaProductos)
                {
                    txtRemito.Text = item.Remito;
                    dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.NombreProducto, item.Cantidad, item.ValorUnitario);
                }
            }
            var lista = ListaProductos.First();
            if (lista.Archivos > 0)
            { PicArchivos.Visible = true; }
            else { PicArchivos.Visible = false; }

            dgvProductos.ReadOnly = true;
            txtProveedor.Text = proveedor;
            txtFecha.Text = fecha;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        WebClient cliente = new WebClient();
        string ruta = null;
        private void PicArchivos_Click(object sender, EventArgs e)
        {
            List<Entidades.Archivos> listaArchivos = new List<Entidades.Archivos>();
            listaArchivos = DAO.ConsultarDao.BuscarArchivos(idMovimiento);
            int Contador = 0;
            foreach (var item in listaArchivos)
            {
                Contador = Contador + 1;
                Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(item.Archivo1);
                pictureBox2.Image = foto1;
                int idArchivo = item.idArchivosCompras;
                string Nombre = idArchivo + "(Proveedor'" + proveedor + "'( '" + Contador + "' ))";
                string folderPath = "C:\\StoCom Archivos\\Archivos\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string ruta = Path.Combine(@"C:\\StoCom Archivos\\Archivos\\ '" + Nombre + "' + .PNG");
                foto1.Save(ruta, ImageFormat.Jpeg);


            }
            const string message2 = "Se descargaron los archivos exitosamente en la carpeta C:\\Descargas Stocom\\.";
            const string caption2 = "Éxito";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void VerDetalleMovimientoWF_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelarDeuda_Click(object sender, EventArgs e)
        {
            Close();
            HistorialPagoProveedoresWF _ver = new HistorialPagoProveedoresWF(idMovimiento);
            _ver.Show();
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Green);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}


namespace Stock
{
    partial class VentasWF
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
            this.panelGrande_Ventas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGrande_Ventas
            // 
            this.panelGrande_Ventas.BackColor = System.Drawing.Color.SteelBlue;
            this.panelGrande_Ventas.Location = new System.Drawing.Point(20, 70);
            this.panelGrande_Ventas.Name = "panelGrande_Ventas";
            this.panelGrande_Ventas.Size = new System.Drawing.Size(700, 450);
            this.panelGrande_Ventas.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(729, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 200);
            this.panel1.TabIndex = 4;
            // 
            // VentasWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGrande_Ventas);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VentasWF";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasWF_Load);
            this.Controls.SetChildIndex(this.panelGrande_Ventas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrande_Ventas;
        private System.Windows.Forms.Panel panel1;
    }
}
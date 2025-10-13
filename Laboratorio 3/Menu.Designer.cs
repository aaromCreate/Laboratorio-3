namespace Laboratorio_3
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MnuBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNumero = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuImporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBanco,
            this.MnuNumero,
            this.MnuImporte,
            this.MnuSesion});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MnuBanco
            // 
            this.MnuBanco.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuBanco.Name = "MnuBanco";
            this.MnuBanco.Size = new System.Drawing.Size(115, 36);
            this.MnuBanco.Text = "BANCO";
            this.MnuBanco.Click += new System.EventHandler(this.MnuBanco_Click);
            // 
            // MnuNumero
            // 
            this.MnuNumero.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuNumero.Name = "MnuNumero";
            this.MnuNumero.Size = new System.Drawing.Size(285, 36);
            this.MnuNumero.Text = "NUMEROS ENTEROS";
            this.MnuNumero.Click += new System.EventHandler(this.MnuNumero_Click);
            // 
            // MnuImporte
            // 
            this.MnuImporte.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuImporte.Name = "MnuImporte";
            this.MnuImporte.Size = new System.Drawing.Size(166, 36);
            this.MnuImporte.Text = "IMPORTES";
            this.MnuImporte.Click += new System.EventHandler(this.MnuImporte_Click);
            // 
            // MnuSesion
            // 
            this.MnuSesion.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuSesion.Name = "MnuSesion";
            this.MnuSesion.Size = new System.Drawing.Size(302, 36);
            this.MnuSesion.Text = "INICIO DE SESION";
            this.MnuSesion.Click += new System.EventHandler(this.MnuSesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Laboratorio#3";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MnuBanco;
        private System.Windows.Forms.ToolStripMenuItem MnuNumero;
        private System.Windows.Forms.ToolStripMenuItem MnuImporte;
        private System.Windows.Forms.ToolStripMenuItem MnuSesion;
    }
}


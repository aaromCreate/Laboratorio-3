namespace Laboratorio_3
{
    partial class Problema3
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.txtImporte = new System.Windows.Forms.Label();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataGridImportes = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dataGridOrdenado = new System.Windows.Forms.DataGridView();
            this.panelImportar = new System.Windows.Forms.Panel();
            this.panelOrdenar = new System.Windows.Forms.Panel();
            this.picImagenTitulo = new System.Windows.Forms.PictureBox();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenado)).BeginInit();
            this.panelImportar.SuspendLayout();
            this.panelOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(374, 54);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(650, 82);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Orden de Importes";
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.Honeydew;
            this.panelEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEncabezado.Controls.Add(this.picImagenTitulo);
            this.panelEncabezado.Controls.Add(this.txtTitulo);
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1208, 197);
            this.panelEncabezado.TabIndex = 2;
            // 
            // txtImporte
            // 
            this.txtImporte.AutoSize = true;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(86, 32);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(142, 37);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.Text = "Importe:";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresar.Location = new System.Drawing.Point(255, 23);
            this.txtIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(148, 48);
            this.txtIngresar.TabIndex = 4;
            this.txtIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresar_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(132, 100);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(210, 68);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar Importe";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridImportes
            // 
            this.dataGridImportes.AllowUserToAddRows = false;
            this.dataGridImportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridImportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridImportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImportes.Location = new System.Drawing.Point(60, 198);
            this.dataGridImportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridImportes.Name = "dataGridImportes";
            this.dataGridImportes.RowHeadersWidth = 62;
            this.dataGridImportes.Size = new System.Drawing.Size(360, 298);
            this.dataGridImportes.TabIndex = 6;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(134, 65);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(224, 68);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar Importe";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dataGridOrdenado
            // 
            this.dataGridOrdenado.AllowUserToAddRows = false;
            this.dataGridOrdenado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrdenado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenado.Location = new System.Drawing.Point(62, 198);
            this.dataGridOrdenado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridOrdenado.Name = "dataGridOrdenado";
            this.dataGridOrdenado.RowHeadersWidth = 62;
            this.dataGridOrdenado.Size = new System.Drawing.Size(360, 298);
            this.dataGridOrdenado.TabIndex = 8;
            // 
            // panelImportar
            // 
            this.panelImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelImportar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImportar.Controls.Add(this.dataGridImportes);
            this.panelImportar.Controls.Add(this.btnIngresar);
            this.panelImportar.Controls.Add(this.txtIngresar);
            this.panelImportar.Controls.Add(this.txtImporte);
            this.panelImportar.Location = new System.Drawing.Point(36, 229);
            this.panelImportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelImportar.Name = "panelImportar";
            this.panelImportar.Size = new System.Drawing.Size(486, 528);
            this.panelImportar.TabIndex = 9;
            // 
            // panelOrdenar
            // 
            this.panelOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelOrdenar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrdenar.Controls.Add(this.dataGridOrdenado);
            this.panelOrdenar.Controls.Add(this.btnOrdenar);
            this.panelOrdenar.Location = new System.Drawing.Point(693, 229);
            this.panelOrdenar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOrdenar.Name = "panelOrdenar";
            this.panelOrdenar.Size = new System.Drawing.Size(479, 528);
            this.panelOrdenar.TabIndex = 10;
            // 
            // picImagenTitulo
            // 
            this.picImagenTitulo.Image = global::Laboratorio_3.Properties.Resources.Anotación_2025_10_02_090856;
            this.picImagenTitulo.Location = new System.Drawing.Point(60, 32);
            this.picImagenTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImagenTitulo.Name = "picImagenTitulo";
            this.picImagenTitulo.Size = new System.Drawing.Size(182, 135);
            this.picImagenTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenTitulo.TabIndex = 1;
            this.picImagenTitulo.TabStop = false;
            // 
            // Problema3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.panelOrdenar);
            this.Controls.Add(this.panelImportar);
            this.Controls.Add(this.panelEncabezado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Problema3";
            this.Text = "Problema3";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenado)).EndInit();
            this.panelImportar.ResumeLayout(false);
            this.panelImportar.PerformLayout();
            this.panelOrdenar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.PictureBox picImagenTitulo;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label txtImporte;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dataGridImportes;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dataGridOrdenado;
        private System.Windows.Forms.Panel panelImportar;
        private System.Windows.Forms.Panel panelOrdenar;
    }
}
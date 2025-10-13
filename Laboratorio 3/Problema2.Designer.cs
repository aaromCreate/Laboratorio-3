namespace Laboratorio_3
{
    partial class Problema2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAzar = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.pnlInsertar = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.pnlInsertar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(440, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 72);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Números Enteros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "Insertar Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cántidad de números:";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.numCantidad.Location = new System.Drawing.Point(368, 168);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(84, 50);
            this.numCantidad.TabIndex = 18;
            // 
            // btnAzar
            // 
            this.btnAzar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnAzar.Location = new System.Drawing.Point(270, 497);
            this.btnAzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAzar.Name = "btnAzar";
            this.btnAzar.Size = new System.Drawing.Size(182, 66);
            this.btnAzar.TabIndex = 19;
            this.btnAzar.Text = "Al azar";
            this.btnAzar.UseVisualStyleBackColor = true;
            this.btnAzar.Click += new System.EventHandler(this.btnAzar_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnEscribir.Location = new System.Drawing.Point(40, 480);
            this.btnEscribir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(182, 100);
            this.btnEscribir.TabIndex = 20;
            this.btnEscribir.Text = "Escribir números";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(40, 232);
            this.lstNumeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(409, 224);
            this.lstNumeros.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 754);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 56);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eliminar Números";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEliminar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.txtEliminar.Location = new System.Drawing.Point(328, 837);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(121, 50);
            this.txtEliminar.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 842);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 44);
            this.label4.TabIndex = 24;
            this.label4.Text = "Número a eliminar:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnBorrar.Location = new System.Drawing.Point(164, 911);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 66);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(574, 154);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 62;
            this.dgvTabla.Size = new System.Drawing.Size(687, 622);
            this.dgvTabla.TabIndex = 26;
            // 
            // pnlInsertar
            // 
            this.pnlInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlInsertar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInsertar.Controls.Add(this.btnInsertar);
            this.pnlInsertar.Location = new System.Drawing.Point(12, 86);
            this.pnlInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInsertar.Name = "pnlInsertar";
            this.pnlInsertar.Size = new System.Drawing.Size(486, 596);
            this.pnlInsertar.TabIndex = 27;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.btnInsertar.Location = new System.Drawing.Point(150, 502);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(182, 66);
            this.btnInsertar.TabIndex = 29;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEliminar.Location = new System.Drawing.Point(12, 738);
            this.pnlEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(486, 271);
            this.pnlEliminar.TabIndex = 28;
            // 
            // Problema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1326, 1005);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnAzar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlInsertar);
            this.Controls.Add(this.pnlEliminar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Problema2";
            this.Text = "Problema2";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.pnlInsertar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAzar;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Panel pnlInsertar;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Button btnInsertar;
    }
}
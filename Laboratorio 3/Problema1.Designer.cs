namespace Laboratorio_3
{
    partial class Problema1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.txtIinicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbSeccion = new System.Windows.Forms.GroupBox();
            this.grbCuenta = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lstRetiro = new System.Windows.Forms.ListBox();
            this.lstDeposito = new System.Windows.Forms.ListBox();
            this.grbTransacciones = new System.Windows.Forms.GroupBox();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbRetiro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.erpCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSaldo = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBanana1 = new System.Windows.Forms.PictureBox();
            this.picBanana2 = new System.Windows.Forms.PictureBox();
            this.grbDatos.SuspendLayout();
            this.grbSeccion.SuspendLayout();
            this.grbCuenta.SuspendLayout();
            this.grbTransacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(420, -115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = "Banco bananero";
            // 
            // grbDatos
            // 
            this.grbDatos.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grbDatos.Controls.Add(this.btnCuenta);
            this.grbDatos.Controls.Add(this.txtIinicial);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.txtCliente);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDatos.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(81, 169);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatos.Size = new System.Drawing.Size(1088, 274);
            this.grbDatos.TabIndex = 11;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Ingrese sus datos";
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(717, 69);
            this.btnCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(214, 66);
            this.btnCuenta.TabIndex = 14;
            this.btnCuenta.Text = "Abrir cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // txtIinicial
            // 
            this.txtIinicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIinicial.Location = new System.Drawing.Point(375, 140);
            this.txtIinicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIinicial.Multiline = true;
            this.txtIinicial.Name = "txtIinicial";
            this.txtIinicial.Size = new System.Drawing.Size(254, 45);
            this.txtIinicial.TabIndex = 5;
            this.txtIinicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIinicial_KeyPress);
            this.txtIinicial.Validating += new System.ComponentModel.CancelEventHandler(this.txtIinicial_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo actual";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(375, 65);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(254, 45);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // grbSeccion
            // 
            this.grbSeccion.Controls.Add(this.grbCuenta);
            this.grbSeccion.Controls.Add(this.grbTransacciones);
            this.grbSeccion.Location = new System.Drawing.Point(116, 468);
            this.grbSeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSeccion.Name = "grbSeccion";
            this.grbSeccion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSeccion.Size = new System.Drawing.Size(1053, 552);
            this.grbSeccion.TabIndex = 13;
            this.grbSeccion.TabStop = false;
            this.grbSeccion.Text = "Cuenta";
            this.grbSeccion.Visible = false;
            // 
            // grbCuenta
            // 
            this.grbCuenta.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grbCuenta.Controls.Add(this.label6);
            this.grbCuenta.Controls.Add(this.label5);
            this.grbCuenta.Controls.Add(this.label4);
            this.grbCuenta.Controls.Add(this.txtMonto);
            this.grbCuenta.Controls.Add(this.btnNuevo);
            this.grbCuenta.Controls.Add(this.txtSaldo);
            this.grbCuenta.Controls.Add(this.lbSaldo);
            this.grbCuenta.Controls.Add(this.lstRetiro);
            this.grbCuenta.Controls.Add(this.lstDeposito);
            this.grbCuenta.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.grbCuenta.Location = new System.Drawing.Point(74, 165);
            this.grbCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCuenta.Name = "grbCuenta";
            this.grbCuenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCuenta.Size = new System.Drawing.Size(944, 397);
            this.grbCuenta.TabIndex = 9;
            this.grbCuenta.TabStop = false;
            this.grbCuenta.Text = "Cuenta de ahorros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "Deposito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 41);
            this.label5.TabIndex = 17;
            this.label5.Text = "Retiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(775, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 43);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location = new System.Drawing.Point(764, 126);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(134, 51);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(646, 220);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(214, 66);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Transaccion";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Location = new System.Drawing.Point(590, 126);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(149, 48);
            this.txtSaldo.TabIndex = 12;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSaldo.Location = new System.Drawing.Point(622, 78);
            this.lbSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(97, 43);
            this.lbSaldo.TabIndex = 11;
            this.lbSaldo.Text = "Saldo";
            // 
            // lstRetiro
            // 
            this.lstRetiro.FormattingEnabled = true;
            this.lstRetiro.ItemHeight = 41;
            this.lstRetiro.Location = new System.Drawing.Point(110, 91);
            this.lstRetiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstRetiro.Name = "lstRetiro";
            this.lstRetiro.Size = new System.Drawing.Size(205, 291);
            this.lstRetiro.TabIndex = 10;
            this.lstRetiro.SelectedIndexChanged += new System.EventHandler(this.lstRetiro_SelectedIndexChanged_1);
            // 
            // lstDeposito
            // 
            this.lstDeposito.FormattingEnabled = true;
            this.lstDeposito.ItemHeight = 41;
            this.lstDeposito.Location = new System.Drawing.Point(356, 91);
            this.lstDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDeposito.Name = "lstDeposito";
            this.lstDeposito.Size = new System.Drawing.Size(205, 291);
            this.lstDeposito.TabIndex = 9;
            this.lstDeposito.SelectedIndexChanged += new System.EventHandler(this.lstDeposito_SelectedIndexChanged_1);
            // 
            // grbTransacciones
            // 
            this.grbTransacciones.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.grbTransacciones.Controls.Add(this.rdbDeposito);
            this.grbTransacciones.Controls.Add(this.rdbRetiro);
            this.grbTransacciones.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.grbTransacciones.Location = new System.Drawing.Point(74, 45);
            this.grbTransacciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTransacciones.Name = "grbTransacciones";
            this.grbTransacciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTransacciones.Size = new System.Drawing.Size(663, 111);
            this.grbTransacciones.TabIndex = 7;
            this.grbTransacciones.TabStop = false;
            this.grbTransacciones.Text = "Transacciones";
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(315, 51);
            this.rdbDeposito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(166, 45);
            this.rdbDeposito.TabIndex = 1;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Deposito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(164, 51);
            this.rdbRetiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(127, 45);
            this.rdbRetiro.TabIndex = 0;
            this.rdbRetiro.TabStop = true;
            this.rdbRetiro.Text = "Retiro";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(405, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 67);
            this.label7.TabIndex = 14;
            this.label7.Text = "Banco Bananero";
            // 
            // erpCliente
            // 
            this.erpCliente.ContainerControl = this;
            // 
            // erpSaldo
            // 
            this.erpSaldo.ContainerControl = this;
            // 
            // picBanana1
            // 
            this.picBanana1.Image = global::Laboratorio_3.Properties.Resources.Banana;
            this.picBanana1.Location = new System.Drawing.Point(159, 33);
            this.picBanana1.Name = "picBanana1";
            this.picBanana1.Size = new System.Drawing.Size(198, 112);
            this.picBanana1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanana1.TabIndex = 15;
            this.picBanana1.TabStop = false;
            // 
            // picBanana2
            // 
            this.picBanana2.Image = global::Laboratorio_3.Properties.Resources.Banana;
            this.picBanana2.Location = new System.Drawing.Point(812, 33);
            this.picBanana2.Name = "picBanana2";
            this.picBanana2.Size = new System.Drawing.Size(188, 110);
            this.picBanana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanana2.TabIndex = 16;
            this.picBanana2.TabStop = false;
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1203, 1050);
            this.Controls.Add(this.picBanana2);
            this.Controls.Add(this.picBanana1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbSeccion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Problema1";
            this.Text = "Problema1";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbSeccion.ResumeLayout(false);
            this.grbCuenta.ResumeLayout(false);
            this.grbCuenta.PerformLayout();
            this.grbTransacciones.ResumeLayout(false);
            this.grbTransacciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanana2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.TextBox txtIinicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbSeccion;
        private System.Windows.Forms.GroupBox grbCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.ListBox lstRetiro;
        private System.Windows.Forms.ListBox lstDeposito;
        private System.Windows.Forms.GroupBox grbTransacciones;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbRetiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider erpCliente;
        private System.Windows.Forms.ErrorProvider erpSaldo;
        private System.Windows.Forms.PictureBox picBanana1;
        private System.Windows.Forms.PictureBox picBanana2;
    }
}
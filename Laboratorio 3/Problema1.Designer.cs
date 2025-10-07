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
            this.grbDatos.SuspendLayout();
            this.grbSeccion.SuspendLayout();
            this.grbCuenta.SuspendLayout();
            this.grbTransacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(280, -75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Banco bananero";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.btnCuenta);
            this.grbDatos.Controls.Add(this.txtIinicial);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.txtCliente);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(54, 110);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(725, 178);
            this.grbDatos.TabIndex = 11;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Ingrese sus datos";
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(465, 42);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(143, 43);
            this.btnCuenta.TabIndex = 14;
            this.btnCuenta.Text = "Abrir cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // txtIinicial
            // 
            this.txtIinicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIinicial.Location = new System.Drawing.Point(250, 91);
            this.txtIinicial.Multiline = true;
            this.txtIinicial.Name = "txtIinicial";
            this.txtIinicial.Size = new System.Drawing.Size(170, 30);
            this.txtIinicial.TabIndex = 5;
            this.txtIinicial.Validating += new System.ComponentModel.CancelEventHandler(this.txtIinicial_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo actual";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(250, 42);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(170, 30);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCliente_Validating_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // grbSeccion
            // 
            this.grbSeccion.Controls.Add(this.grbCuenta);
            this.grbSeccion.Controls.Add(this.grbTransacciones);
            this.grbSeccion.Location = new System.Drawing.Point(77, 304);
            this.grbSeccion.Name = "grbSeccion";
            this.grbSeccion.Size = new System.Drawing.Size(702, 359);
            this.grbSeccion.TabIndex = 13;
            this.grbSeccion.TabStop = false;
            this.grbSeccion.Text = "Cuenta";
            this.grbSeccion.Visible = false;
            // 
            // grbCuenta
            // 
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
            this.grbCuenta.Location = new System.Drawing.Point(49, 107);
            this.grbCuenta.Name = "grbCuenta";
            this.grbCuenta.Size = new System.Drawing.Size(629, 258);
            this.grbCuenta.TabIndex = 9;
            this.grbCuenta.TabStop = false;
            this.grbCuenta.Text = "Cuenta de ahorros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Deposito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Retiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location = new System.Drawing.Point(509, 82);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(90, 34);
            this.txtMonto.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(431, 143);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(143, 43);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Transaccion";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldo.Location = new System.Drawing.Point(393, 82);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 34);
            this.txtSaldo.TabIndex = 12;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(416, 52);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(60, 27);
            this.lbSaldo.TabIndex = 11;
            this.lbSaldo.Text = "saldo";
            // 
            // lstRetiro
            // 
            this.lstRetiro.FormattingEnabled = true;
            this.lstRetiro.ItemHeight = 27;
            this.lstRetiro.Location = new System.Drawing.Point(73, 59);
            this.lstRetiro.Name = "lstRetiro";
            this.lstRetiro.Size = new System.Drawing.Size(138, 193);
            this.lstRetiro.TabIndex = 10;
            this.lstRetiro.SelectedIndexChanged += new System.EventHandler(this.lstRetiro_SelectedIndexChanged_1);
            // 
            // lstDeposito
            // 
            this.lstDeposito.FormattingEnabled = true;
            this.lstDeposito.ItemHeight = 27;
            this.lstDeposito.Location = new System.Drawing.Point(237, 59);
            this.lstDeposito.Name = "lstDeposito";
            this.lstDeposito.Size = new System.Drawing.Size(138, 193);
            this.lstDeposito.TabIndex = 9;
            this.lstDeposito.SelectedIndexChanged += new System.EventHandler(this.lstDeposito_SelectedIndexChanged_1);
            // 
            // grbTransacciones
            // 
            this.grbTransacciones.Controls.Add(this.rdbDeposito);
            this.grbTransacciones.Controls.Add(this.rdbRetiro);
            this.grbTransacciones.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.grbTransacciones.Location = new System.Drawing.Point(49, 29);
            this.grbTransacciones.Name = "grbTransacciones";
            this.grbTransacciones.Size = new System.Drawing.Size(442, 72);
            this.grbTransacciones.TabIndex = 7;
            this.grbTransacciones.TabStop = false;
            this.grbTransacciones.Text = "Transacciones";
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(210, 33);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(113, 31);
            this.rdbDeposito.TabIndex = 1;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Deposito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(109, 33);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(86, 31);
            this.rdbRetiro.TabIndex = 0;
            this.rdbRetiro.TabStop = true;
            this.rdbRetiro.Text = "Retiro";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(270, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 44);
            this.label7.TabIndex = 14;
            this.label7.Text = "Banco bananero";
            // 
            // erpCliente
            // 
            this.erpCliente.ContainerControl = this;
            // 
            // erpSaldo
            // 
            this.erpSaldo.ContainerControl = this;
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 684);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbSeccion);
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
    }
}
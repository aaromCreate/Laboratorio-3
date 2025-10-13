using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema1 : Form
    {
        public Problema1()
        {
            InitializeComponent();
        }
        Cuenta cuenta = new Cuenta();

        private void txtCliente_Validating_1(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                this.erpCliente.SetError((Control)sender, "No puede estar en blanco");
            }
            else
            {
                                this.erpCliente.SetError((Control)sender, "");
            }
        }

        private void txtIinicial_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                this.erpSaldo.SetError((Control)sender, "No puede estar en blanco");

            }
            else
            {
                this.erpSaldo.SetError((Control)sender, "");
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                String cliente = txtCliente.Text;

                double saldoActual = Convert.ToDouble(txtIinicial.Text);
                if (saldoActual < 0)
                {
                    MessageBox.Show("El monto inicial debe ser mayor 0","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    grbSeccion.Visible = true;
                    cuenta.setSaldo(saldoActual);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numerico en los campos de saldo inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if (rdbDeposito.Checked)
            {
                cuenta.depositar(monto);
                txtSaldo.Text = cuenta.getSaldo().ToString();
                lstDeposito.Items.Add(monto);
            }
            else if (rdbRetiro.Checked)
            {
                if (monto > cuenta.getSaldo())
                {
                    MessageBox.Show("No puede retirar mas de lo que tiene en su cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cuenta.retirar(monto);
                    txtSaldo.Text = cuenta.getSaldo().ToString();
                    lstRetiro.Items.Add(monto);
                }
            }
            else
            {
                MessageBox.Show("Seleccione alguna opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void lstRetiro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstRetiro.SelectedItem != null)
            {
                double montoAEliminar = Convert.ToDouble(lstRetiro.SelectedItem);
                cuenta.depositar(montoAEliminar);
                txtSaldo.Text = cuenta.getSaldo().ToString();
                lstRetiro.Items.Remove(lstRetiro.SelectedItem);
            }
        }

        private void lstDeposito_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstDeposito.SelectedItem != null)
            {
                double montoAEliminar = Convert.ToDouble(lstDeposito.SelectedItem);

                if (cuenta.getSaldo() - montoAEliminar < 0)
                {
                    MessageBox.Show("No se puede eliminar esta transacción porque dejaría el saldo negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cuenta.retirar(montoAEliminar);
                    txtSaldo.Text = cuenta.getSaldo().ToString();
                    lstDeposito.Items.Remove(lstDeposito.SelectedItem);
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}


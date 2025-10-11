using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Laboratorio_3
{
    public partial class Problema3 : Form
    {
        public Problema3()
        {
            InitializeComponent();
        }

        Ordenado ordenado = new Ordenado();
        private void txtIngresar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            ordenado.AgregarImporte(txtIngresar.Text);

            txtIngresar.Clear();
            txtIngresar.Focus();

            ordenado.ImprimirImportes(dataGridImportes);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenado.FiltrarImportes();

            ordenado.ImprimirImportesFiltrados(dataGridOrdenado);
        }
    }
}
